using GestionTurnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }

    }
}
