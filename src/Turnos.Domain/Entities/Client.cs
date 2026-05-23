using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestionTurnos.Domain.Entities
{
    public class Client :BaseEntity
    {

        [MaxLength(50)]
        public required string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        [EmailAddress]
        public required string Email { get; set; } = string.Empty;
        [Phone]
        public required string Phone { get; set; } = string.Empty;
        [Required]

        public required DateTime BirthDay { get; set; }

        // Propiedades de navegación inversa
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
       


    }
}
