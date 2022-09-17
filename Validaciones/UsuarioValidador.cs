using System;
using Duisv.Modelos;
using FluentValidation;

namespace Duisv.Validaciones
{
    internal class UsuarioValidador : AbstractValidator<Usuario>
    {
        public UsuarioValidador()
        {
            RuleFor(u => u.Nombre).NotEmpty().WithMessage("El nombre es requerido.");
            RuleFor(u => u.Apellido).NotEmpty().WithMessage("El nombre es requerido.");
            RuleFor(u => u.Direccion).NotEmpty().WithMessage("La dirección es requerida.");
            RuleFor(u => u.CorreoElectronico).EmailAddress().WithMessage("Formato de correo electronico incorrecto.");
            RuleFor(u => u.Telefono).NotEmpty().WithMessage("El numero de telefono es requerido.");
            RuleFor(u => u.NombreUsuario).NotEmpty().WithMessage("El nombre de usuario es requerido.");
            RuleFor(u => u.Clave).NotEmpty().WithMessage("La clave de usuario es requerida.");
            RuleFor(u => u.RepetirClave).NotEqual(u => u.Clave).WithMessage("Las contraseñas no coiciden.");
            RuleFor(u => u.RolId).Equal(0).WithMessage("Seleccione un rol.");
            RuleFor(u => u.FechaNacimiento).NotEmpty().WithMessage("La fecha de nacimiento es requerida.");            
        }
    }
}
