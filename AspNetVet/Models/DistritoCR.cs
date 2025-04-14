using Microsoft.AspNetCore.Mvc;

namespace AspNetVet.Models
{
    public class DistritoCR
    {
        public string Id { get; set; }
        public string CantonId { get; set; }
        public string Nombre { get; set; }
    }
}
