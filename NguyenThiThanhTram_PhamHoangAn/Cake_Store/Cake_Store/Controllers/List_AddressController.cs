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
    public class List_AddressController : Controller
    {
        private readonly Cake_StoreContext _context;

        public List_AddressController(Cake_StoreContext context)
        {
            _context = context;
        }

        // GET: List_Address
        public async Task<IActionResult> Index(String input)
        {
            var cake_StoreContext = _context.List_Address.Include(l => l.Customer);
            if(!String.IsNullOrEmpty(input))
            {
                return View(cake_StoreContext.Where(l => l.CustomerId.ToString() == input || l.NameCustomer.Contains(input) || l.Phone.Contains(input) || l.Address.Contains(input)));
            }    
            return View(await cake_StoreContext.ToListAsync());
        }

        // GET: List_Address/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var list_Address = await _context.List_Address
                .Include(l => l.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (list_Address == null)
            {
                return NotFound();
            }

            return View(list_Address);
        }

        // GET: List_Address/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Account, "Id", "Id");
            return View();
        }

        // POST: List_Address/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerId,NameCustomer,Phone,Address,Status")] List_Address list_Address)
        {
            if (ModelState.IsValid)
            {
                _context.Add(list_Address);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Account, "Id", "Id", list_Address.CustomerId);
            return View(list_Address);
        }

        // GET: List_Address/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var list_Address = await _context.List_Address.FindAsync(id);
            if (list_Address == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Account, "Id", "Id", list_Address.CustomerId);
            return View(list_Address);
        }

        // POST: List_Address/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerId,NameCustomer,Phone,Address,Status")] List_Address list_Address)
        {
            if (id != list_Address.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(list_Address);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!List_AddressExists(list_Address.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Account, "Id", "Id", list_Address.CustomerId);
            return View(list_Address);
        }

        // GET: List_Address/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var list_Address = await _context.List_Address
                .Include(l => l.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (list_Address == null)
            {
                return NotFound();
            }

            return View(list_Address);
        }

        // POST: List_Address/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var list_Address = await _context.List_Address.FindAsync(id);
            _context.List_Address.Remove(list_Address);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool List_AddressExists(int id)
        {
            return _context.List_Address.Any(e => e.Id == id);
        }
    }
}
