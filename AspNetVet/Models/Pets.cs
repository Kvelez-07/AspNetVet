using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Pets
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string Code { get; set; } = string.Empty;

        [Required, MaxLength(40)]
        public string Name { get; set; } = string.Empty;

        public DateTime? Birth_Date { get; set; }

        [ForeignKey("Species")]
        public int Species_Id { get; set; }
        public Species? Species { get; set; }

        [ForeignKey("Breeds")]
        public int Breeds_Id { get; set; }
        public Breeds? Breeds { get; set; }

        [ForeignKey("AppUsers")]
        public int AppUsers_Id { get; set; }
        public AppUsers? AppUsers { get; set; }

        [Required]
        public bool Status { get; set; } = true;
    }
}
