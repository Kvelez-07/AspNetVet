using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class MedicinesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddMedicines()
        {
            return View();
        }

        public IActionResult ModMedicines()
        {
            return View();
        }
    }
}
