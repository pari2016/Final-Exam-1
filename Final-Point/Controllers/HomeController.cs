using Final_Point.Models;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Contracts;
using OnlineShop.Core.Domain;
using System.Diagnostics;

namespace Final_Point.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController( IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = productService.GetFeaturedProduct();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}