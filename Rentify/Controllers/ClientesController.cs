using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rentify.Models;


namespace Rentify.Controllers
{
    public class ClientesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var clientes = ObtenerClientes();
            return View(clientes);
        }


        public ActionResult Detalles(int id)
        {
            var cliente = ObtenerClientes().SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return Content("Cliente con id:" + id + " no existe");

            return View(cliente);
        }


        private IEnumerable<Cliente> ObtenerClientes()
        {
            return new List<Cliente>
             {
                 new Cliente { Id = 1, Nombre = "Juan Perez" },
                 new Cliente { Id = 2, Nombre = "Maria Gonzales" }
             };
        }
    }
}
