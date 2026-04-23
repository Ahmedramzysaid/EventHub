using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.DbContextFile
{
    public class ApplicationDbContextcs :  DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS04;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContextcs).Assembly);
        }

        DbSet<Ognaizer> Ognaizers { get; set; }
        DbSet<Registration> Registrations { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Attende> Attendees { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<Badge> Badges { get; set; }
    }
}
