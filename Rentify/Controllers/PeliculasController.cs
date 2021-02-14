using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rentify.Models;
using Rentify.ViewModels;


namespace Rentify.Controllers
{
    public class PeliculasController : Controller
    {

        public ViewResult Index()
        {
             var peliculas = ObtenerPeliculas();
             return View(peliculas);


            /*var peliculas = new List<Pelicula>
                {
                new Pelicula { Nombre = "Titanic" },
                new Pelicula { Nombre = "Wall-e" },
                new Pelicula { Nombre = "Shrek" },
                new Pelicula { Nombre = "Batman" }
                };

            var clientes = new List<Cliente>
            {
                new Cliente { Nombre = "Cliente 1"},
                new Cliente { Nombre = "Cliente 2" }
            };

            var viewModel = new PeliculaRandomViewModel
            {
                Peliculas = peliculas,
                Clientes = clientes
            };
            return View(viewModel);
            */
        }


        private IEnumerable<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>
             {
                 new Pelicula { Id = 1, Nombre = "Shrek" },
                 new Pelicula { Id = 2, Nombre = "Wall-e" }
             };
        }



        // GET: Peliculas/Random
        public IActionResult Random()
        {
            var pelicula = new Pelicula { Nombre = "Titanic" };
            var clientes = new List<Cliente>
            {
                new Cliente { Nombre = "Cliente 1"},
                new Cliente { Nombre = "Cliente 2" }
            };

            var viewModel = new PeliculaRandomViewModel
            {
                //Peliculas = pelicula,
                Clientes = clientes
            };
            return View(viewModel);
        }

        //[Route("peliculas/fecha/{anio}/{mes:regex(\\d{4}):range(1,12)}")]
        [Route("peliculas/fecha/{anio}/{mes}")]
        public IActionResult FechaDeEstreno(int anio, int mes)
        {
            return Content(anio + "/ " + mes);
        }

    }
}
