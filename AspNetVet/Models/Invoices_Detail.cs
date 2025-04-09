using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Invoices_Detail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Invoices_Master")]
        public int Invoices_Master_Id { get; set; }
        public Invoices_Master? Invoices_Master { get; set; }

        [ForeignKey("Item_Types")]
        public int Item_Type_Id { get; set; }
        public Item_Types? Item_Types { get; set; }

        public int Item_Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
    }
}
