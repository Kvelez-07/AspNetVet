using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetVet.Models; 
using System.Collections.Generic;
using System.Linq; 

namespace AspNetVet.Controllers
{
    public class ProveedoresController : Controller
    {
        // Simulación de la base de datos (ahora a nivel de clase)
        private static List<Proveedor> proveedores = new List<Proveedor>
        {
            new Proveedor { Id = 1, Codigo = "PROV001", Nombre = "Proveedor Ejemplo A", Contacto = "Juan Pérez", Telefono = "1234-5678", Ubicacion = "San José, Costa Rica", Provincia = "1", Canton = "101", Distrito = "10101" },
            new Proveedor { Id = 2, Codigo = "PROV002", Nombre = "Suministros Veterinarios S.A.", Contacto = "María Rodríguez", Telefono = "8765-4321", Ubicacion = "Heredia, Costa Rica", Provincia = "4", Canton = "401", Distrito = "40101" },
            new Proveedor { Id = 3, Codigo = "PROV003", Nombre = "Farmacia Veterinaria Central", Contacto = "Carlos López", Telefono = "2222-9999", Ubicacion = "Alajuela, Costa Rica", Provincia = "2", Canton = "201", Distrito = "20101" },
            new Proveedor { Id = 4, Codigo = "PROV004", Nombre = "Distribuidora Agropecuaria del Este", Contacto = "Ana Vargas", Telefono = "9876-5432", Ubicacion = "Cartago, Costa Rica", Provincia = "3", Canton = "301", Distrito = "30101" },
            new Proveedor { Id = 5, Codigo = "PROV005", Nombre = "Insumos Veterinarios Unidos", Contacto = "Pedro Gómez", Telefono = "1122-3344", Ubicacion = "Limón, Costa Rica", Provincia = "7", Canton = "701", Distrito = "70101" },
            new Proveedor { Id = 6, Codigo = "PROV006", Nombre = "Salud Animal Occidente", Contacto = "Sofía Mora", Telefono = "5566-7788", Ubicacion = "Puntarenas, Costa Rica", Provincia = "6", Canton = "601", Distrito = "60101" },
            new Proveedor { Id = 7, Codigo = "PROV007", Nombre = "Biológicos y Vacunas C.R.", Contacto = "Ricardo Castro", Telefono = "4455-6677", Ubicacion = "Guanacaste, Costa Rica", Provincia = "5", Canton = "501", Distrito = "50101" },
            new Proveedor { Id = 8, Codigo = "PROV008", Nombre = "Equipos Veterinarios Modernos", Contacto = "Laura Jiménez", Telefono = "7788-9900", Ubicacion = "San Carlos, Costa Rica", Provincia = "2", Canton = "202", Distrito = "20201" },
            new Proveedor { Id = 9, Codigo = "PROV009", Nombre = "Alimentos Balanceados Premium", Contacto = "Daniel Núñez", Telefono = "3344-5566", Ubicacion = "Desamparados, Costa Rica", Provincia = "1", Canton = "101", Distrito = "10101" },
            new Proveedor { Id = 10, Codigo = "PROV010", Nombre = "Servicios Veterinarios Integrales", Contacto = "Elena Ruiz", Telefono = "6677-8899", Ubicacion = "Curridabat, Costa Rica", Provincia = "1", Canton = "101", Distrito = "10101" },
            new Proveedor { Id = 11, Codigo = "PROV011", Nombre = "Productos Farmacéuticos Veterinarios", Contacto = "Andrés Soto", Telefono = "2345-6789", Ubicacion = "Tibás, Costa Rica", Provincia = "1", Canton = "101", Distrito = "10101" },
            new Proveedor { Id = 12, Codigo = "PROV012", Nombre = "Diagnóstico Veterinario Avanzado", Contacto = "Valeria Vargas", Telefono = "9012-3456", Ubicacion = "Escazú, Costa Rica", Provincia = "1", Canton = "102", Distrito = "10201" },
            new Proveedor { Id = 13, Codigo = "PROV013", Nombre = "Accesorios y Suplementos Veterinarios", Contacto = "Javier Mora", Telefono = "5678-9012", Ubicacion = "Santa Ana, Costa Rica", Provincia = "1", Canton = "101", Distrito = "10101" }
        };

        public IActionResult Index()
        {
            return View(proveedores);
        }

        public IActionResult AddProveedor()
        {
            var provincias = GetProvinciasCR();
            var cantones = GetCantonesCR_Reduced();
            var distritos = GetDistritosCR_Reduced();

            ViewBag.Provincias = new SelectList(provincias, "Id", "Nombre");
            ViewBag.Cantones = new SelectList(cantones, "Id", "Nombre");
            ViewBag.Distritos = new SelectList(distritos, "Id", "Nombre");

            return View();
        }

        // Métodos para obtener las listas de Costa Rica (reducidas)
        private List<ProvinciaCR> GetProvinciasCR()
        {
            return new List<ProvinciaCR>
            {
                new ProvinciaCR { Id = "1", Nombre = "San José" },
                new ProvinciaCR { Id = "2", Nombre = "Alajuela" },
                new ProvinciaCR { Id = "3", Nombre = "Cartago" },
                new ProvinciaCR { Id = "4", Nombre = "Heredia" },
                new ProvinciaCR { Id = "5", Nombre = "Guanacaste" },
                new ProvinciaCR { Id = "6", Nombre = "Puntarenas" },
                new ProvinciaCR { Id = "7", Nombre = "Limón" }
            };
        }

        private List<CantonCR> GetCantonesCR_Reduced()
        {
            return new List<CantonCR>
            {
                new CantonCR { Id = "101", ProvinciaId = "1", Nombre = "San José" },
                new CantonCR { Id = "201", ProvinciaId = "2", Nombre = "Alajuela" },
                new CantonCR { Id = "301", ProvinciaId = "3", Nombre = "Cartago" },
                new CantonCR { Id = "401", ProvinciaId = "4", Nombre = "Heredia" },
                new CantonCR { Id = "501", ProvinciaId = "5", Nombre = "Liberia" },
                new CantonCR { Id = "601", ProvinciaId = "6", Nombre = "Puntarenas" },
                new CantonCR { Id = "701", ProvinciaId = "7", Nombre = "Limón" },
                new CantonCR { Id = "102", ProvinciaId = "1", Nombre = "Escazú" },
                new CantonCR { Id = "202", ProvinciaId = "2", Nombre = "San Ramón" },
                new CantonCR { Id = "302", ProvinciaId = "3", Nombre = "Paraíso" }
            };
        }

        private List<DistritoCR> GetDistritosCR_Reduced()
        {
            return new List<DistritoCR>
            {
                new DistritoCR { Id = "10101", CantonId = "101", Nombre = "Carmen" },
                new DistritoCR { Id = "20101", CantonId = "201", Nombre = "Alajuela" },
                new DistritoCR { Id = "30101", CantonId = "301", Nombre = "Oriental" },
                new DistritoCR { Id = "40101", CantonId = "401", Nombre = "Heredia" },
                new DistritoCR { Id = "50101", CantonId = "501", Nombre = "Liberia" },
                new DistritoCR { Id = "60101", CantonId = "601", Nombre = "Puntarenas" },
                new DistritoCR { Id = "70101", CantonId = "701", Nombre = "Limón" },
                new DistritoCR { Id = "10201", CantonId = "102", Nombre = "Escazú" },
                new DistritoCR { Id = "20201", CantonId = "202", Nombre = "San Ramón" },
                new DistritoCR { Id = "30201", CantonId = "302", Nombre = "Santiago" }
            };
        }

        public IActionResult EditProveedor(int id)
        {
            // Buscar el proveedor en la lista mock usando el ID
            var proveedor = proveedores.FirstOrDefault(p => p.Id == id);

            if (proveedor == null)
            {
                return NotFound();
            }

            var provincias = GetProvinciasCR();
            var cantones = GetCantonesCR_Reduced();
            var distritos = GetDistritosCR_Reduced();

            // Crear SelectList especificando el valor seleccionado
            ViewBag.Provincias = new SelectList(provincias, "Id", "Nombre", proveedor.Provincia);
            ViewBag.Cantones = new SelectList(cantones, "Id", "Nombre", proveedor.Canton);
            ViewBag.Distritos = new SelectList(distritos, "Id", "Nombre", proveedor.Distrito);

            return View(proveedor);
        }

        // Acción para eliminar un proveedor (solo la acción, la lógica de eliminación iría aquí)
        [HttpPost]
        public IActionResult DeleteProveedor(int id)
        {
            // Aquí iría la lógica para eliminar el proveedor con el ID especificado
            // de la base de datos.
            // Como estamos con mock data, podríamos simplemente simular la eliminación.
            return RedirectToAction("Index"); // Redirigir de vuelta a la lista de proveedores
        }

        [HttpPost]
        public IActionResult UpdateProveedor(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                // Aquí iría la lógica para actualizar el proveedor en la base de datos
                // utilizando el proveedor.Id para identificar el registro a actualizar.
                // ...


                return RedirectToAction("Index"); //redirigimos de vuelta a la lista
            }
            else
            {
                // Si hay errores de validación, vuelve a la vista de edición con los errores
                return View("EditProveedor", proveedor);
            }
        }
    }
}