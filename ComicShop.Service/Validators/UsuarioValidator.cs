using ComicShop.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicShop.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O Nome do usuário é obrigatório.")
                .NotNull().WithMessage("O Nome do usuário é obrigatório.");
            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Senha é obrigatória.")
                .NotNull().WithMessage("Senha é obrigatória.");
            //.MinimumLength(8).WithMessage("A senha precisa possuir 8 caracteres, no mínimo")
            //.Matches(@"[A-Z]+").WithMessage("A senha precisa possuir, pelo menos, um caractere maíusculo.")
            //.Matches(@"[a-z]+").WithMessage("A senha precisa possuir, pelo menos, um caractere minúsculo")
            //.Matches(@"[0-9]+").WithMessage("A senha precisa possuir, pelo menos, um caractere numérico")
            //.Matches(@"[\!\?\*\.\@]+").WithMessage("a senha precisa possuir, pelo menos, um caractere especial: (! ? * .)");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("E-mail é obrigatório.")
                .NotNull().WithMessage("E-mail é obrigatório.")
                .EmailAddress().WithMessage("E-mail inválido.");
            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("Login é obrigatório.")
                .NotNull().WithMessage("Login é obrigatório.");
            RuleFor(c => c.DataCadastro)
                .NotEmpty().WithMessage("Data de Cadastro é Obrigatória.")
                .NotNull().WithMessage("Data de Cadastro é Obrigatória.");
            RuleFor(c => c.DataLogin)
                .NotEmpty().WithMessage("Data de Login é Obrigatória.")
                .NotNull().WithMessage("Data de Login é Obrigatória.");
        }
    }
}
