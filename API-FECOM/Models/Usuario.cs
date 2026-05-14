using System.ComponentModel.DataAnnotations;

namespace API_FECOM.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public required string Username { get; set; }

        public required string Password { get; set; }

        public required string Rol { get; set; }
    }
}