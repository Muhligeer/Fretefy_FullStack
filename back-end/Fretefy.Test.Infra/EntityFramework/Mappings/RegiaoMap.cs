using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(p => p.Ativo)
                .IsRequired();

            builder.HasMany(p => p.Cidades)
                .WithOne(p => p.Regiao)
                .HasForeignKey(p => p.RegiaoId);
        }
    }
}
