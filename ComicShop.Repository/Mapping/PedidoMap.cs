using ComicShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Repository.Mapping
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataPedido).IsRequired();
            builder.Property(x => x.ValorTotal).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasColumnType("varchar(50)");
            builder.HasOne(x => x.Cliente);
            builder.HasOne(x => x.Usuario);
            builder.HasMany(x => x.Itens).WithOne(x => x.Pedido).OnDelete(DeleteBehavior.Cascade);
        }
    }
    public class VendaItem : IEntityTypeConfiguration<ItensPedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ItensPedido> builder)
        {
            builder.ToTable("ItensPedido");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.PrecoUnitario).IsRequired();
            builder.HasOne(x => x.Produto).WithMany().HasConstraintName("FK_Produto");
            builder.HasOne(x => x.Pedido).WithMany(x => x.Itens).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
