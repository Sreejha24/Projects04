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
    public class JobDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobDatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JobDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobData.ToListAsync());
        }

        // GET: JobDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobData = await _context.JobData
                .FirstOrDefaultAsync(m => m.Auto_Id == id);
            if (jobData == null)
            {
                return NotFound();
            }

            return View(jobData);
        }

        // GET: JobDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Job_Id,Role,Specification,Qualification,Passyear,Skills,Expected_Salary,Auto_Id")] JobData jobData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobData);
        }

        // GET: JobDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobData = await _context.JobData.FindAsync(id);
            if (jobData == null)
            {
                return NotFound();
            }
            return View(jobData);
        }

        // POST: JobDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Job_Id,Role,Specification,Qualification,Passyear,Skills,Expected_Salary,Auto_Id")] JobData jobData)
        {
            if (id != jobData.Auto_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobDataExists(jobData.Auto_Id))
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
            return View(jobData);
        }

        // GET: JobDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobData = await _context.JobData
                .FirstOrDefaultAsync(m => m.Auto_Id == id);
            if (jobData == null)
            {
                return NotFound();
            }

            return View(jobData);
        }

        // POST: JobDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var jobData = await _context.JobData.FindAsync(id);
            _context.JobData.Remove(jobData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobDataExists(int? id)
        {
            return _context.JobData.Any(e => e.Auto_Id == id);
        }
    }
}
