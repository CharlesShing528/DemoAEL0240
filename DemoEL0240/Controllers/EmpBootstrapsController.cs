using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoEL0240.Data;
using DemoEL0240.Models;

namespace DemoEL0240.Controllers
{
    public class EmpBootstrapsController : Controller
    {
        private readonly EmpBootstrapContext _context;

        public EmpBootstrapsController(EmpBootstrapContext context)
        {
            _context = context;
        }

        // GET: EmpBootstraps
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmpBootstrap.ToListAsync());
        }

        public async Task<IActionResult> IndexBootstrap()
        {
            return View(await _context.EmpBootstrap.ToListAsync());
        }

        // GET: EmpBootstraps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empBootstrap = await _context.EmpBootstrap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empBootstrap == null)
            {
                return NotFound();
            }

            return View(empBootstrap);
        }

        // GET: EmpBootstraps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmpBootstraps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Mobile,Email,Department,Title")] EmpBootstrap empBootstrap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empBootstrap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empBootstrap);
        }

        // GET: EmpBootstraps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empBootstrap = await _context.EmpBootstrap.FindAsync(id);
            if (empBootstrap == null)
            {
                return NotFound();
            }
            return View(empBootstrap);
        }

        // POST: EmpBootstraps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Mobile,Email,Department,Title")] EmpBootstrap empBootstrap)
        {
            if (id != empBootstrap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empBootstrap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpBootstrapExists(empBootstrap.Id))
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
            return View(empBootstrap);
        }

        // GET: EmpBootstraps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empBootstrap = await _context.EmpBootstrap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empBootstrap == null)
            {
                return NotFound();
            }

            return View(empBootstrap);
        }

        // POST: EmpBootstraps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empBootstrap = await _context.EmpBootstrap.FindAsync(id);
            _context.EmpBootstrap.Remove(empBootstrap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpBootstrapExists(int id)
        {
            return _context.EmpBootstrap.Any(e => e.Id == id);
        }
    }
}
