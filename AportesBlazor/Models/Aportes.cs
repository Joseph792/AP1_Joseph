using System.ComponentModel.DataAnnotations;

namespace AportesBlazor.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        
        [Required(ErrorMessage = "La Persona es obligatoria")]
        public String? Persona { get; set; }
        
        [Required(ErrorMessage = "El Monto es obligatorio")]
        public int Monto { get; set; }
        
    }
}
