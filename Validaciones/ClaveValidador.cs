using Duisv.Modelos;
using FluentValidation;

namespace Duisv.Validaciones
{
    internal class ClaveValidador : AbstractValidator<Usuario>
    {
        public ClaveValidador()
        {
            RuleFor(u => u.Clave).NotEmpty().WithMessage("La clave de usuario es requerida.");
            RuleFor(u => u.RepetirClave).Equal(u => u.Clave).WithMessage("Las contraseñas no coiciden.");
        }
    }
}
