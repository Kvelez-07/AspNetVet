using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Ubicacion { get; set; }
        public string Correo { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Provincia { get; set; }
    }
}
