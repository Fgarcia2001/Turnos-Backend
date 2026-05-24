using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Turnos.Domain.Entities;

namespace Turnos.Infrastructure.Persistance.Configurations
{
    public class StaffServiceConfiguration : IEntityTypeConfiguration<StaffService>
    {
        public void Configure(EntityTypeBuilder<StaffService> builder)
        {
            // Primary Key compuesta
            builder.HasKey(ss => new
            {
                ss.StaffId,
                ss.BusinessServiceId
            });

            // Relación Staff
            builder.HasOne(ss => ss.Staff)
                .WithMany(s => s.StaffServices)
                .HasForeignKey(ss => ss.StaffId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Service
            builder.HasOne(ss => ss.BusinessService)
                .WithMany(bs => bs.StaffServices)
                .HasForeignKey(ss => ss.BusinessServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
