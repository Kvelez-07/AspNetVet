﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult AddProduct() => View();

        public IActionResult EditProduct() => View();
    }
}