using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LePhamTheVu_231220962_de01.Models;
using LePhamTheVu_231220962_de01.Models.ComputerDBModels;

namespace LePhamTheVu_231220962_de01.Controllers
{
    public class lptvComputersController : Controller
    {
        private readonly lptvComputerDbContext _context;

        public lptvComputersController(lptvComputerDbContext context)
        {
            _context = context;
        }

        // GET: lptvComputers
        public async Task<IActionResult> Index()
        {
            return View(await _context.lptvComputer.ToListAsync());
        }

        // GET: lptvComputers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lptvComputer = await _context.lptvComputer
                .FirstOrDefaultAsync(m => m.LePhamTheVuComId == id);
            if (lptvComputer == null)
            {
                return NotFound();
            }

            return View(lptvComputer);
        }

        // GET: lptvComputers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lptvComputers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LePhamTheVuComId,LePhamTheVuComName,LePhamTheVuComPrice,LePhamTheVuComImage,LePhamTheVuComStatus")] lptvComputer lptvComputer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lptvComputer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lptvComputer);
        }

        // GET: lptvComputers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lptvComputer = await _context.lptvComputer.FindAsync(id);
            if (lptvComputer == null)
            {
                return NotFound();
            }
            return View(lptvComputer);
        }

        // POST: lptvComputers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LePhamTheVuComId,LePhamTheVuComName,LePhamTheVuComPrice,LePhamTheVuComImage,LePhamTheVuComStatus")] lptvComputer lptvComputer)
        {
            if (id != lptvComputer.LePhamTheVuComId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lptvComputer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lptvComputerExists(lptvComputer.LePhamTheVuComId))
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
            return View(lptvComputer);
        }

        // GET: lptvComputers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lptvComputer = await _context.lptvComputer
                .FirstOrDefaultAsync(m => m.LePhamTheVuComId == id);
            if (lptvComputer == null)
            {
                return NotFound();
            }

            return View(lptvComputer);
        }

        // POST: lptvComputers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lptvComputer = await _context.lptvComputer.FindAsync(id);
            if (lptvComputer != null)
            {
                _context.lptvComputer.Remove(lptvComputer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lptvComputerExists(string id)
        {
            return _context.lptvComputer.Any(e => e.LePhamTheVuComId == id);
        }
    }
}
