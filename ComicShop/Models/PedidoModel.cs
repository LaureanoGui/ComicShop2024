using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.App.Models
{
    public class PedidoModel
    {
        public PedidoModel()
        {
            Itens = new List<ItensPedidoModel>();
        }
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public float ValorTotal { get; set; }
        //public string Status { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public List<ItensPedidoModel> Itens { get; set; }
    }

    public class ItensPedidoModel
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public string Produto { get; set; }
        public int IdPedido { get; set; }
        public string Pedido { get; set; }
        public int Quantidade { get; set; }
        public float PrecoUnitario { get; set; }
    }

}
    

