using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class PetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
