using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rentify.Data;
using Rentify.Models;

namespace Rentify.Controllers
{
    public class CustomersController2 : Controller
    {
        private readonly MyDBContext _context;

        public CustomersController2(MyDBContext context)
        {
            _context = context;
        }

        // GET: CustomersController2
        public async Task<IActionResult> Index()
        {
            var myDBContext = _context.Clientes.Include(c => c.TipoMembresia);
            return View(await myDBContext.ToListAsync());
        }

        // GET: CustomersController2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.TipoMembresia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: CustomersController2/Create
        public IActionResult Create()
        {
            ViewData["TipoMembresiaId"] = new SelectList(_context.Set<TipoMembresia>(), "Id", "Id");
            return View();
        }

        // POST: CustomersController2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,EstaSubscrito,TipoMembresiaId,FechaNacimiento")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoMembresiaId"] = new SelectList(_context.Set<TipoMembresia>(), "Id", "Id", cliente.TipoMembresiaId);
            return View(cliente);
        }

        // GET: CustomersController2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["TipoMembresiaId"] = new SelectList(_context.Set<TipoMembresia>(), "Id", "Id", cliente.TipoMembresiaId);
            return View(cliente);
        }

        // POST: CustomersController2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,EstaSubscrito,TipoMembresiaId,FechaNacimiento")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoMembresiaId"] = new SelectList(_context.Set<TipoMembresia>(), "Id", "Id", cliente.TipoMembresiaId);
            return View(cliente);
        }

        // GET: CustomersController2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.TipoMembresia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: CustomersController2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
