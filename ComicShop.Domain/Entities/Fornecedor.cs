using ComicShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Domain.Entities
{
    public class Fornecedor : BaseEntity<int>
    {
        public Fornecedor() { }
        public Fornecedor(int id, string nome, string contato, string endereco)
        {

            this.Id = id;
            this.Nome = nome;
            this.Contato = contato;
            this.Endereco = endereco;
        }
        public string? Nome { get; set; }
        public string? Contato{ get; set; }
        public string? Endereco { get; set; }
    }
}
