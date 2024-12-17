using ComicShop.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Service.Validators
{
    public class PedidoValidator : AbstractValidator<Pedido>
    {
        public PedidoValidator()
        {
            RuleFor(c => c.DataPedido)
              .NotEmpty().WithMessage("Por favor, informe a data do pedido.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe a data do pedido.");
            RuleFor(c => c.ValorTotal)
              .NotEmpty().WithMessage("Por favor, informe o valor total do pedido.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o valor total do pedido.");
            /*RuleFor(c => c.Status)
              .NotEmpty().WithMessage("Por favor, informe o status do pedido.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o status do pedido.");*/
            RuleFor(c => c.Cliente)
              .NotEmpty().WithMessage("Por favor, informe o Cliente.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o Cliente.");
            RuleFor(c => c.Usuario)
              .NotEmpty().WithMessage("Por favor, informe o Usuario.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o Usuario.");
            RuleFor(c => c.Itens)
              .NotEmpty().WithMessage("Por favor, informe os produtos.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe os produtos.");
        }
    }
    public class ItensPedidoValidator : AbstractValidator<ItensPedido>
    {
        public ItensPedidoValidator()
        {
            RuleFor(c => c.Produto)
             .NotEmpty().WithMessage("Por favor, informe o produto.")
             .NotNull().NotEmpty().WithMessage("Por favor, informe a produto.");
            RuleFor(c => c.Quantidade)
             .NotEmpty().WithMessage("Por favor, informe a quantidade.")
             .NotNull().NotEmpty().WithMessage("Por favor, informe a quantidade.");
            RuleFor(c => c.PrecoUnitario)
             .NotEmpty().WithMessage("Por favor, informe o preço unitário.")
             .NotNull().NotEmpty().WithMessage("Por favor, informe o preço unitário.");
            RuleFor(c => c.Pedido)
             .NotEmpty().WithMessage("Por favor, informe o pedido.")
             .NotNull().NotEmpty().WithMessage("Por favor, informe o pedido.");
        }
    }
}
