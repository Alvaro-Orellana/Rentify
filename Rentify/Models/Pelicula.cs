using System;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Models
{
    public class Pelicula
    {
        public Pelicula()
        {
        }


        public int Id { get; set; }

        [Required(ErrorMessage ="El campo Nombre es requerido")]
        [StringLength(255)]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El campo Fecha de estreno es requerido")]
        public DateTime FechaEstreno { get; set; }

        [Required(ErrorMessage = "Debe agregar el numero de peliculas en stock")]
        [MinStockPermitido]
        public ushort CantidadEnStock { get; set; }

        public virtual Genero Genero { get; set; }

        public byte GeneroId { get; set; }
    }
}
