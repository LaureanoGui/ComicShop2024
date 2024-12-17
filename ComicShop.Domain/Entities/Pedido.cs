using ComicShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Domain.Entities
{
    public class Pedido : BaseEntity<int>
    {
        public Pedido()
        {
            Itens = new List<ItensPedido>();
        }
        public Pedido(int id, List<ItensPedido> itens, DateTime datapedido, float? valortotal,  Cliente? cliente, Usuario? usuario) : base(id)
        {
            this.DataPedido = datapedido;
            this.ValorTotal = valortotal;
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.Itens = itens;
        }
        public DateTime DataPedido { get; set; }
        public float? ValorTotal { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual List<ItensPedido> Itens { get; set; }
    }

    public class ItensPedido : BaseEntity<int>
    {
        public ItensPedido()
        {

        }
        public ItensPedido(int id, int quantidade, float precounitario, Produto? produto, Pedido? pedido)
        {
            this.Id = id;
            this.Quantidade = quantidade;
            this.PrecoUnitario = precounitario;
            this.Pedido = pedido;
            this.Produto = produto;
        }
        public int Quantidade { get; set; }
        public float PrecoUnitario { get; set; }
        public virtual Pedido? Pedido { get; set; }
        public virtual Produto? Produto { get; set; }
    }
}
