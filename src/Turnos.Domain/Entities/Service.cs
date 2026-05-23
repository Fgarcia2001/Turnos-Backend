using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionTurnos.Domain.Entities
{
    public class Service : BaseEntity
    {


        [MaxLength(50)]
        public required string Name { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public int Duration { get; set; }

        public decimal Price { get; set; }

        // Propiedad de navegación inversa
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
