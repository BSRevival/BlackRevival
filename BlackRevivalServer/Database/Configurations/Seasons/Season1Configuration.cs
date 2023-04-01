using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Database.Models;

namespace BlackRevivalServer.Database.Configurations
{
    internal class Season1Configuration : IEntityTypeConfiguration<Season1>
    {
        public void Configure(EntityTypeBuilder<Season1> builder)
        {
            builder
                .Property(m => m.num)
                .IsRequired();

            builder
                .Property(m => m.ssn);

            builder
                .Property(m => m.sou)
                .IsRequired();

            builder
                .Property(m => m.nic)
                .IsRequired();

            builder
                .Property(m => m.sop)
                .IsRequired();

            //builder
            //    .Property(m => m.name)
            //    .IsRequired();

            //builder
            //    .Property(m => m.email)
            //    .IsRequired();

            //builder
            //    .Property(m => m.password)
            //    .IsRequired();
        }
    }
}
