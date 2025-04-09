using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class AppUsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
