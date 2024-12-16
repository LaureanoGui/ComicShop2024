using ComicShop.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("Por favor, informe o nome do Produto.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe o nome do Produto.")
               .MaximumLength(100).WithMessage("Muito Extenso! O Nome pode ter no máximo 100 caracteres.");
            RuleFor(c => c.Edicao)
               .NotEmpty().WithMessage("Por favor, informe o número da edição.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe o número da edição.");
            RuleFor(c => c.Preco)
              .NotEmpty().WithMessage("Por favor, informe o preço.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o preço.");
            RuleFor(c => c.Autor)
               .NotEmpty().WithMessage("Por favor, informe a autoria.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe a autoria.")
            .MaximumLength(100).WithMessage("Muito Extenso! O nome do(s) autor(es) pode ter no máximo 100 caracteres.");
            RuleFor(c => c.Editora)
               .NotEmpty().WithMessage("Por favor, informe a editora.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe a editora.")
               .MaximumLength(100).WithMessage("Muito Extenso! O nome da editora pode ter no máximo 100 caracteres.");
            RuleFor(c => c.AnoPublicacao)
              .NotEmpty().WithMessage("Por favor, informe o ano de publicação.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o ano de publicação.");
            RuleFor(c => c.QuantidadeEstoque)
              .NotEmpty().WithMessage("Por favor, informe a quantidade em estoque.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe a quantidade em estoque.");
            RuleFor(c => c.Fornecedor)
              .NotEmpty().WithMessage("Por favor, informe o fornecedor.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o fornecedor.");
            RuleFor(c => c.Categoria)
                .NotEmpty().WithMessage("Por favor, informe a Categoria.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe a Categoria.");
        }
    }
}
