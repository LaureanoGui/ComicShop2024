using FluentValidation;
using ComicShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("Por favor, informe o nome do Cliente.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe o nome do Cliente.")
               .MaximumLength(100).WithMessage("Muito Extenso! O Nome pode ter no máximo 100 caracteres.");
            RuleFor(c => c.Email)
               .NotEmpty().WithMessage("Por favor, informe o endereço de Email.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe o endereço de Email");
            RuleFor(c => c.Telefone)
              .NotEmpty().WithMessage("Por favor, informe o telefone.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o telefone.");
            RuleFor(c => c.Endereco)
             .NotEmpty().WithMessage("Por favor, informe o endereço.")
             .NotNull().NotEmpty().WithMessage("Por favor, informe o endereço.");
            RuleFor(c => c.DataCadastro)
             .NotEmpty().WithMessage("Por favor, informe a data de cadastro.")
             .NotNull().NotEmpty().WithMessage("Por favor, informe a data de cadastro.");
            RuleFor(c => c.DataCadastro)
            .NotEmpty().WithMessage("Por favor, informe o documento do Cliente.")
            .NotNull().NotEmpty().WithMessage("Por favor, informe o documento do Cliente.");
        }
    }
}
