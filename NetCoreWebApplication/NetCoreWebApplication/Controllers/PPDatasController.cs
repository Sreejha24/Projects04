using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreWebApplication.Data;
using NetCoreWebApplication.Models;

namespace NetCoreWebApplication.Controllers
{
    public class PPDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PPDatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PPDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.PPData.ToListAsync());
        }

        // GET: PPDatas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pPData = await _context.PPData
                .FirstOrDefaultAsync(m => m.Person_Id == id);
            if (pPData == null)
            {
                return NotFound();
            }

            return View(pPData);
        }

        // GET: PPDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PPDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Person_Id,Name,Person_Date,Mobile_Number,Year,Qualification,Auto_Id,Location,Gender")] PPData pPData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pPData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pPData);
        }

        // GET: PPDatas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pPData = await _context.PPData.FindAsync(id);
            if (pPData == null)
            {
                return NotFound();
            }
            return View(pPData);
        }

        // POST: PPDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Person_Id,Name,Person_Date,Mobile_Number,Year,Qualification,Auto_Id,Location,Gender")] PPData pPData)
        {
            if (id != pPData.Person_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pPData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PPDataExists(pPData.Person_Id))
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
            return View(pPData);
        }

        // GET: PPDatas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pPData = await _context.PPData
                .FirstOrDefaultAsync(m => m.Person_Id == id);
            if (pPData == null)
            {
                return NotFound();
            }

            return View(pPData);
        }

        // POST: PPDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pPData = await _context.PPData.FindAsync(id);
            _context.PPData.Remove(pPData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PPDataExists(string id)
        {
            return _context.PPData.Any(e => e.Person_Id == id);
        }
    }
}
