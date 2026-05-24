using GestionTurnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turnos.Infrastructure.Persistance.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(
            EntityTypeBuilder<Client> builder)
        {
            builder.HasOne(c => c.Business)
                .WithMany(b => b.Clients)
                .HasForeignKey(c => c.BusinessId);
        }
    }
}
