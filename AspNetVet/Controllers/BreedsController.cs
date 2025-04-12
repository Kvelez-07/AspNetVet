using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class BreedsController : Controller
    {
        public IActionResult Index() => View();
    }
}
