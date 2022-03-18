using FluentValidation;

namespace CleanArcuitecture.Application.Feactures.Autores.Commands.UpdateAutor
{
    public class UpdateAutorCommandValidator: AbstractValidator<UpdateAutorCommand>
    {
        public UpdateAutorCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{Nombre} no puede estar vacio")
                .NotNull().WithMessage("{Nombre} no puede estar vacio")
                .MaximumLength(50).WithMessage("{Nombre} no puede exceder los 50 caracteres");
        }
    }
}
