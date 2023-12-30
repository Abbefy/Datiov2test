using Datiov2test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Datiov2test.Data;
using Datiov2test.Controllers;



namespace Datiov2test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductMethods productMethods = new ProductMethods();
        CategoryMethods categoryMethods = new CategoryMethods();


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var categories = categoryMethods.GetAllCategoriesWithProducts();

            //List<ProductModel> products = productMethods.GetAllProducts();

            return View(categories);
        }

        //public IActionResult Product(int id)
        //{
        //    var product = productMethods.GetProductById(id); 
        //    return View(product);
        //}




        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
