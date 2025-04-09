using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Medicine_Treatments
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string Code { get; set; } = string.Empty;

        [Required]
        public DateTime Treatment_Date { get; set; } = DateTime.Now;

        [ForeignKey("Pets")]
        public int Pets_Id { get; set; }
        public Pets? Pets { get; set; }

        [ForeignKey("Medicines")]
        public int Medicines_Id { get; set; }
        public Medicines? Medicines { get; set; }

        [Required, MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        [ForeignKey("AppUsers")]
        public int AppUsers_Id { get; set; }
        public AppUsers? AppUsers { get; set; }

        [Required]
        public bool Status { get; set; } = true;
    }
}
