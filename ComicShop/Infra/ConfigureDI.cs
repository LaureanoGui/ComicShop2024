using AutoMapper;
using ComicShop.App.Cadastros;
using ComicShop.App.Outros;
using ComicShop.Domain.Base;
using ComicShop.Domain.Entities;
using ComicShop.App.Models;
using ComicShop.Repository.BaseRepository;
using ComicShop.Repository.Context;
using ComicShop.Repository.Mapping;
using ComicShop.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.App.Infra
{
    public static class ConfigureDI
    {
        // Classe static: Classe que não ser instanciada
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco de Dados
            // Configuração do Banco na Injeção de Dependência
            var strCon = File.ReadAllText("D:\\ComicShop\\ComicShop\\Config\\ConfigBanco.txt");

            // Lista de Serviços
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            }
            );
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Fornecedor>, BaseRepository<Fornecedor>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Categoria>, BaseRepository<Categoria>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Pedido>, BaseRepository<Pedido>>();
            Services.AddScoped<IBaseRepository<ItensPedido>, BaseRepository<ItensPedido>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Fornecedor>, BaseService<Fornecedor>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Categoria>, BaseService<Categoria>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Pedido>, BaseService<Pedido>>();
            Services.AddScoped<IBaseService<ItensPedido>, BaseService<ItensPedido>>();

            #endregion

            #region Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroFornecedor, CadastroFornecedor>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroProduto, CadastroProduto>();
            Services.AddTransient<CadastroCategoria, CadastroCategoria>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroPedido, CadastroPedido>();

            #endregion

            #region Mapping

            Services.AddSingleton(new MapperConfiguration(config =>
            {
            config.CreateMap<Usuario, UsuarioModel>();
            config.CreateMap<Fornecedor, FornecedorModel>();
            config.CreateMap<Cliente, ClienteModel>();
            config.CreateMap<Categoria, CategoriaModel>();
            config.CreateMap<Produto, ProdutoModel>()
                 .ForMember(d => d.NomeCategoria, d => d.MapFrom(x => x.Categoria!.Nome))
                 .ForMember(d => d.IdCategoria, d => d.MapFrom(x => x.Categoria!.Id))
                 .ForMember(d => d.NomeFornecedor, d => d.MapFrom(x => x.Fornecedor!.Nome))
                 .ForMember(d => d.IdFornecedor, d => d.MapFrom(x => x.Fornecedor!.Id));
            config.CreateMap<Pedido, PedidoModel>()
                .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome))
                .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));

                config.CreateMap<ItensPedido, ItensPedidoModel>()
                    .ForMember(d => d.IdProduto, d => d.MapFrom(x => x.Produto!.Id))
                    .ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Nome))
                    .ForMember(d => d.IdPedido, d => d.MapFrom(x => x.Pedido!.Id));
            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
