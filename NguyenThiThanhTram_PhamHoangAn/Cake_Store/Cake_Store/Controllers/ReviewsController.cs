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
    public class ReviewsController : Controller
    {
        private readonly Cake_StoreContext _context;

        public ReviewsController(Cake_StoreContext context)
        {
            _context = context;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            var cake_StoreContext = _context.Review.Include(r => r.Customer).Include(r => r.Images).Include(r => r.Product);
            return View(await cake_StoreContext.ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(char? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Customer)
                .Include(r => r.Images)
                .Include(r => r.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Account, "Id", "Id");
            ViewData["ImagesId"] = new SelectList(_context.Image, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,ImagesId,Rate,ProductId,CustomerId,Date_Create,Delete_Flag")] Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Account, "Id", "Id", review.CustomerId);
            ViewData["ImagesId"] = new SelectList(_context.Image, "Id", "Id", review.ImagesId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", review.ProductId);
            return View(review);
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(char? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Account, "Id", "Id", review.CustomerId);
            ViewData["ImagesId"] = new SelectList(_context.Image, "Id", "Id", review.ImagesId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", review.ProductId);
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(char id, [Bind("Id,Description,ImagesId,Rate,ProductId,CustomerId,Date_Create,Delete_Flag")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Account, "Id", "Id", review.CustomerId);
            ViewData["ImagesId"] = new SelectList(_context.Image, "Id", "Id", review.ImagesId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", review.ProductId);
            return View(review);
        }

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(char? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Customer)
                .Include(r => r.Images)
                .Include(r => r.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(char id)
        {
            var review = await _context.Review.FindAsync(id);
            _context.Review.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(char id)
        {
            return _context.Review.Any(e => e.Id == id);
        }
    }
}
