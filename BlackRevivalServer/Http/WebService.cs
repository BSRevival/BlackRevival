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
using BlackRevivalServer.Database;

namespace BlackRevivalServer.Http
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(loggingBuilder =>
          loggingBuilder.AddSerilog(Log.Logger, dispose: true));

        }

        public void ConfigureServer(IRestServer server)
        {
            server.Prefixes.Clear();
            server.Prefixes.Add("http://127.0.0.1:10080/");
        }
    }

    public class WebService : Service
    {
        public class Config
        {
            public IPEndPoint WebAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10080);
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
        private IRestServer _server;
        private static Logger _log;

        public async void Main()
        {
            Logger log = null;
            _server = RestServerBuilder.From<Startup>().Build();
            var folderPath = Path.Combine(Directory.GetCurrentDirectory());

            _server.ContentFolders.Add(folderPath);

            _server.UseContentFolders();
            _server.RouteScanner.Scan("BlackRevivalServer.WebAPI");
            Thread.CurrentThread.Name = "WebService";
            Log.Information("Initializing...");
            _server.AfterStarting += (s) =>
            {
                var sb = new StringBuilder(Environment.NewLine);
                sb.Append($"********************************************************************************{Environment.NewLine}");
                sb.Append($"* Server listening on {string.Join(", ", _server.Prefixes)}{Environment.NewLine}");
                sb.Append($"* Web Routes Discovered {_server.Router.RoutingTable.Count}{Environment.NewLine}");
                foreach(var route in _server.Router.RoutingTable)
                {
                    sb.Append($"* Route: {route.Name}{Environment.NewLine}");
                }
                sb.Append($"* Web Routes Discovered {_server.Router.RoutingTable.Count}{Environment.NewLine}");
                sb.Append($"********************************************************************************{Environment.NewLine}");

                Log.Information(sb.ToString());
            };


            _server.Start();

            





            _State = ServiceState.RUNNING;
            Log.Information("Ready.");
            Log.Information("Listening on {ipEndpoint}", config.WebAddress);

            //while (_State == ServiceState.RUNNING)
            //{
            try
            {
                await Task.Delay(-1);
                //await HTTPParser.ProcessRequest(context);
            }
            catch (Exception ex)
            {
                Log.Debug("Internal error: {exc}", ex);
            }
            //}
            

        }
        [RestRoute(Name = "Default Route", Description = "The default route is diabled by default", Enabled = true)]
        public async Task DefaultRoute(IHttpContext context)
        {
            Log.Debug($"UNHANDLED REQ: {context.Request.Name}");
            await context.Response.SendResponseAsync(Grapevine.HttpStatusCode.Ok);
        }


        public static IService Create() => new WebService();
    }
}
