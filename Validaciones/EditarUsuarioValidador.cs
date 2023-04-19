﻿using Duisv.Modelos;
using FluentValidation;

namespace Duisv.Validaciones
{
    internal class EditarUsuarioValidador : AbstractValidator<Usuario>
    {
        public EditarUsuarioValidador()
        {
            RuleFor(u => u.Nombre).NotEmpty().WithMessage("El nombre es requerido.");
            RuleFor(u => u.Apellido).NotEmpty().WithMessage("El apellido es requerido.");
            RuleFor(u => u.CorreoElectronico).EmailAddress().WithMessage("Formato de correo electronico incorrecto.");
            RuleFor(u => u.FechaNacimiento).NotEmpty().WithMessage("La fecha de nacimiento es requerida.");
            RuleFor(u => u.Direccion).NotEmpty().WithMessage("La dirección es requerida.");
            RuleFor(u => u.Telefono).NotEmpty().WithMessage("El numero de telefono es requerido.");
            RuleFor(u => u.NombreUsuario).NotEmpty().WithMessage("El nombre de usuario es requerido.");
            RuleFor(u => u.RolId).NotEqual(string.Empty).WithMessage("Seleccione un rol.");
        }
    }
}
