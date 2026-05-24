using GestionTurnos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Turnos.Application.Abstractions.Infrastructure.Auth;

namespace Turnos.Infrastructure.Persistance.Repository
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(FMCTurnosDbContext context) : base(context) 
        { 
        
        }
    }
}
