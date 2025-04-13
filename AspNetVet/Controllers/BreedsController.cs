using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class BreedsController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddBreed() => View();

        public IActionResult EditBreed() => View();

        public IActionResult RedirectToSpeciesIndex()
        {
            return RedirectToAction("Index", "Species");
        }
    }
}