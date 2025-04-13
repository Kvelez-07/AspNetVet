using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class MedicinesController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddMedicine() => View();

        public IActionResult EditMedicine() => View();
        
        public IActionResult GetMedicineSupplier() => View();
        
        public IActionResult AddKardexEntry() => View();
        
        public IActionResult AddKardexOutflow() => View();
        
        public IActionResult GetGeneralKardex() => View();
        
        public IActionResult GetMedicineTypes() => View();
        
        public IActionResult AddMedicineTypes() => View();

        public IActionResult EditMedicineTypes() => View();


    }
}