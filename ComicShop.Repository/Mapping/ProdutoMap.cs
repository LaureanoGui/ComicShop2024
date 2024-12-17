using ComicShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Repository.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Descricao).IsRequired().HasColumnType("varchar(200)");
            builder.Property(x => x.Edicao);
            builder.Property(x => x.Preco);
            builder.Property(x => x.Autor).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Editora).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.AnoPublicacao);
            builder.Property(x => x.QuantidadeEstoque);
            builder.HasOne(x => x.Fornecedor)
                .WithMany()
                .HasForeignKey("IdFornecedor")
                .HasConstraintName("FK_Fornecedor");
            builder.HasOne(x => x.Categoria)
                .WithMany()
                .HasForeignKey("IdCategoria")
                .HasConstraintName("FK_Categoria");
        }
    }
}
