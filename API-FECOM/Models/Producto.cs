using System.ComponentModel.DataAnnotations;

namespace API_FECOM.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public required string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}