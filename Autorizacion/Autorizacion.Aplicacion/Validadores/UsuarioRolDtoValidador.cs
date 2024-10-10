using Autorizacion.Aplicacion.DTOs;
using FluentValidation;

namespace Autorizacion.Aplicacion.Validadores
{
    public class UsuarioRolDtoValidador : AbstractValidator<UsuarioRolResponseDto>
    {
        public UsuarioRolDtoValidador()
        {
            RuleFor(x => x.RolId)
                .NotEmpty().WithMessage("El Id del Rol es requerido.");

            RuleFor(x => x.UsuarioId)
                .NotEmpty().WithMessage("El Id del Usuario es requerido.");
        }
    }
}
