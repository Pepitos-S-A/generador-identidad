using Duisv.Modelos;
using FluentValidation;

namespace Duisv.Validaciones
{
    internal class AgregarCiudadanoValidador : AbstractValidator<Ciudadano>
    {
        public AgregarCiudadanoValidador()
        {
            RuleFor(c => c.Nombres).NotEmpty().WithMessage("Los nombres son requeridos.");
            RuleFor(c => c.Apellidos).NotEmpty().WithMessage("Los apellidos son requeridos.");
            RuleFor(c => c.CiudadanoPor).NotEmpty().WithMessage("La ciudadania es requerida.");
            RuleFor(c => c.CiudadanoPor).NotEmpty().WithMessage("La ciudadania es requerida.");
            RuleFor(c => c.FechaNacimiento).NotEmpty().WithMessage("La fecha de nacimiento es requerida.");
            RuleFor(c => c.Residencia).NotEmpty().WithMessage("La residencia es requerida.");
            RuleFor(c => c.EstadoFamiliar).NotEmpty().WithMessage("El estado familiar es requerido.");
            RuleFor(c => c.Profesion).NotEmpty().WithMessage("La profesion es requerida.");
            
        }
    }
}
