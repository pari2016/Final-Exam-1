using OnlieShop.Contracts;
using OnlineShop.Contracts;
using OnlineShop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.ApplicationService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Get(int ProductId)
        {
            return productRepository.Get(ProductId);
        }

        public List<Product> GetChippestProduct()
        {
            return productRepository.GetChippestProduct()
                .Take(4).ToList();
        }

        public List<Product> GetFeaturedProduct()
        {
            return productRepository.GetFeaturedProduct();
        }
    }
}
