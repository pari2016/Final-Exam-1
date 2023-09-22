using Microsoft.EntityFrameworkCore;
using OnlieShop.Contracts;
using OnlieShop.Infra.EF;
using OnlineShop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infra.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopContext context;

        public ProductRepository(ShopContext context)
        {
            this.context = context;
        }
        public Product Get(int ProductId)
        {
            return context.Product.Include(a => a.Medias)

                 .First(a => a.ProductID == ProductId);
        }

        public List<Product> GetChippestProduct()
        {
            List<Product> result = new List<Product>();
            foreach (var category in context.Category.ToList())
            {
                int minPrice = context.Product.Include(a => a.Category).Where(a => a.Category == category).Min(a => a.Price);
                result.Add(context.Product.Include(a => a.Medias).First(a => a.Price == minPrice));

            }
            return result; ;
        }

        public List<Product> GetFeaturedProduct()
        {
            return context.Product.Include(a => a.Medias)
              .OrderByDescending(a => a.InseretTime).ToList();
        }
    }
}
