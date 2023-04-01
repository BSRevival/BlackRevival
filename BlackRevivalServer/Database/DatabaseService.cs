using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using BlackRevivalServer.Database;
using BlackRevivalServer.Database.Models;
using System.Collections.Generic;
using BlackRevivalServer.Common.Services;
using Serilog;

namespace BlackRevivalServer.Database
{
    public class DatabaseService : Service
    {
        public class Config
        {
            public string ConnectionString = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "server.db")}";
        }

        public Config config = new Config();

        internal BlackSurvivalDbContext DB { get { return dbContext; } }
        internal BlackSurvivalDbContext dbContext;

        public override Task Start()
        {
            if (task != null) return task;
            return task = Task.Run(Main);
        }

        public async void Main()
        {
            Thread.CurrentThread.Name = "DatabaseService";
            _State = ServiceState.RUNNING;
            Log.Information("Initializing...");
            Initialize();

            await dbContext.Database.EnsureCreatedAsync();

            //if ((await dbContext.Accounts.FindAsync((ulong)7562069)) == null)
            //    await dbContext.AddAsync(new BlackSurvivalUser() { email = "some@email.com", country_code = "US", last_seen = DateTime.Now, name = "ReplaceNameHere", password = "test", uid = 7562069 });
            
            //await dbContext.SaveChangesAsync();

            Log.Information("Ready");
            while (_State == ServiceState.RUNNING)
                await Task.Delay(1000);

            dbContext.Dispose();
            _State = ServiceState.STOPPED;
        }

        public override void Configure(object newConfig)
        {
            config = ((IDictionary<string, object>)newConfig).ToObject<Config>();
        }

        private void Initialize()
        {
            dbContext = new BlackSurvivalDbContext(config.ConnectionString);
        }

        public static IService Create() => new DatabaseService();
    }
}