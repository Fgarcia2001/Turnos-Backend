using System.ComponentModel.DataAnnotations;
using Turnos.Domain.Entities;

namespace GestionTurnos.Domain.Entities
{
    public enum StatusBusiness {Deshabilitado, Habilitado }

    public enum TypeBusiness { Barberia, Spa}


    public class Business : BaseEntity
    {
        public string? Name { get; set; } 
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Description { get; set; }

        public StatusBusiness Status { get; set; }
        public TypeBusiness Type { get; set; }


        public  ICollection<User> Users { get; set; } = new List<User>();
        public  ICollection<Client> Clients { get; set; } = new List<Client>();
        public  ICollection<BusinessService> Services { get; set; } = new List<BusinessService>();
        public  ICollection<Staff> StaffMembers { get; set; } = new List<Staff>();

    }
}
