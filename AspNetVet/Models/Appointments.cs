using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class Appointments
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(60)]
        public string Code { get; set; } = string.Empty;

        [Required]
        public DateTime Appointment_Date { get; set; }

        [Required, MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        [ForeignKey("Pets")]
        public int Pets_Id { get; set; }
        public Pets? Pets { get; set; }

        [ForeignKey("AppUsers")]
        public int Customer_Id { get; set; }
        public AppUsers? Customer { get; set; }

        [ForeignKey("AppUsers")]
        public int Vet_Id { get; set; }
        public AppUsers? Vet { get; set; }

        [ForeignKey("Appointment_Types")]
        public int Appointment_Types_Id { get; set; }
        public Appointment_Types? Appointment_Types { get; set; }

        [ForeignKey("Statuses")]
        public int Statuses_Id { get; set; }
        public Statuses? Statuses { get; set; }
    }
}
