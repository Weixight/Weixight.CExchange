using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Weixight.CExchange.Entity;
using Weixight.CExchange.Entity.Model;

namespace Weixight.CExchange.Persistence
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<lga> Lga { get; set; }
        public DbSet<Cartegory> Cartegories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<state> State { get; set; }

    }
}
