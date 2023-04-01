using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Serilog;
using Grapevine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Text;
using BlackRevivalServer.Common.Services;
using Serilog.Core;
using Serilog.Extensions.Logging;
using Discord.WebSocket;
using Discord;
using Discord.Commands;
using Newtonsoft.Json.Linq;

namespace BlackRevivalServer.Discord
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(loggingBuilder =>
          loggingBuilder.AddSerilog(Log.Logger, dispose: true));

        }

    }

    public class DiscordService : Service
    {
        public ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton(new DiscordSocketClient(new DiscordSocketConfig
                {
                    MessageCacheSize = 500,
                    LogLevel = LogSeverity.Info
                }))
                .AddSingleton(new CommandService(new CommandServiceConfig
                {
                    LogLevel = LogSeverity.Info,
                    DefaultRunMode = RunMode.Async,
                    CaseSensitiveCommands = false
                }))
                .AddSingleton<CommandHandlingService>()
                .BuildServiceProvider();
        }

        private Task Log(LogMessage log)
        {
            Serilog.Log.Information(log.ToString());
            return Task.CompletedTask;
        }

        public class Config
        {
            public IPEndPoint WebAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
        }


        public Config config = new Config();
        public override Task Start()
        {
            if (task != null) return task;
            return task = Task.Run(Main);
        }

        public override void Configure(object newConfig)
        {
            config = ((IDictionary<string, object>)newConfig).ToObject<Config>();
        }
        public static DiscordSocketClient discordClient;

        public async void Main()
        {
            Thread.CurrentThread.Name = "DiscordService";
            using var services = ConfigureServices();

            Console.WriteLine("Ready for takeoff...");
            discordClient = services.GetRequiredService<DiscordSocketClient>();

            discordClient.Log += Log;
            services.GetRequiredService<CommandService>().Log += Log;
            Console.WriteLine("Loading Config Files...");
            // Get the bot token from the Config.json file.
            JObject config = DiscordFunctions.GetConfig();
            string token = config["token"].Value<string>();
            await discordClient.LoginAsync(TokenType.Bot, token);
            await discordClient.StartAsync();
            await services.GetRequiredService<CommandHandlingService>().InitializeAsync();





            await Task.Delay(-1);
        }


        public static IService Create() => new DiscordService();
    }
}
