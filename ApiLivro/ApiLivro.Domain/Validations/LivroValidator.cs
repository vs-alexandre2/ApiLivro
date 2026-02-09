using ApiLivro.ApiLivro.Domain.Enums;
using ApiLivro.ApiLivro.Domain.Models;
using FluentValidation;
using System.Data;

namespace ApiLivro.ApiLivro.Domain.Validations
{
    public class LivroValidator : AbstractValidator<LivroModel>
    {
        public LivroValidator()
        {
            RuleFor(t => t.Livro)
                .NotEmpty()
                .WithMessage("O nome do livro é obrigatório!")
                .MaximumLength(40)
                .WithMessage("O nome do livro deve conter no máximo 40 caracteres!");

            RuleFor(t => t.Autor)
                .NotEmpty()
                .WithMessage("O nome do autor é obrigatório!")
                .MaximumLength(20)
                .WithMessage("O nome do autor deve conter no máximo 20 caracteres!");

            RuleFor(t => t.Genero)
                .IsInEnum()
                .WithMessage("Gênero inválido!");
        }
    }
}
