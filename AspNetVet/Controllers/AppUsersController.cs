using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class AppUsersController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddAppUser() => View();

        public IActionResult EditAppUser() => View();
    }
}
