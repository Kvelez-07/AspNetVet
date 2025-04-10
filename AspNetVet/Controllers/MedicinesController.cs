using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class MedicinesController : Controller
    {
        public IActionResult PrincipalMedicines()
        {
            return View();
        }
    }
}
