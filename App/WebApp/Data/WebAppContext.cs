﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
