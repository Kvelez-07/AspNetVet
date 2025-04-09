using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Medical_History
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string Code { get; set; } = string.Empty;

        [Required]
        public DateTime Visit_Date { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(5,2)")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal? Height { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal? Temperature { get; set; }

        public int? Heart_Rate { get; set; }

        [Required, MaxLength(200)]
        public string Diagnosis { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string Treatment { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Notes { get; set; }

        [ForeignKey("Pets")]
        public int Pets_Id { get; set; }
        public Pets? Pets { get; set; }

        [ForeignKey("AppUsers")]
        public int AppUsers_Id { get; set; }
        public AppUsers? AppUsers { get; set; }

        [Required]
        public bool Status { get; set; } = true;
    }
}
