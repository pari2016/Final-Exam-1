using Microsoft.AspNetCore.Mvc;
using OnlieShop.Contracts;

namespace Final_Point.Component
{
    public class ChippestProductsViewComponent : ViewComponent
    {
        private readonly IProductRepository productRepository;

        public ChippestProductsViewComponent(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = productRepository.GetChippestProduct().Take(6).ToList();
            return View(data);
        }
    }
}
