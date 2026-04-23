using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EventHub.Configurations
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.Id);

            builder.HasOne(b => b.Attende)
                   .WithOne(a => a.Badges)
                   .HasForeignKey<Badge>(b => b.AttendeId);
            builder.Property(e => e.IssuedDate)
                    .HasDefaultValue("GETDETA()");
            builder.Property(e => e.BadgeNumber)
                   .HasMaxLength(100); 
              
        }
    }
}
