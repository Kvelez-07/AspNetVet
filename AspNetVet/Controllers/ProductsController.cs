using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
