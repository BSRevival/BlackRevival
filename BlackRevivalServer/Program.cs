using Serilog;
using Jint;
using System.Collections.Generic;
using System.Net;
using System.Text;
using BlackRevivalServer.Common;
using BlackRevivalServer.Common.Services;
using BlackRevivalServer.Common.Util;
using BlackRevivalServer.Database;
using BlackRevivalServer.Discord;
using BlackRevivalServer.GameServer;
using BlackRevivalServer.Http;
using Serilog.Sinks.SystemConsole.Themes;
using Newtonsoft.Json;

namespace BlackRevivalServer
{
    public static class Program
    {
        public static ServiceManager serviceManager;
        private static AsyncEngine jsEngine;
        private static long launchTime;
        private static Config config;
        

        static void Main(string[] args)
        {
            //Make sure to comment this out if not working on discord related functionality on the server. 
            //This is purely for the bot.
            bool UseDiscordBot = false;


            Thread.CurrentThread.Name = "Main";
            launchTime = MonotonicTime.Now;
            serviceManager = new ServiceManager();
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.WithThreadName()
                .Enrich.WithThreadId()
                .Enrich.FromLogContext()
                .WriteTo.Console(outputTemplate: "{Timestamp:HH:mm} [{Level}] [{ThreadName}] {Message}{NewLine}{Exception}")
                .WriteTo.File("BRLog.txt", outputTemplate: "{Timestamp:HH:mm} [{Level}] [{ThreadName}] {Message}{NewLine}{Exception}")
                .MinimumLevel.Debug()
                .CreateLogger();


            WriteLogo();
            Log.Information("Initializing Black Revival server...");
            //string configFileText = @"
            //    var dbService = service('DatabaseService', {});
            //    var authService = service('AuthService', {DatabaseService: dbService});
            //    service('LoginService', {HttpAddr: Address('127.0.0.1:80'), HttpsAddr: Address('127.0.0.1:443'), AuthService: authService});
            //    service('GameService', {KcpAddr: Address('127.0.0.1:22102'), AuthService: authService});
            //";
            
            string configFileText = @"
                service('DatabaseService', {});
                service('DiscordService', {});
                service('WebService', {WebAddress: Address('127.0.0.1:10080')})
                service('GameService', {GameAddress: Address('127.0.0.1:27900')});
            ";

            
            if (!UseDiscordBot)
            {
                configFileText = @"
                    service('DatabaseService', {});
                    service('WebService', {WebAddress: Address('127.0.0.1:10080')})
                    service('GameService', {GameAddress: Address('127.0.0.1:27900')});
                ";
                Log.Information("Registering services...");
                serviceManager.RegisterService("WebService", WebService.Create);
                serviceManager.RegisterService("GameService", GameService.Create);
                serviceManager.RegisterService("DatabaseService", DatabaseService.Create);

            }
            else
            {
                Log.Information("Registering services...");
                serviceManager.RegisterService("WebService", WebService.Create);
                serviceManager.RegisterService("GameService", GameService.Create);
                serviceManager.RegisterService("DatabaseService", DatabaseService.Create);
                serviceManager.RegisterService("DiscordService", DiscordService.Create);
            }





            Log.Information("Services registered.");

            config = new Config();
            Log.Information("Created default configuration.");

            // TODO: move this (JS related stuff) to another class
            jsEngine = new AsyncEngine(cfg => cfg.AllowClr());
            // Misc functions and types
            jsEngine.SetValue("Address", new Func<string, IPEndPoint>(addr => IPEndPoint.Parse(addr)));
            jsEngine.SetValue("debug", new Action<string>(str => Log.Debug(str)));
            // Add required configuration functions
            jsEngine.SetValue("config", config);
            jsEngine.SetValue("service", new Func<string, IDictionary<string, object>, IService>((nam, cfg) => serviceManager.StartService(nam, cfg)));


            Log.Information("Initialized scripting.");

            try
            {
                jsEngine.Execute(configFileText);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                Log.Fatal("Failed to parse configuration.");
                Environment.Exit(1);
            }

            Log.Information(config.InitNotify);

            Log.Information("Initialized services.");

            serviceManager.WaitAll();
        }


        public static void WriteLogo()
        {
            string logo = "";
            logo += "                ▄▄▄▄   ██▓   ▄▄▄      ▄████▄  ██ ▄█▀    ██▀███ ▓███████▒   █▓██▓██▒   █▓▄▄▄      ██▓        " + Environment.NewLine;
            logo += "                ▓█████▄▓██▒  ▒████▄   ▒██▀ ▀█  ██▄█▒    ▓██ ▒ ██▓█   ▓██░   █▓██▓██░   █▒████▄   ▓██▒       " + Environment.NewLine;
            logo += "                ▒██▒ ▄█▒██░  ▒██  ▀█▄ ▒▓█    ▄▓███▄░    ▓██ ░▄█ ▒███  ▓██  █▒▒██▒▓██  █▒▒██  ▀█▄ ▒██░       " + Environment.NewLine;
            logo += "                ▒██░█▀ ▒██░  ░██▄▄▄▄██▒▓▓▄ ▄██▓██ █▄    ▒██▀▀█▄ ▒▓█  ▄ ▒██ █░░██░ ▒██ █░░██▄▄▄▄██▒██░       " + Environment.NewLine;
            logo += "                ░▓█  ▀█░██████▓█   ▓██▒ ▓███▀ ▒██▒ █▄   ░██▓ ▒██░▒████▒ ▒▀█░ ░██░  ▒▀█░  ▓█   ▓██░██████▒   " + Environment.NewLine;
            logo += "                ░▒▓███▀░ ▒░▓  ▒▒   ▓▒█░ ░▒ ▒  ▒ ▒▒ ▓▒   ░ ▒▓ ░▒▓░░ ▒░ ░ ░ ▐░ ░▓    ░ ▐░  ▒▒   ▓▒█░ ▒░▓  ░   " + Environment.NewLine;
            logo += "                ▒░▒   ░░ ░ ▒  ░▒   ▒▒ ░ ░  ▒  ░ ░▒ ▒░     ░▒ ░ ▒░░ ░  ░ ░ ░░  ▒ ░  ░ ░░   ▒   ▒▒ ░ ░ ▒  ░   " + Environment.NewLine;
            logo += "                ░    ░  ░ ░   ░   ▒  ░       ░ ░░ ░      ░░   ░   ░      ░░  ▒ ░    ░░   ░   ▒    ░ ░       " + Environment.NewLine;
            logo += "                ░         ░  ░    ░  ░ ░     ░  ░         ░       ░  ░    ░  ░       ░       ░  ░   ░  ░    " + Environment.NewLine;
            logo += "                ░               ░                                   ░          ░                            " + Environment.NewLine;
            logo += "                                            Black Revival Server                                            " + Environment.NewLine;
            logo += "                                              Verson 0.0.1a                                                 " + Environment.NewLine;

            ColorConsole.WriteWrappedHeader(logo, '-', ConsoleColor.DarkRed, ConsoleColor.DarkGray, 60);

        }
    }
}
