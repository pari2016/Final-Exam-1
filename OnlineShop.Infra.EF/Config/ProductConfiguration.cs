using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infra.EF.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p=> p.ProductID);
            builder.Property(p=>p.Name).HasMaxLength(60).IsRequired();
            builder.Property(p=>p.Description).HasMaxLength(250).IsRequired();
        }
    }
}
