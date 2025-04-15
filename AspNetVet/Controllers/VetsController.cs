using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class VetsController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddVet() => View();

        public IActionResult EditVet() => View();

        public IActionResult SelectSpecialty() => View();
    }
}
