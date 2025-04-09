using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class VetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
