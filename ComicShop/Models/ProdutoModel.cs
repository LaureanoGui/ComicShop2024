using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.App.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Edicao{ get; set; }
        public float Preco { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}
