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
            RuleFor(c => c.Genero).NotEmpty().NotEqual("-- Seleccionar --").WithMessage("El genero es requerido.");
            RuleFor(c => c.FechaNacimiento).NotEmpty().WithMessage("La fecha de nacimiento es requerida.");
            RuleFor(c => c.Residencia).NotEmpty().WithMessage("La residencia es requerida.");
            RuleFor(c => c.EstadoFamiliar).NotEmpty().NotEqual("-- Seleccionar --").WithMessage("El estado familiar es requerido.");
            RuleFor(c => c.Profesion).NotEmpty().NotEqual("-- Seleccionar --").WithMessage("La profesion es requerida.");
            RuleFor(c => c.DepartamentoNacimiento).NotEmpty().NotEqual("-- Seleccionar --").WithMessage("El departamento de nacimiento es requerido.");
            RuleFor(c => c.DepartamentoResidencia).NotEmpty().NotEqual("-- Seleccionar --").WithMessage("El departamento de residencia es requerido.");
            
        }
    }
}
