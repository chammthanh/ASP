using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cake_Store.Data;
using Cake_Store.Models;

namespace Cake_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Product_TypeController : Controller
    {
        private readonly Cake_StoreContext _context;

        public Product_TypeController(Cake_StoreContext context)
        {
            _context = context;
        }

        // GET: Admin/Product_Type
        public async Task<IActionResult> Index(String input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                return View(_context.Product_Type.Where(t => t.Id.ToString() == input || t.Type.Contains(input)));
            }
            return View(await _context.Product_Type.ToListAsync());
        }

        // GET: Admin/Product_Type/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Type = await _context.Product_Type
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Type == null)
            {
                return NotFound();
            }

            return View(product_Type);
        }

        // GET: Admin/Product_Type/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Product_Type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type")] Product_Type product_Type)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product_Type);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product_Type);
        }

        // GET: Admin/Product_Type/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Type = await _context.Product_Type.FindAsync(id);
            if (product_Type == null)
            {
                return NotFound();
            }
            return View(product_Type);
        }

        // POST: Admin/Product_Type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type")] Product_Type product_Type)
        {
            if (id != product_Type.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product_Type);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_TypeExists(product_Type.Id))
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
            return View(product_Type);
        }

        // GET: Admin/Product_Type/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Type = await _context.Product_Type
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Type == null)
            {
                return NotFound();
            }

            return View(product_Type);
        }

        // POST: Admin/Product_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product_Type = await _context.Product_Type.FindAsync(id);
            _context.Product_Type.Remove(product_Type);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product_TypeExists(int id)
        {
            return _context.Product_Type.Any(e => e.Id == id);
        }
    }
}
