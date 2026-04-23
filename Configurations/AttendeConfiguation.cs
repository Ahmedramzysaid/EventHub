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
    public class AttendeConfiguation : IEntityTypeConfiguration<Attende>
    {
        public void Configure(EntityTypeBuilder<Attende> builder)
        {
            builder.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(265);

            builder.Property(a => a.FullName)
       .IsRequired()
       .HasMaxLength(100);

            builder.Property(a => a.Street)
                  .IsRequired()
                  .HasMaxLength(200);

            builder.Property(a => a.City)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(a => a.Country)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(a => a.PostalCode)
                  .IsRequired()
                  .HasMaxLength(20);


        }
    }
}
