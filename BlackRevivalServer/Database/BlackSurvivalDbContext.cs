using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Database.Configurations;
using BlackRevivalServer.Database.Models;

namespace BlackRevivalServer.Database
{
    internal class BlackSurvivalDbContext : DbContext
    {
        public string ConnectionString { get; set; }
        public DbSet<BlackSurvivalUser> Users { get; set; }
        public DbSet<BlackSurvivalUser> Accounts { get; set; }

        public BlackSurvivalDbContext() { }
        public BlackSurvivalDbContext(string connectionString) { ConnectionString = connectionString; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply Configurations
            builder.ApplyConfiguration(new BlackSurvivalUserConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(ConnectionString);
        }
    }
}
