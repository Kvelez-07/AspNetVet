using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class PetsController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddPet() => View();

        public IActionResult EditPet() => View();

        public IActionResult GetBreed() => View();

        public IActionResult GetOwner() => View();

        public IActionResult GetMedicalHistory() => View();

        public IActionResult AddToMedicalHistory() => View();

        public IActionResult AddMedicalHistory() => View();

        public IActionResult EditMedicalHistory() => View();

        public IActionResult GetMedicineTreatment() => View();

        public IActionResult AddMedicineTreatment() => View();

        public IActionResult EditMedicineTreatment() => View();
    }
}
