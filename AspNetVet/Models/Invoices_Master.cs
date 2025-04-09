using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Invoices_Master
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Invoice_Number { get; set; } = string.Empty;

        [Required]
        public DateTime Invoice_Date { get; set; } = DateTime.Now;

        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal Total_Amount { get; set; }

        [ForeignKey("AppUsers")]
        public int Customer_Id { get; set; }
        public AppUsers? Customer { get; set; }

        [ForeignKey("AppUsers")]
        public int Generated_By { get; set; }
        public AppUsers? GeneratedBy { get; set; }

        [ForeignKey("Payment_Methods")]
        public int Payment_Methods_Id { get; set; }
        public Payment_Methods? Payment_Methods { get; set; }

        [Required]
        public bool Status { get; set; } = true;
    }
}
