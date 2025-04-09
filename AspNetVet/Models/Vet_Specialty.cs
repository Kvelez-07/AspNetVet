using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Vet_Specialty
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Vet { get; set; }

        [ForeignKey("Specialty")]
        public int ID_Specialty { get; set; }
        public Specialty? Specialty { get; set; }
    }
}
