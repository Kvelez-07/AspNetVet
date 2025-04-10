using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult PrincipalProducts()
        {
            return View();
        }
    }
}
