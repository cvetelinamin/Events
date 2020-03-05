using System;
using System.Collections.Generic;
using System.Text;
using EventsForAll.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventsForAll.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Child> Children { get; set; }

        public DbSet<ChildEventCategory> ChildEventCategories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<EventCategory> EventCategories { get; set; }

        public DbSet<Organizer> Organizers { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<UserEvent> UsersEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=myDb;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserEvent>().HasKey(ue => new { ue.ApplicationUserId, ue.EventId });

            builder.Entity<UserEvent>()
                .HasOne<ApplicationUser>(u => u.ApplicationUser)
                .WithMany(ue => ue.UserEvents)
                .HasForeignKey(u => u.ApplicationUserId);

            builder.Entity<UserEvent>()
                .HasOne<Event>(e => e.Event)
                .WithMany(ue => ue.Audience)
                .HasForeignKey(e => e.EventId);

            builder.Entity<Event>()
                .HasOne(e => e.Organizer)
                .WithMany(o => o.Events)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }
    }
}
