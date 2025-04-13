using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Models
{
    public class CantonCR
    {
        public string Id { get; set; }
        public string ProvinciaId { get; set; }
        public string Nombre { get; set; }
    }
}
