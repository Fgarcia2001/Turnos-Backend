using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestionTurnos.Domain.Entities
{
    public class Schedule : BaseEntity
    {
            public required DayOfWeek DayOfWeek { get; set; } // Enum de C# (0 = Domingo, 1 = Lunes...)
            public required TimeSpan StartTime { get; set; } 
            public required TimeSpan EndTime { get; set; }   
            public required int SlotDurationMinutes { get; set; } 
                                                         
    }
}
