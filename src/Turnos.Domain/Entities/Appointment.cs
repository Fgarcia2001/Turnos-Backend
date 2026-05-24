using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionTurnos.Domain.Entities
{
    public enum AppointmentStatus
    {
        Pending, // Apenas se crea el turno
        Confirmed, // El cliente paso, tomo el servicio, pago y se fue
        Cancelled // El cliente cancelo el turno o no se presento
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


  
        public required Guid ServiceId { get; set; } 
        public required Service Service { get; set; } = null!;


    
        public required DateTime Day { get; set; }
        public required TimeSpan StartTime { get; set; }
        public required TimeSpan EndTime { get; set; }

        [MaxLength(500)]
        public string? Observation { get; set; }


        
        public required PaymentMethod Payment { get; set; }



        public required AppointmentStatus Status { get; set; }


     
        public required decimal TotalCost { get; set; }
    }
}