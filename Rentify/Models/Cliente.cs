using System;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Models
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(255)]
        public string Nombre { get; set; }

        public bool EstaSubscrito { get; set; }

        public virtual TipoMembresia TipoMembresia { get; set; }

        public byte TipoMembresiaId { get; set; }
        public DateTime? FechaNacimiento { get; set; }

    }
}
