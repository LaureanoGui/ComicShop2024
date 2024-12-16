using ComicShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente() { }
        public Cliente(int id, string nome, string email, string telefone, string endereco, DateTime datacadastro, String documento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.DataCadastro = datacadastro;
            this.Documento = documento;
        }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Documento { get; set; }
    }
}
