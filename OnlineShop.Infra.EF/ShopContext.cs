using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Domain;
using Shop.Infra.EF.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlieShop.Infra.EF
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Media> Media { get; set; }

    }
}
