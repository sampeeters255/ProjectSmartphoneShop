using ProjectSmartphoneShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectSmartphoneShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSmartphoneShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       

        public DbSet<Smartphone> Smartphones { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<WinkelMand> WinkelManden { get; set; }
        public DbSet<WinkelMandSmartphone> WinkelMandSmartphones { get; set; }
        public DbSet<Order> Orders { get; set; }
       



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Smartphone>().ToTable("Smartphone").Property(p => p.Prijs).HasColumnType("decimal(18,2)");        //    
        //}
    }
}
