using GestionTurnos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;
using Turnos.Application.Abstractions.Infrastructure.Auth;

namespace Turnos.Infrastructure.Persistance.Repository
{
    public class BusinessRepository : BaseRepository<Business>, IBusinessRepository
    {
        public BusinessRepository(FMCTurnosDbContext context) : base(context)
        {

        }
    }
}
