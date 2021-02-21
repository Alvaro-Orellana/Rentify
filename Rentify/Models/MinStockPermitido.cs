using System;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Models
{
    public class MinStockPermitido: ValidationAttribute
    {
        public MinStockPermitido()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var pelicula = (Pelicula)validationContext.ObjectInstance;

            // Si la membresia elegida es pago al contado no se necesita validacion adicional
            if (pelicula.CantidadEnStock >= 1)
                return ValidationResult.Success;
            else
                return new ValidationResult("El numero en stock debe ser mayor o igual a 1");
        }
    }
}
