using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciamentoDeBiblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoDeBiblioteca.Data.Types
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.Property(i => i.Nome).HasColumnName("nome");
            builder.Property(i => i.Nome).IsRequired();

            builder.HasMany<Livro>(i => i.Livros).WithOne(i => i.AlugadoPor);


        }
    }
}