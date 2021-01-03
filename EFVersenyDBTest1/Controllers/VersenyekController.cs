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
    public class VersenyekController : Controller
    {
        private readonly VersenyContext _context;

        public VersenyekController(VersenyContext context)
        {
            _context = context;
        }

        // GET: Versenies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Versenyek.ToListAsync());
        }


        public async Task<IActionResult> Meccsek(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var verseny = await _context.Versenyek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (verseny == null)
            {
                return NotFound();
            }

            var resztvevok = _context.Resztvevok.Where(x => x.VersenyId == id && x.Statusz.Contains("Jelentkezett")).ToList();
            List<Profil> regisztraltak = new List<Profil>();
            foreach (var resztvevo in resztvevok)
            {
                regisztraltak.Add(_context.Profilok.FirstOrDefault(x => x.Id == resztvevo.ProfilId));
            }
            List<Meccs> meccsek =  MeccsekGeneralasa(resztvevok, verseny);



            return View();
        }

        private List<Meccs> MeccsekGeneralasa(List<Resztvevo> resztvevok, Verseny verseny)
        {
            var output = new List<Meccs>();
            for (int i = 0; i < resztvevok.Count; i++)
            {
                output.Add(new Meccs() { BestOf = 3, Verseny = verseny });
            }

            for (int i = 0; i < Math.Round((float)resztvevok.Count/2); i++)
            {

            }


            return output;
        }

        // GET: Versenies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verseny = await _context.Versenyek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (verseny == null)
            {
                return NotFound();
            }

            var resztvevok = _context.Resztvevok.Where(x => x.VersenyId == id).ToList();
            List<Profil> regisztraltak = new List<Profil>();
            foreach (var resztvevo in resztvevok)
            {
                regisztraltak.Add(_context.Profilok.FirstOrDefault(x => x.Id == resztvevo.ProfilId));
            }
            ViewData["resztvevok"] = regisztraltak;

            return View(verseny);
        }

        // GET: Versenies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Versenies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KezdesIdeje,Nev,Szabalyzat,JatekMod,Statusz")] Verseny verseny)
        {
            if (ModelState.IsValid)
            {
                _context.Add(verseny);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(verseny);
        }

        // GET: Versenies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verseny = await _context.Versenyek.FindAsync(id);
            if (verseny == null)
            {
                return NotFound();
            }
            return View(verseny);
        }

        // POST: Versenies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KezdesIdeje,Nev,Szabalyzat,JatekMod,Statusz")] Verseny verseny)
        {
            if (id != verseny.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(verseny);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VersenyExists(verseny.Id))
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
            return View(verseny);
        }

        // GET: Versenies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verseny = await _context.Versenyek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (verseny == null)
            {
                return NotFound();
            }

            return View(verseny);
        }

        // POST: Versenies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var verseny = await _context.Versenyek.FindAsync(id);
            _context.Versenyek.Remove(verseny);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VersenyExists(int id)
        {
            return _context.Versenyek.Any(e => e.Id == id);
        }
    }
}
