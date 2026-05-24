using GestionTurnos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turnos.Application.Abstractions.Infrastructure.Auth
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        List<T> GetAll();

        T? GetById(Guid id);
        T Add(T entity);
        void Update(T entity);
        void Delete(Guid Id);
    }
}
