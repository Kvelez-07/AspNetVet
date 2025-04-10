using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProducts()
        {
            return View();
        }

        public IActionResult ModProducts()
        {
            return View();
        }
    }
}
