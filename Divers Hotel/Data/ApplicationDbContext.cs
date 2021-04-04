using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models.ViewModels;

namespace Divers_Hotel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Guest => Room  one To Many
            builder.Entity<Guest>()
                .HasMany(g => g.Rooms)
                .WithOne(r => r.Guest)
                .HasForeignKey(f => f.GuestID);
          

            // Room => MealPlans  one To one
            builder.Entity<Room>()
              .HasOne(g => g.MealPlan)
              .WithMany(r => r.Rooms)
              .HasForeignKey(f => f.MealPlanID);
            // Room => RoomType  one To one
            builder.Entity<Room>()
              .HasOne(g => g.RoomType)
              .WithMany(r => r.Rooms)
              .HasForeignKey(s => s.RoomTypeID);


        }
        public DbSet<Guest> Guests { set; get; }
        public DbSet<MealPlan> MealPlans { set; get; }
        public DbSet<Room> Rooms { set; get; }
        public DbSet<RoomType> RoomTypes { set; get; }
        public DbSet<Domain.Models.ViewModels.TotalReservation> TotalReservation { get; set; }
    }
}
