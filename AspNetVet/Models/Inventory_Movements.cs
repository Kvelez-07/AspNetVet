using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Inventory_Movements
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string Code { get; set; } = string.Empty;

        [Required]
        public DateTime Date_Of_Movement { get; set; } = DateTime.Now;

        [ForeignKey("Inventory_Item_Types")]
        public int Item_Type_Id { get; set; }
        public Inventory_Item_Types? Inventory_Item_Types { get; set; }

        public int Item_Id { get; set; }

        [Required, MaxLength(10)]
        public string Movement_Type { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("Suppliers")]
        public int Suppliers_Id { get; set; }
        public Suppliers? Suppliers { get; set; }

        [ForeignKey("AppUsers")]
        public int AppUsers_Id { get; set; }
        public AppUsers? AppUsers { get; set; }
    }
}
