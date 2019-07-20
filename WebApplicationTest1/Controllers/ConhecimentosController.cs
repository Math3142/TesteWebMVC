using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationTest1.Models;

namespace WebApplicationTest1.Controllers
{
    public class ConhecimentosController : Controller
    {
        private readonly WebApplicationTest1Context _context;

        public ConhecimentosController(WebApplicationTest1Context context)
        {
            _context = context;
        }

        // GET: Conhecimentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Conhecimento.ToListAsync());
        }

        // GET: Conhecimentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conhecimento = await _context.Conhecimento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conhecimento == null)
            {
                return NotFound();
            }

            return View(conhecimento);
        }

        // GET: Conhecimentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conhecimentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Id")] Conhecimento conhecimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conhecimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conhecimento);
        }

        // GET: Conhecimentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conhecimento = await _context.Conhecimento.FindAsync(id);
            if (conhecimento == null)
            {
                return NotFound();
            }
            return View(conhecimento);
        }

        // POST: Conhecimentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Id")] Conhecimento conhecimento)
        {
            if (id != conhecimento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conhecimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConhecimentoExists(conhecimento.Id))
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
            return View(conhecimento);
        }

        // GET: Conhecimentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conhecimento = await _context.Conhecimento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conhecimento == null)
            {
                return NotFound();
            }

            return View(conhecimento);
        }

        // POST: Conhecimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conhecimento = await _context.Conhecimento.FindAsync(id);
            _context.Conhecimento.Remove(conhecimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConhecimentoExists(int id)
        {
            return _context.Conhecimento.Any(e => e.Id == id);
        }
    }
}
