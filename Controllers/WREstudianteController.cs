using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WRproyectoCompleto.Data;
using WRproyectoCompleto.Models;

namespace WRproyectoCompleto.Controllers
{
    public class WREstudianteController : Controller
    {
        private readonly WRproyectoCompletoContext _context;

        public WREstudianteController(WRproyectoCompletoContext context)
        {
            _context = context;
        }

        // GET: WREstudiante
        public async Task<IActionResult> Index()
        {
            return View(await _context.WREstudiante.ToListAsync());
        }

        // GET: WREstudiante/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wREstudiante = await _context.WREstudiante
                .FirstOrDefaultAsync(m => m.WRestudianteId == id);
            if (wREstudiante == null)
            {
                return NotFound();
            }

            return View(wREstudiante);
        }

        // GET: WREstudiante/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WREstudiante/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WRestudianteId,WRcedulaEstudiante,WRnombreEstudiante,WRapellidoEstudiante,WRnombreRepresentanteEstudiante,WRedad")] WREstudiante wREstudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wREstudiante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wREstudiante);
        }

        // GET: WREstudiante/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wREstudiante = await _context.WREstudiante.FindAsync(id);
            if (wREstudiante == null)
            {
                return NotFound();
            }
            return View(wREstudiante);
        }

        // POST: WREstudiante/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WRestudianteId,WRcedulaEstudiante,WRnombreEstudiante,WRapellidoEstudiante,WRnombreRepresentanteEstudiante,WRedad")] WREstudiante wREstudiante)
        {
            if (id != wREstudiante.WRestudianteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wREstudiante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WREstudianteExists(wREstudiante.WRestudianteId))
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
            return View(wREstudiante);
        }

        // GET: WREstudiante/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wREstudiante = await _context.WREstudiante
                .FirstOrDefaultAsync(m => m.WRestudianteId == id);
            if (wREstudiante == null)
            {
                return NotFound();
            }

            return View(wREstudiante);
        }

        // POST: WREstudiante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wREstudiante = await _context.WREstudiante.FindAsync(id);
            if (wREstudiante != null)
            {
                _context.WREstudiante.Remove(wREstudiante);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WREstudianteExists(int id)
        {
            return _context.WREstudiante.Any(e => e.WRestudianteId == id);
        }
    }
}
