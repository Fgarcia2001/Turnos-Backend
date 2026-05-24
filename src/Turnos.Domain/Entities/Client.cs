using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestionTurnos.Domain.Entities
{
    public class Client : BaseEntity
    {

        [MaxLength(100)]
        public required string FullName { get; set; } = string.Empty;

        [MaxLength(100)]
        [EmailAddress]
        public required string Email { get; set; } = string.Empty;

        [MaxLength(30)]
        [Phone]
        public required string Phone { get; set; } = string.Empty;

        [Required]
        public required DateTime BirthDay { get; set; }

        public Guid BusinessId { get; set; }
        public Business Business { get; set; } = null!;


        // Propiedades de navegación inversa


        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
       


    }
}
