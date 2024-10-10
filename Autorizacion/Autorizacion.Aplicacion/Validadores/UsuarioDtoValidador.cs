using Autorizacion.Aplicacion.DTOs;
using FluentValidation;

namespace Autorizacion.Aplicacion.Validadores
{
    public class UsuarioDtoValidador : AbstractValidator<UsuarioResponseDto>
    {
        public UsuarioDtoValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("El Id es requerido.");

            RuleFor(x => x.Nombres)
                .NotEmpty().WithMessage("El Nombre es requerido.");

            RuleFor(x => x.Apellidos)
                .NotEmpty().WithMessage("El Apellido es requerido.");

            RuleFor(x => x.NombreUsuario)
                .NotEmpty().WithMessage("El NombreUsuario es requerido.");
        }
    }
}
