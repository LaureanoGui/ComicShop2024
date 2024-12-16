using ComicShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Repository.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Telefone).IsRequired().HasColumnType("varchar(15)");
            builder.Property(x => x.Endereco).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.DataCadastro).IsRequired();
            builder.Property(x => x.Documento).IsRequired().HasColumnType("varchar(45)");
        }
    }
}
