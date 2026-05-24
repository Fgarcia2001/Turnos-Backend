using GestionTurnos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turnos.Domain.Entities
{
    public enum UserRole
    {
        Sysadmin = 1,
        BusinessAdmin = 2,
        Staff = 3,
        Client = 4
    }

    public class User : BaseEntity
    {
        public  required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public Guid? BusinessId { get; set; }
        public Business? Business { get; set; }

    }
}
