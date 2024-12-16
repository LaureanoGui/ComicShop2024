using ComicShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Domain.Entities
{
    public class Categoria : BaseEntity<int>
    {
        public Categoria() { }

        public Categoria(int id, string nome, string descricao) : base (id) {
            this.Nome = nome;
            this.Descricao = descricao;
        }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
