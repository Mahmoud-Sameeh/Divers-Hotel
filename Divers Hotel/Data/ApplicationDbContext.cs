using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
            // Guest => FamilyMembers  one To one

            builder.Entity<Guest>()
                .HasOne(g => g.FamilyMember)
                .WithOne(r => r.Guest)
                .HasForeignKey<FamilyMembers>(f=>f.GuestId);

            // Room => MealPlans  one To one
            builder.Entity<Room>()
              .HasOne(g => g.MealPlan)
              .WithOne(r => r.Room)
              .HasForeignKey<Room>(f => f.MealPlanID);
            // Room => RoomType  one To one
            builder.Entity<Room>()
              .HasOne(g => g.RoomType)
              .WithOne(r => r.Room)
              .HasForeignKey<Room>(f => f.RoomTypeID);


        }
        public DbSet<Guest> Guests { set; get; }
        public DbSet<MealPlan> MealPlans { set; get; }
        public DbSet<Room> Rooms { set; get; }
        public DbSet<RoomType> RoomTypes { set; get; }
    }
}
