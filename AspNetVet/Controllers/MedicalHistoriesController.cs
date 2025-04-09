using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class MedicalHistoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
