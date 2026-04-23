using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHub.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EventHub.Configurations
{
    internal class EventConfiguartion : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Title)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(e => e.Description)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(e => e.EndDate)
                   .IsRequired(false);
            builder.Property(e => e.MaxAttendees)
                   .IsRequired();

            builder.HasOne(e => e.Ognaizer)
                   .WithMany(o => o.Events)
                   .HasForeignKey(e => e.OgnaizerId)
                   .OnDelete(DeleteBehavior.ClientCascade);
  
             builder.HasMany(e => e.WorkShops)
                     .WithOne(e =>  e.ParentEvent)
                     .HasForeignKey(e => e.ParentEventId)
                     .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
