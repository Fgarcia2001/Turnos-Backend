using GestionTurnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turnos.Infrastructure.Persistance.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(
            EntityTypeBuilder<Staff> builder)
        {
            builder.HasOne(s => s.Business)
                .WithMany(b => b.StaffMembers)
                .HasForeignKey(s => s.BusinessId);

            builder.HasMany(s => s.Schedules)
                .WithOne(sc => sc.Staff)
                .HasForeignKey(sc => sc.StaffId);
        }
    }
}
