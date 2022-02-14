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
    public class Invoice_DetailController : Controller
    {
        private readonly Cake_StoreContext _context;

        public Invoice_DetailController(Cake_StoreContext context)
        {
            _context = context;
        }

        // GET: Admin/Invoice_Detail
        public async Task<IActionResult> Index()
        {
            var cake_StoreContext = _context.Invoice_Detail.Include(i => i.Invoice).Include(i => i.Product);
            return View(await cake_StoreContext.ToListAsync());
        }

        // GET: Admin/Invoice_Detail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice_Detail = await _context.Invoice_Detail
                .Include(i => i.Invoice)
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice_Detail == null)
            {
                return NotFound();
            }

            return View(invoice_Detail);
        }

        // GET: Admin/Invoice_Detail/Create
        public IActionResult Create()
        {
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Product_Detail, "Id", "Id");
            return View();
        }

        // POST: Admin/Invoice_Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,InvoiceId,Quantity,Unit_Price")] Invoice_Detail invoice_Detail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoice_Detail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "Id", "Id", invoice_Detail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Product_Detail, "Id", "Id", invoice_Detail.ProductId);
            return View(invoice_Detail);
        }

        // GET: Admin/Invoice_Detail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice_Detail = await _context.Invoice_Detail.FindAsync(id);
            if (invoice_Detail == null)
            {
                return NotFound();
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "Id", "Id", invoice_Detail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Product_Detail, "Id", "Id", invoice_Detail.ProductId);
            return View(invoice_Detail);
        }

        // POST: Admin/Invoice_Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,InvoiceId,Quantity,Unit_Price")] Invoice_Detail invoice_Detail)
        {
            if (id != invoice_Detail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoice_Detail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Invoice_DetailExists(invoice_Detail.Id))
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
            ViewData["InvoiceId"] = new SelectList(_context.Invoice, "Id", "Id", invoice_Detail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Product_Detail, "Id", "Id", invoice_Detail.ProductId);
            return View(invoice_Detail);
        }

        // GET: Admin/Invoice_Detail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice_Detail = await _context.Invoice_Detail
                .Include(i => i.Invoice)
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice_Detail == null)
            {
                return NotFound();
            }

            return View(invoice_Detail);
        }

        // POST: Admin/Invoice_Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoice_Detail = await _context.Invoice_Detail.FindAsync(id);
            _context.Invoice_Detail.Remove(invoice_Detail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Invoice_DetailExists(int id)
        {
            return _context.Invoice_Detail.Any(e => e.Id == id);
        }
    }
}
