using GestionTurnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turnos.Infrastructure.Persistance.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            // Staff
            builder.HasOne(a => a.Staff)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.StaffId)
                .OnDelete(DeleteBehavior.Restrict);

            // Client
            builder.HasOne(a => a.Client)
                .WithMany(c => c.Appointments)
                .HasForeignKey(a => a.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            // Service
            builder.HasOne(a => a.BusinessService)
                .WithMany(bs => bs.Appointments)
                .HasForeignKey(a => a.BusinessServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Decimal precision
            builder.Property(a => a.TotalCost)
                .HasPrecision(10, 2);

            // String lengths
            builder.Property(a => a.ServiceName)
                .HasMaxLength(100);

            builder.Property(a => a.Observation)
                .HasMaxLength(500);
        }
    }
}
