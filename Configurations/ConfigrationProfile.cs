using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Configurations
{
    internal class ConfigrationProfile : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            
                builder.Property(p => p.Bio)
                         .HasMaxLength(500);
            builder.Property(p => p.WebsiteUrl)
                         .HasMaxLength(200);
                builder.Property(p => p.LogoUrl)
                        .HasComment("URL to the profile logo image");
            
        }
    }
}
