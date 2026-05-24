using GestionTurnos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Turnos.Application.Abstractions.Infrastructure.Auth;

namespace Turnos.Infrastructure.Persistance.Repository
{
    public class BusinessServiceRepository : BaseRepository<BusinessService>, IBusinessServiceRepository
    {
        public BusinessServiceRepository(FMCTurnosDbContext context) : base(context)
        {

        }
    }
}
