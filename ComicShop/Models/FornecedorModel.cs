using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.App.Models
{
    public class FornecedorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Contato { get; set; }

        public string Endereco { get; set; }
    }
}
