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
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
   
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
           

            builder.HasKey(c => new { c.AttendeeId, c.EventId });

            builder.HasOne(e => e.Attendee)
                   .WithMany(e => e.Registrations)
                   .HasForeignKey(e => e.AttendeeId);

            builder.HasOne( e=>  e.Event)
                   .WithMany(e => e.Registrations)
                   .HasForeignKey(e => e.EventId);

         
         
        }
    }
}