using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Medicines
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string Code { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int Stock { get; set; }

        [Required]
        public int Min { get; set; }

        [Required]
        public int Max { get; set; }

        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Required]
        public bool Status { get; set; } = true;

        [ForeignKey("Suppliers")]
        public int Suppliers_Id { get; set; }
        public Suppliers? Suppliers { get; set; }

        [ForeignKey("Medicine_Types")]
        public int Medicine_Types_Id { get; set; }
        public Medicine_Types? Medicine_Types { get; set; }
    }
}
