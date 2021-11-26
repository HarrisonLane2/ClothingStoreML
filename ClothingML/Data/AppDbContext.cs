﻿using ClothingML.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingML.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductModel> Product { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
