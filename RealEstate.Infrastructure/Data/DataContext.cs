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
        public DbSet<Property> Properties { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=realestatedb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

    }
}
