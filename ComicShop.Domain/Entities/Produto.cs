using ComicShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto() { }
        public Produto(int id, string nome, string descricao, int edicao, float preco, string autor, string editora, int anopublicacao, int quantidadeestoque, Fornecedor fornecedor, Categoria categoria) : base(id)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Edicao = edicao;
            this.Preco = preco;
            this.Autor = autor;
            this.Editora = editora;
            this.AnoPublicacao = anopublicacao;
            this.QuantidadeEstoque = quantidadeestoque;
            this.Fornecedor = fornecedor;
            this.Categoria = categoria;
        }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Edicao { get; set; }
        public float Preco { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
