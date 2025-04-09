using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Suppliers
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string Code { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Supplier_Name { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Contact_Name { get; set; }

        [Required, MaxLength(15)]
        public string Phone { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(30)]
        public string? Province { get; set; }

        [MaxLength(30)]
        public string? Canton { get; set; }

        [MaxLength(30)]
        public string? District { get; set; }

        [Required]
        public bool Status { get; set; } = true;
    }
}
