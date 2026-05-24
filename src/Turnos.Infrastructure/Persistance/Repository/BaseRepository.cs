using GestionTurnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Turnos.Application.Abstractions.Infrastructure.Auth;

namespace Turnos.Infrastructure.Persistance.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly FMCTurnosDbContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository(FMCTurnosDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        protected void SaveChanges()
        {
            _context.SaveChanges();
        }



        public virtual T Add(T entity)
        {
            _dbSet.Add(entity);
            SaveChanges();
            return entity;
        }




        public virtual List<T> GetAll()
        {
            return _dbSet.Where(x => !x.IsDeleted).ToList();
        }

        public virtual T? GetById(Guid id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }


        public virtual void Update(T entity)
        {
            _dbSet.Update(entity);
            SaveChanges();
        }

        public virtual void Delete(Guid Id)
        {
            var EntityToDelete = _dbSet.FirstOrDefault(x => x.Id == Id);
            if (EntityToDelete != null)
            {
                EntityToDelete.IsDeleted = true;
                EntityToDelete.DeletedDateTime = DateTime.UtcNow;
                EntityToDelete.UpdatedDateTime = DateTime.UtcNow;
                _dbSet.Update(EntityToDelete);
                SaveChanges();
            }
        }
    }
}
