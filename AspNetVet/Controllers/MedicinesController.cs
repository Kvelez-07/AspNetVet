using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class MedicinesController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddMedicine() => View();

        public IActionResult EditMedicine() => View();
        
        public IActionResult SearchSupplierMed() => View();

    }
}