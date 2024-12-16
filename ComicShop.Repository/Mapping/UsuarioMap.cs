using ComicShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Senha).IsRequired().HasColumnType("varchar(45)");
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Login).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.DataCadastro).IsRequired();
            builder.Property(x => x.DataLogin).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
