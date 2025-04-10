using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SetAppointment()
        {
            return View();
        }

        public IActionResult GetPet()
        {
            return View();
        }

        public IActionResult GetVet()
        {
            return View();
        }

        public IActionResult AppointmentTypes()
        {
            return View();
        }

        public IActionResult AddAppointmentType()
        {
            return View();
        }

        public IActionResult EditAppointmentType()
        {
            return View();
        }
    }
}
