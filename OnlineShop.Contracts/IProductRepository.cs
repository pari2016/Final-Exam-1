using OnlineShop.Core.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlieShop.Contracts
{
    public interface IProductRepository
    {
        Product Get(int ProductId);
        List<Product> GetChippestProduct();
        List<Product> GetFeaturedProduct();

    }
}
