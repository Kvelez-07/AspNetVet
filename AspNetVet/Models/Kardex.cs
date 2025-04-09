using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Kardex
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Inventory_Item_Types")]
        public int Item_Type_Id { get; set; }
        public Inventory_Item_Types? Inventory_Item_Types { get; set; }

        public int Item_Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required, MaxLength(10)]
        public string Movement_Type { get; set; } = string.Empty;

        [Required]
        public DateTime Date_Of_Movement { get; set; } = DateTime.Now;

        [MaxLength(200)]
        public string? Description { get; set; }

        [Required]
        public int Previous_Stock { get; set; }

        [Required]
        public int Current_Stock { get; set; }
    }
}
