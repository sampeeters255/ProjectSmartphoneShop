using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectSmartphoneShop.Data;
using ProjectSmartphoneShop.Models;

namespace ProjectSmartphoneShop.Controllers
{
    public class WinkelMandSmartphonesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WinkelMandSmartphonesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WinkelMandSmartphones
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.WinkelMandSmartphones.Include(w => w.Smartphone).Include(w => w.WinkelMand);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: WinkelMandSmartphones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var winkelMandSmartphone = await _context.WinkelMandSmartphones
                .Include(w => w.Smartphone)
                .Include(w => w.WinkelMand)
                .FirstOrDefaultAsync(m => m.WinkelMandSmartphoneId == id);
            if (winkelMandSmartphone == null)
            {
                return NotFound();
            }

            return View(winkelMandSmartphone);
        }

        // GET: WinkelMandSmartphones/Create
        public IActionResult Create()
        {
            ViewData["SmartphoneId"] = new SelectList(_context.Smartphones, "SmartphoneId", "SmartphoneId");
            ViewData["WinkelmandId"] = new SelectList(_context.WinkelManden, "WinkelMandId", "WinkelMandId");
            return View();
        }

        // POST: WinkelMandSmartphones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WinkelMandSmartphoneId,WinkelmandId,SmartphoneId")] WinkelMandSmartphone winkelMandSmartphone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(winkelMandSmartphone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SmartphoneId"] = new SelectList(_context.Smartphones, "SmartphoneId", "SmartphoneId", winkelMandSmartphone.SmartphoneId);
            ViewData["WinkelmandId"] = new SelectList(_context.WinkelManden, "WinkelMandId", "WinkelMandId", winkelMandSmartphone.WinkelmandId);
            return View(winkelMandSmartphone);
        }

        // GET: WinkelMandSmartphones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var winkelMandSmartphone = await _context.WinkelMandSmartphones.FindAsync(id);
            if (winkelMandSmartphone == null)
            {
                return NotFound();
            }
            ViewData["SmartphoneId"] = new SelectList(_context.Smartphones, "SmartphoneId", "SmartphoneId", winkelMandSmartphone.SmartphoneId);
            ViewData["WinkelmandId"] = new SelectList(_context.WinkelManden, "WinkelMandId", "WinkelMandId", winkelMandSmartphone.WinkelmandId);
            return View(winkelMandSmartphone);
        }

        // POST: WinkelMandSmartphones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WinkelMandSmartphoneId,WinkelmandId,SmartphoneId")] WinkelMandSmartphone winkelMandSmartphone)
        {
            if (id != winkelMandSmartphone.WinkelMandSmartphoneId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(winkelMandSmartphone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WinkelMandSmartphoneExists(winkelMandSmartphone.WinkelMandSmartphoneId))
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
            ViewData["SmartphoneId"] = new SelectList(_context.Smartphones, "SmartphoneId", "SmartphoneId", winkelMandSmartphone.SmartphoneId);
            ViewData["WinkelmandId"] = new SelectList(_context.WinkelManden, "WinkelMandId", "WinkelMandId", winkelMandSmartphone.WinkelmandId);
            return View(winkelMandSmartphone);
        }

        // GET: WinkelMandSmartphones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var winkelMandSmartphone = await _context.WinkelMandSmartphones
                .Include(w => w.Smartphone)
                .Include(w => w.WinkelMand)
                .FirstOrDefaultAsync(m => m.WinkelMandSmartphoneId == id);
            if (winkelMandSmartphone == null)
            {
                return NotFound();
            }

            return View(winkelMandSmartphone);
        }

        // POST: WinkelMandSmartphones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var winkelMandSmartphone = await _context.WinkelMandSmartphones.FindAsync(id);
            _context.WinkelMandSmartphones.Remove(winkelMandSmartphone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WinkelMandSmartphoneExists(int id)
        {
            return _context.WinkelMandSmartphones.Any(e => e.WinkelMandSmartphoneId == id);
        }
    }
}
