﻿using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;
using System.Data.Common;

namespace SupermarketWEB.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

		public DbSet<Provider> Providers { get; set; }
	}
}
