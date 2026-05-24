using GestionTurnos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turnos.Domain.Entities
{
    public class StaffService
    {
        public Guid StaffId { get; set; }
        public Staff Staff { get; set; } = null!;
        public Guid BusinessServiceId { get; set; }
        public BusinessService BusinessService { get; set; } = null!;

    }
}
