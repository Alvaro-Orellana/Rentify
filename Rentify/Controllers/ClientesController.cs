using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rentify.Models;
using Rentify.Data;

namespace Rentify.Controllers
{
    public class ClientesController : Controller
    {

        private readonly MyDBContext _context;

        public ClientesController(MyDBContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing);
            _context.Dispose(); 
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var clientes = _context.Clientes.Include(c => c.TipoMembresia).ToList();

            return View(clientes);
        }


        public ActionResult Detalles(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);
           
            if (cliente == null)
                return Content("Cliente con id:" + id + " no existe");

            return View(cliente);
        }

        // Remplazado por _context donde obtengo los clientes de la BD
        //
        //private IEnumerable<Cliente> ObtenerClientes()
        //{
        //    return new List<Cliente>
        //     {
        //         new Cliente { Id = 1, Nombre = "Juan Perez" },
        //         new Cliente { Id = 2, Nombre = "Maria Gonzales" }
        //     };
        //}
    }
}
