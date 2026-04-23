using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHub.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub.Configurations
{
    internal class ConfigationOragnizer :  IEntityTypeConfiguration<Ognaizer>
    {
        void IEntityTypeConfiguration<Ognaizer>.Configure(EntityTypeBuilder<Ognaizer> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.CompanyName).IsRequired(false);
            builder.Property(o => o.Isverified).IsRequired();
            builder.HasOne(o => o.Profile)
                   .WithOne(p => p.Ognaizer)
                   .HasForeignKey<Profile>(p => p.Id);
                
        }
    }
}
