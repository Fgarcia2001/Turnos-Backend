using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionTurnos.Domain.Entities
{
    public enum AppointmentStatus
    {
        Pending, // Apenas se crea el turno
        Confirmed,
        Completed, // El cliente paso, tomo el servicio, pago y se fue
        Cancelled, // El cliente cancelo el turno 
        NoShow // El cliente no se presento
    }

    public enum PaymentMethod
    {
        Cash,
        MercadoPago,
        Transfer
    }

    public class Appointment : BaseEntity
    {
        
        public required Guid StaffId { get; set; } 
        public required Staff Staff { get; set; } = null!;

        public required Guid ClientId { get; set; }  
        public required Client Client { get; set; } = null!;
  
        public required Guid BusinessServiceId { get; set; } 
        public required BusinessService BusinessService { get; set; } = null!;


    
        
        public required DateTime StartDateTime { get; set; }
        public required DateTime EndDateTime { get; set; }
        


        [MaxLength(500)]
        public string? Observation { get; set; }
        public PaymentMethod? Payment { get; set; }
        public required AppointmentStatus Status { get; set; }

        public required string ServiceName { get; set; }
        public required decimal TotalCost { get; set; }
        public required int DurationMinutes { get; set; }




    }
}