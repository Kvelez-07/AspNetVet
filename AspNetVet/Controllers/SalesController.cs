using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index() => View();
        
        public IActionResult GetProduct() => View();
        
        public IActionResult GetMedicine() => View();

    }
}
