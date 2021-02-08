using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rentify.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rentify.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var pelicula = new Pelicula { Nombre = "Titanic" };
            return View(pelicula);
        }
    }
}
