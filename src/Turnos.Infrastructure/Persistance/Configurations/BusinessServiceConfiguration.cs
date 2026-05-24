using GestionTurnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turnos.Infrastructure.Persistance.Configurations
{
    public class BusinessServiceConfiguration : IEntityTypeConfiguration<BusinessService>
    {
        public void Configure(
            EntityTypeBuilder<BusinessService> builder)
        {
            builder.Property(bs => bs.Price)
                .HasPrecision(10, 2);

            builder.HasOne(bs => bs.Business)
                .WithMany(b => b.Services)
                .HasForeignKey(bs => bs.BusinessId);
        }
    }
}
