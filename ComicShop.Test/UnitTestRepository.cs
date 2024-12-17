using ComicShop.Domain.Entities;
using ComicShop.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ComicShop.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        DateTime data = new DateTime(2024, 12, 14, 14, 0, 0);
        public partial class MyDbContext : DbContext
        {

            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Fornecedor> Fornecedores { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Pedido>  Pedidos { get; set; }
            public DbSet<ItensPedido> ItensPedidos { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            // override: sobrescrever a configuração para adequá-la ao banco
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "ComicShop";
                var username = "root";
                var password = "1234";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertFornecedores()
        {
            using (var context = new MyDbContext())
            {
                var fornecedor = new Fornecedor()
                {
                    Nome = "Distribuidora Nacional",
                    Contato = "contato@distribuidoranacional.com.br",
                    Endereco = "Rua das Flores, 123"
                };
                context.Fornecedores.Add(fornecedor);

                fornecedor = new Fornecedor()
                {
                    Nome = "Manga World",
                    Contato = "atendimento@mangaworld.com",
                    Endereco = "Av. Central, 456"
                };
                context.Fornecedores.Add(fornecedor);

                fornecedor = new Fornecedor()
                {
                    Nome = "Quadrinhos Importados Ltda.",
                    Contato = "vendas@quadrinhosimportados.com", 
                    Endereco = "Travessa Manga, 789"
                };
                context.Fornecedores.Add(fornecedor);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestInsertClientes()
        {
            using (var context = new MyDbContext())
            {
                var cliente = new Cliente()
                {
                    Nome = "Guilherme Laureano",
                    Email = "guitlaureano@gmail.com",
                    Telefone = "18991512734",
                    Endereco = "Rua Doralice Botteon Carpintere, 405, Monte Libano",
                    DataCadastro = data,
                    Documento = "536.710.928-40"
                };
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestInsertCategorias()
        {
            using (var context = new MyDbContext())
            {
                var categoria = new Categoria()
                {
                    Nome = "HQ de Super-Herói",
                    Descricao = "Histórias em quadrinhos de super-heróis"
                };
                context.Categorias.Add(categoria);

                categoria = new Categoria()
                {
                    Nome = "Mangá",
                    Descricao = "Quadrinhos japoneses"
                };
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestInsertUsuario()
        {
            using (var context = new MyDbContext())
            {
                var usuario = new Usuario()
                {
                    Nome = "Guilherme",
                    Senha = "Guizim@24",
                    Login = "guitlaureano",
                    Email = "guitlaureano@gmail.com",
                    DataCadastro = data,
                    DataLogin = data,
                    Ativo = true
                };
                context.Usuarios.Add(usuario);

                usuario = new Usuario()
                {
                    Nome = "Analice",
                    Senha = "analice321",
                    Login = "Anarodan",
                    Email = "analicerodrigues@gmail.com",
                    DataCadastro = data,
                    DataLogin = data,
                    Ativo = true
                };
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestInsertProdutos()
        {
            using (var context = new MyDbContext())
            {
                var categoria = context.Categorias.FirstOrDefault(context => context.Id == 1);
                var fornecedor = context.Fornecedores.FirstOrDefault(context => context.Id == 1);
                var produto = new Produto()
                {
                    Nome = "Batman: Ano Um - Edição Absoluta",
                    Descricao = "Graphic Novel de Luxo do Batman",
                    Edicao = 1,
                    Preco = 300.00f,
                    Autor = "Frank Miller",
                    Editora = "Panini Comics",
                    AnoPublicacao = 2023,
                    QuantidadeEstoque = 100,
                    Categoria = categoria,
                    Fornecedor = fornecedor
                };
                context.Produtos.Add(produto);

                categoria = context.Categorias.FirstOrDefault(context => context.Id == 2);
                fornecedor = context.Fornecedores.FirstOrDefault(context => context.Id == 2);
                produto = new Produto()
                {
                    Nome = "One Piece",
                    Descricao = "Edição de One Piece que compila três volumes em um",
                    Edicao = 1,
                    Preco = 50.00f,
                    Autor = "Eiichiro Oda",
                    Editora = "Panini Comics",
                    AnoPublicacao = 2022,
                    QuantidadeEstoque = 200,
                    Categoria = categoria,
                    Fornecedor = fornecedor
                };
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestInsertPedidos()
        {
            using (var context = new MyDbContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(context => context.Id == 1);
                var cliente = context.Clientes.FirstOrDefault(context => context.Id == 1);
                var produto1 = context.Produtos.FirstOrDefault(context => context.Id == 1);
                var produto2 = context.Produtos.FirstOrDefault(context => context.Id == 2);

                Pedido pedido = new Pedido()
                {
                    DataPedido = data,
                    ValorTotal = (float)(5 * produto1.Preco),
                    Cliente = cliente,
                    Usuario = usuario
                };
                var lista = new List<ItensPedido>()
             {
                 new ItensPedido
                 {
                     Produto = produto1,
                     Quantidade = 5,
                     PrecoUnitario = (float)produto1.Preco,
                     Pedido = pedido
                 },
                 new ItensPedido
                 {
                     Produto = produto2,
                     Quantidade = 1,
                     PrecoUnitario = (float)produto2.Preco,
                     Pedido = pedido
                 }
             };

                float valorTotal = 0.00f;
                foreach (ItensPedido v in lista)
                {
                    valorTotal += (float)(v.Quantidade * v.PrecoUnitario);
                }
                pedido.Itens = lista;
                pedido.ValorTotal = valorTotal;
                context.Add(pedido);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListFornecedores()
        {
            using (var context = new MyDbContext())
            {
                foreach (var fornecedor in context.Fornecedores)
                {
                    Console.WriteLine(JsonSerializer.Serialize(fornecedor));
                }
            }
        }

        [TestMethod]
        public void TestListClientes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cliente in context.Clientes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }

        [TestMethod]
        public void TestListCategorias()
        {
            using (var context = new MyDbContext())
            {
                foreach (var categoria in context.Categorias)
                {
                    Console.WriteLine(JsonSerializer.Serialize(categoria));
                }
            }
        }

        [TestMethod]
        public void TestListProdutos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var produto in context.Produtos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(produto));
                }
            }
        }

        [TestMethod]
        public void TestListUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }

        [TestMethod]
        public void TestListItensPedidos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var itenspedidos in context.ItensPedidos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(itenspedidos));
                }
            }
        }

        [TestMethod]
        public void TestListPedidos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var pedido in context.Pedidos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(pedido));
                }
            }
        }
    }
}
