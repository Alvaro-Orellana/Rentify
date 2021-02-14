using System;
using System.Collections.Generic;
using Rentify.Models;

namespace Rentify.ViewModels
{
    public class PeliculaRandomViewModel
    {
        public PeliculaRandomViewModel()
        {
        }

        public List<Pelicula> Peliculas { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
