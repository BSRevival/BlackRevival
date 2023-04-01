using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlackRevivalServer.Database.Configurations
{
    internal class BlackSurvivalUserConfiguration : IEntityTypeConfiguration<BlackSurvivalUser>
    {
        public void Configure(EntityTypeBuilder<BlackSurvivalUser> builder)
        {
            builder
                .HasKey(m => m.uid);

            builder
                .Property(m => m.uid);

            builder
                .Property(m => m.name)
                .IsRequired();

            builder
                .Property(m => m.email)
                .IsRequired();

            builder
                .Property(m => m.password)
                .IsRequired();
        }
    }
}
