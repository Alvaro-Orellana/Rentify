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
        public String Nombre { get; set; }
        public DateTime FechaEstreno { get; set; }
        public ushort CantidadEnStock { get; set; }
        [Required]
        public Genero Genero { get; set; }
        public byte GeneroId { get; set; }
    }
}
