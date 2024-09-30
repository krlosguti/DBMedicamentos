using FluentValidation;
using Permisos.Aplicacion.DTOs;

namespace Permisos.Aplicacion.Validadores
{
    public class ModuloDtoValidador : AbstractValidator<ModuloDto>
    {
        public ModuloDtoValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("El Id es requerido.");

            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El Nombre es requerido.")
                .MaximumLength(100).WithMessage("El Nombre no debe exceder 100 caracteres.");

            RuleFor(x => x.Descripcion)
                .NotEmpty().WithMessage("La Descripción es requerida.")
                .MaximumLength(400).WithMessage("La Descripción no debe exceder 400 caracteres.");
        }
    }
}
