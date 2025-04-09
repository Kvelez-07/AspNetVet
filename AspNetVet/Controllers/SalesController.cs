using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
