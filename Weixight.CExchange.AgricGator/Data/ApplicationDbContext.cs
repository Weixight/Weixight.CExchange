using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Weixight.CExchange.AgricGator.Models;

namespace Weixight.CExchange.AgricGator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cartegory> cartegories { get; set; }
        public DbSet<NewsItems> NewsItems { get; set; }
    }
}
