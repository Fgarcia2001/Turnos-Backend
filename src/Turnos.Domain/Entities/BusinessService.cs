using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Turnos.Domain.Entities;

namespace GestionTurnos.Domain.Entities
{
    public class BusinessService : BaseEntity
    {


        [MaxLength(50)]
        public required string Name { get; set; } = string.Empty;


        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;


        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public int DurationMinutes { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;

        public Guid BusinessId { get; set; }
        public Business Business { get; set; } = null!;

        


        // Propiedad de navegación inversa
        public  ICollection<StaffService> StaffServices { get; set; } = new List<StaffService>();
        public  ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
