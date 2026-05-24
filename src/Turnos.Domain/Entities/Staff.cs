using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using BCrypt.Net;
using Turnos.Domain.Entities;

namespace GestionTurnos.Domain.Entities
{

    public class Staff : BaseEntity
    {

        [MaxLength(100)]
        public required string FullName { get; set; }


        [MaxLength(100)]
        [EmailAddress]
        public required string Email { get; set; }

        [MaxLength(50)]
        [Phone]
        public required string PhoneNumber { get; set; } = string.Empty;

        [MaxLength(300)]
        public string? PhotoUrl { get; set; }

        public Guid BusinessId { get; set; }
        public Business Business { get; set; } = null!;

        public Guid? UserId { get; set; }
        public User? User { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<StaffService> StaffServices { get; set; } = new List<StaffService>();


    }
}
