using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFVersenyDataAccessTest.DataAccess;
using EFVersenyDataAccessTest.Models;

namespace EFVersenyDBTest1.Views
{
    public class ProfilokController : Controller
    {
        private readonly VersenyContext _context;

        public ProfilokController(VersenyContext context)
        {
            _context = context;
        }

        // GET: Profilok
        public async Task<IActionResult> Index()
        {
            return View(await _context.Profilok.ToListAsync());
        }

        // GET: Profilok/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profil = await _context.Profilok
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profil == null)
            {
                return NotFound();
            }

            //profil.JatekosNevek = _context.Profilok.FirstOrDefault(x=>x.Id==id).JatekosNevek;
            profil.JatekosNevek = _context.JatekosNevek.Where(x => x.Profil == profil).ToList();
            var resztvesz = _context.Resztvevok.Where(x => x.ProfilId == id);
            ViewData["versenyek"] = resztvesz.Select(x => x.Verseny.Nev).ToList();

            return View(profil);
        }

        // GET: Profilok/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profilok/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProfilNev,SzuletesiIdo,RegisztracioIdeje,Nem,VezetekNev,KeresztNev,EmailCim")] Profil profil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profil);
        }

        // GET: Profilok/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profil = await _context.Profilok.FindAsync(id);
            if (profil == null)
            {
                return NotFound();
            }
            return View(profil);
        }

        // POST: Profilok/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilNev,SzuletesiIdo,RegisztracioIdeje,Nem,VezetekNev,KeresztNev,EmailCim")] Profil profil)
        {
            if (id != profil.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfilExists(profil.Id))
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
            return View(profil);
        }

        // GET: Profilok/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profil = await _context.Profilok
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profil == null)
            {
                return NotFound();
            }

            return View(profil);
        }

        // POST: Profilok/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profil = await _context.Profilok.FindAsync(id);
            _context.Profilok.Remove(profil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfilExists(int id)
        {
            return _context.Profilok.Any(e => e.Id == id);
        }
    }
}
