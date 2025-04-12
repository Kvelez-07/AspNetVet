using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class SpeciesController : Controller
    {
        public IActionResult Index() => View();
    }
}
