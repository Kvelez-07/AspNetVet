using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Breeds
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey("Species")]
        public int Species_Id { get; set; }
        public Species? Species { get; set; }

        [Required]
        public bool Status { get; set; } = true;
    }
}
