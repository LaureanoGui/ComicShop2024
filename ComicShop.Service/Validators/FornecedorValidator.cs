using FluentValidation;
using ComicShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Service.Validators
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public FornecedorValidator() {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome do Fornecedor.")
                .NotNull().NotEmpty().WithMessage("Por favor, informe o nome do Fornecedor.")
                .MaximumLength(100).WithMessage("Muito Extenso! O Nome pode ter no máximo 100 caracteres.");
            RuleFor(c => c.Contato)
                .NotEmpty().WithMessage("Por favor, informe o contato do Fornecedor.")
                .NotNull().NotEmpty().WithMessage("Por favor, informe o contato do Fornecedor.");
            RuleFor(C => C.Endereco)
                .NotEmpty().WithMessage("Por favor, informe o endereço do Fornecedor.")
                .NotNull().NotEmpty().WithMessage("Por favor, informe o endereço do Fornecedor.");
        }
    }
}
