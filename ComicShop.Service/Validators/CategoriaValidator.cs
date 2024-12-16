using ComicShop.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Service.Validators
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("Por favor, informe o nome da Categoria.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe o nome da Categoria.")
               .MaximumLength(50).WithMessage("Muito Extenso! O Nome pode ter no máximo 50 caracteres.");
        }
    }
}
