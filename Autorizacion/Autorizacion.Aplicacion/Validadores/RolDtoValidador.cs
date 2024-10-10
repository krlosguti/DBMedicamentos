using Autorizacion.Aplicacion.DTOs;
using FluentValidation;

namespace Autorizacion.Aplicacion.Validadores
{
    public class RolDtoValidador : AbstractValidator<RolResponseDto>
    {
        public RolDtoValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("El Id es requerido.");

            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El Nombre es requerido.")
                .MaximumLength(100).WithMessage("El Nombre no debe exceder 100 caracteres.");
        }
    }
}
