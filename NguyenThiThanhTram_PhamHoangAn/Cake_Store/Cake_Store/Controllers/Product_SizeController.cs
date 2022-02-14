using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cake_Store.Data;
using Cake_Store.Models;

namespace Cake_Store.Controllers
{
    public class Product_SizeController : Controller
    {
        private readonly Cake_StoreContext _context;

        public Product_SizeController(Cake_StoreContext context)
        {
            _context = context;
        }

        // GET: Product_Size
        public async Task<IActionResult> Index(String input)
        {
            if(!String.IsNullOrEmpty(input))
            {
                return View(_context.Product_Size.Where(s => s.Id.ToString() == input || s.Size.ToString().Contains(input)));
            }    
            return View(await _context.Product_Size.ToListAsync());
        }

        // GET: Product_Size/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Size = await _context.Product_Size
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Size == null)
            {
                return NotFound();
            }

            return View(product_Size);
        }

        // GET: Product_Size/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product_Size/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Size")] Product_Size product_Size)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product_Size);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product_Size);
        }

        // GET: Product_Size/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Size = await _context.Product_Size.FindAsync(id);
            if (product_Size == null)
            {
                return NotFound();
            }
            return View(product_Size);
        }

        // POST: Product_Size/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Size")] Product_Size product_Size)
        {
            if (id != product_Size.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product_Size);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_SizeExists(product_Size.Id))
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
            return View(product_Size);
        }

        // GET: Product_Size/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Size = await _context.Product_Size
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Size == null)
            {
                return NotFound();
            }

            return View(product_Size);
        }

        // POST: Product_Size/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product_Size = await _context.Product_Size.FindAsync(id);
            _context.Product_Size.Remove(product_Size);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product_SizeExists(int id)
        {
            return _context.Product_Size.Any(e => e.Id == id);
        }
    }
}
