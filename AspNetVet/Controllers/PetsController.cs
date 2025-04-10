using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class PetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPet()
        {
            return View();
        }

        public IActionResult EditPet()
        {
            return View();
        }

        public IActionResult GetBreed()
        {
            return View();
        }

        public IActionResult GetOwner()
        {
            return View();
        }

        public IActionResult GetMedicalHistory()
        {
            return View();
        }

        public IActionResult AddToMedicalHistory()
        {
            return View();
        }

        public IActionResult EditMedicalHistory()
        {
            return View();
        }

        public IActionResult GetMedicineTreatment()
        {
            return View();
        }

        public IActionResult AddMedicineTreatment()
        {
            return View();
        }

        public IActionResult EditMedicineTreatment()
        {
            return View();
        }
    }
}
