using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
