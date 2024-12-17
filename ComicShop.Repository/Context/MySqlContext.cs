using Microsoft.EntityFrameworkCore;
using ComicShop.Repository.Mapping;
using ComicShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation.TestHelper;

namespace ComicShop.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) :
            base(options)
        {
            Database.EnsureCreated(); // Cria o banco caso não exista
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItensPedido> ItensPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Fornecedor>(new FornecedorMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Categoria>(new CategoriaMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Pedido>(new PedidoMap().Configure);
            modelBuilder.Entity <ItensPedido>(new ItensPedidoMap().Configure);
        }
    }
}
