﻿using FoodEcom.Services.OrderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodEcom.Services.OrderAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
    }
}
