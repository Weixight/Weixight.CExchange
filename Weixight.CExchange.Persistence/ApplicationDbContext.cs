using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
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
        public DbSet<Cartegory> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)  
        //{  

        //    var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()  
        //    .Where(type => !String.IsNullOrEmpty(type.Namespace))  
        //    .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
        //    foreach (var type in typesToRegister)  
        //    {  
        //        dynamic configurationInstance = Activator.CreateInstance(type);  
        //        modelBuilder.ApplyConfigurationsFromAssembly.Add(configurationInstance);  
        //    }  
        // base.OnModelCreating(modelBuilder);  
        //}  
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<lga> Lga { get; set; }
        public DbSet<Cartegory> Cartegories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<state> State { get; set; }
        public DbSet<EmployeeTbl> EmployeeTbls { get; set; }
        public DbSet<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public DbSet<FileOnFileSystemModel> FilesOnFileSystem { get; set; }
        public DbSet<NavigationMenu> AspNetNavigationMenu { get; set; }

    }
}
