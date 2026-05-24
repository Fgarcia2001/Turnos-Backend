using GestionTurnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Turnos.Domain.Entities;

namespace Turnos.Infrastructure.Persistance
{
    public class FMCTurnosDbContext : DbContext
    {

        public FMCTurnosDbContext(DbContextOptions<FMCTurnosDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<BusinessService> BusinessServices { get; set; }
        public DbSet<Staff> StaffMembers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StaffService> StaffServices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FMCTurnosDbContext).Assembly);
        }


    }
}
