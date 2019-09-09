using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class ObjetivoMap : IEntityTypeConfiguration<Objetivo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Objetivo> builder)
        {
            builder.HasKey(o => o.ObjetivoId);

            builder.Property(o => o.Nome).HasMaxLength(50).IsRequired();
            builder.Property(o => o.Descricao).HasMaxLength(500).IsRequired();

            builder.HasMany(o => o.Alunos).WithOne(o => o.Objetivo);

            builder.ToTable("Objetivos");
        }
    }
}
