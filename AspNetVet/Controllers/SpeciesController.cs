using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class SpeciesController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddSpecie() => View();

        public IActionResult EditSpecie() => View();

        public IActionResult GetSpecie() => View();
    }
}