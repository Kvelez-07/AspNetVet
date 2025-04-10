using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddAppointment() => View();

        public IActionResult EditAppointment() => View();

        public IActionResult GetPet() => View();

        public IActionResult GetVet() => View();

        public IActionResult AppointmentTypes() => View();

        public IActionResult AddAppointmentType() => View();

        public IActionResult EditAppointmentType() => View();
    }
}
