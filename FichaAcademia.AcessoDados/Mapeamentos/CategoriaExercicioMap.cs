using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class CategoriaExercicioMap : IEntityTypeConfiguration<CategoriaExercicio>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CategoriaExercicio> builder)
        {
            builder.HasKey(c => c.CategoriaExercicioId);

            builder.Property(c => c.Nome).IsRequired();

            builder.HasMany(c => c.Exercicio).WithOne(c => c.CategoriaExercicio).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("CategoriasExercicios");
        }
    }
}
