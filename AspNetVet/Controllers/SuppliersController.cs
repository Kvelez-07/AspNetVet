using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class SuppliersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
