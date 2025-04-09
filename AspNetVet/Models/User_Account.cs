using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetVet.Models
{
    public class User_Account
    {
        [Key, ForeignKey("AppUsers")]
        public int Id_User { get; set; }
        public AppUsers? AppUsers { get; set; }

        [Required, MaxLength(30)]
        public string Username { get; set; } = string.Empty;

        [Required, MaxLength(255)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public bool Status { get; set; } = true;
    }
}
