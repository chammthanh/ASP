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
    public class Product_DetailController : Controller
    {
        private readonly Cake_StoreContext _context;

        public Product_DetailController(Cake_StoreContext context)
        {
            _context = context;
        }

        // GET: Product_Detail
        public async Task<IActionResult> Index(string input)
        {
            var cake_StoreContext = _context.Product_Detail.Include(p => p.Images).Include(p => p.Product).Include(p => p.Size);
            if (!String.IsNullOrEmpty(input))
            {
                return View(cake_StoreContext.Where(pd => pd.Id.ToString()==input|| pd.Size.Size.ToString() == input || pd.ProductId.ToString() == input ||
                pd.Date_Create.ToString().Contains(input) || pd.Quantity.ToString() == input || pd.Product_Price.ToString() == input ||
                pd.Make_Date.ToString().Contains(input)||pd.Date_Expired.ToString().Contains(input)||pd.Images.Images.Contains(input)));
            }    
            return View(await cake_StoreContext.ToListAsync());
        }

        // GET: Product_Detail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Detail = await _context.Product_Detail
                .Include(p => p.Images)
                .Include(p => p.Product)
                .Include(p => p.Size)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Detail == null)
            {
                return NotFound();
            }

            return View(product_Detail);
        }

        // GET: Product_Detail/Create
        public IActionResult Create()
        {
            ViewData["ImagesId"] = new SelectList(_context.Image, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id");
            ViewData["SizeId"] = new SelectList(_context.Set<Product_Size>(), "Id", "Id");
            return View();
        }

        // POST: Product_Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SizeId,ProductId,Date_Create,Quantity,Product_Price,Make_Date,Date_Expired,ImagesId")] Product_Detail product_Detail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product_Detail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ImagesId"] = new SelectList(_context.Image, "Id", "Id", product_Detail.ImagesId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", product_Detail.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Set<Product_Size>(), "Id", "Id", product_Detail.SizeId);
            return View(product_Detail);
        }

        // GET: Product_Detail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Detail = await _context.Product_Detail.FindAsync(id);
            if (product_Detail == null)
            {
                return NotFound();
            }
            ViewData["ImagesId"] = new SelectList(_context.Image, "Id", "Id", product_Detail.ImagesId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", product_Detail.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Set<Product_Size>(), "Id", "Id", product_Detail.SizeId);
            return View(product_Detail);
        }

        // POST: Product_Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SizeId,ProductId,Date_Create,Quantity,Product_Price,Make_Date,Date_Expired,ImagesId")] Product_Detail product_Detail)
        {
            if (id != product_Detail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product_Detail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_DetailExists(product_Detail.Id))
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
            ViewData["ImagesId"] = new SelectList(_context.Image, "Id", "Id", product_Detail.ImagesId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", product_Detail.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Set<Product_Size>(), "Id", "Id", product_Detail.SizeId);
            return View(product_Detail);
        }

        // GET: Product_Detail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Detail = await _context.Product_Detail
                .Include(p => p.Images)
                .Include(p => p.Product)
                .Include(p => p.Size)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Detail == null)
            {
                return NotFound();
            }

            return View(product_Detail);
        }

        // POST: Product_Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product_Detail = await _context.Product_Detail.FindAsync(id);
            _context.Product_Detail.Remove(product_Detail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product_DetailExists(int id)
        {
            return _context.Product_Detail.Any(e => e.Id == id);
        }
       
    }
}
