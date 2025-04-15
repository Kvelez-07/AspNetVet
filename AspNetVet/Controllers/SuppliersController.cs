using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class SuppliersController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddSupplier() => View();

        public IActionResult EditSupplier() => View();
    }
}
