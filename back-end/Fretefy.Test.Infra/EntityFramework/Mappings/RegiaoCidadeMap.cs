using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoCidadeMap : IEntityTypeConfiguration<RegiaoCidade>
    {
        public void Configure(EntityTypeBuilder<RegiaoCidade> builder)
        {
            builder.HasKey(rc => new { rc.RegiaoId, rc.CidadeId });

            builder.HasOne(rc => rc.Regiao)
                   .WithMany(r => r.Cidades)
                   .HasForeignKey(rc => rc.RegiaoId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rc => rc.Cidade)
                   .WithMany()
                   .HasForeignKey(rc => rc.CidadeId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
