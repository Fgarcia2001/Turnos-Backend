using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using BCrypt.Net;

namespace GestionTurnos.Domain.Entities
{

    public enum Rol { 
        
        Admin, // Se encarga de la administración del sistema.
        Recepcionista, // Se encarga del cobro, y la gestion de todos los turnos de cualquier profesional(Puede agregar turnos ).
        Profesional // Se encarga de gestionar sus propios turnos, y de atender a los clientes.
    }
    public class Staff : BaseEntity
    {

        [MaxLength(50)]
        public required string Name { get; set; } = string.Empty;


        [MaxLength(50)]
        [EmailAddress]
        public required string Email { get; set; } = string.Empty;
        [MaxLength(50)]
        [Phone]
        public required string Phone { get; set; } = string.Empty;

        private string _password = string.Empty;

        public string Password
        {
            get => _password; set => _password = BCrypt.Net.BCrypt.HashPassword(value);
        }
        [MaxLength(200)]
        public string LinkPhoto { get; set; } = string.Empty;

        public Rol Rol { get; set; }

        // Propiedad de navegación inversa: Un profesional tiene muchos turnos
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
