using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddProduct() => View();

        public IActionResult EditProduct() => View();
        
        public IActionResult GetProductSupplier() => View();
        
        public IActionResult AddKardexEntry() => View();
        
        public IActionResult AddKardexOutflow() => View();
        
        public IActionResult GetGeneralKardex() => View();
        
        public IActionResult GetProductTypes() => View();
        
        public IActionResult AddProductTypes() => View();

        public IActionResult EditProductTypes() => View();
    }
}