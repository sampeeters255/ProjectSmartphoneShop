using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectSmartphoneShop.Areas.Identity.Data;
using ProjectSmartphoneShop.Data;
using ProjectSmartphoneShop.Models;

namespace ProjectSmartphoneShop.Controllers
{
    [Authorize(Roles= "Member")]
    public class WinkelMandController : Controller
    {
        private readonly ApplicationDbContext _context;
        public List<Smartphone> Smartphones;
        public Klant klant;
        public Smartphone Smartphone;

        public WinkelMandController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WinkelMand
        public async Task<IActionResult> Index()
        {
            return View(await _context.WinkelManden.ToListAsync());
        }

        // GET: WinkelMand/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var winkelMand = await _context.WinkelManden
                .FirstOrDefaultAsync(m => m.WinkelMandId == id);
            if (winkelMand == null)
            {
                return NotFound();
            }

            return View(winkelMand);
        }

        // GET: WinkelMand/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WinkelMand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WinkelMandId,KlantId,SmartphoneId,OrderId,TotaalPrijs,BestelDatum")] WinkelMand winkelMand)
        {
            if (ModelState.IsValid)
            {
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(winkelMand);
        }

        // GET: WinkelMand/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var winkelMand = await _context.WinkelManden.FindAsync(id);
            if (winkelMand == null)
            {
                return NotFound();
            }
            return View(winkelMand);
        }

        // POST: WinkelMand/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WinkelMandId,KlantId,SmartphoneId,OrderId,TotaalPrijs,BestelDatum")] WinkelMand winkelMand)
        {
            if (id != winkelMand.WinkelMandId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(winkelMand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WinkelMandExists(winkelMand.WinkelMandId))
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
            return View(winkelMand);
        }

        // GET: WinkelMand/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var winkelMand = await _context.WinkelManden
                .FirstOrDefaultAsync(m => m.WinkelMandId == id);
            if (winkelMand == null)
            {
                return NotFound();
            }

            return View(winkelMand);
        }

        // POST: WinkelMand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var winkelMand = await _context.WinkelManden.FindAsync(id);
            _context.WinkelManden.Remove(winkelMand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WinkelMandExists(int id)
        {
            return _context.WinkelManden.Any(e => e.WinkelMandId == id);
        }
    }
}
