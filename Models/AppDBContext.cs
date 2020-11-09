using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JubiLarian.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Producent> Producent { get; set; }
        public DbSet<ProductType> Type { get; set; }
    }
}
