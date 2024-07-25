using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using BlazorApp6_EF.Models;

namespace BlazorApp6_EF.Data
{
    public class GSDbContext: DbContext
    {
        public GSDbContext(DbContextOptions<GSDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, Name = "Order1", Price = 10.0M },
                new Order { OrderId = 2, Name = "Order2", Price = 20.0M },
                new Order { OrderId = 3, Name = "Order3", Price = 30.0M }
            );
        }
    }
}

/*
 dotnet ef migrations add InitialCreate
dotnet ef database update
 */