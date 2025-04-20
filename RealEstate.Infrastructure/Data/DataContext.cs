using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using RealEstate.Domain.Entity;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealEstate.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Property> Propertys { get; set; }
      
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=realestatedb;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
            });
        }

    }
}
