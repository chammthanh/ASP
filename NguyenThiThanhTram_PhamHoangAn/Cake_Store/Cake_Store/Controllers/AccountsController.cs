
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cake_Store.Data;
using Cake_Store.Models;
using Microsoft.AspNetCore.Http;

namespace Cake_Store.Controllers
{
    public class AccountsController : Controller
    {
        private readonly Cake_StoreContext _context;

        public AccountsController(Cake_StoreContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index(string input)
        {
            List<Account> accounts = _context.Account.ToList();
            if (!String.IsNullOrEmpty(input))
            {
                return View(accounts.Where(acc =>acc.Id.ToString() ==input|| acc.Username.Contains(input) || acc.Email.Contains(input) || acc.Password.Contains(input) || acc.Birthday.ToString().Contains(input)));
            }

            return View(await _context.Account.ToListAsync());
        }
        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signin2(string Username, string Password)
        {
            bool result = _context.Account.Where(a => a.Username == Username && a.Password == Password).Count() > 0;
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "dang nhap that bai";
                return View();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Signin(string Username, string Password)
        {
            Account account = _context.Account.Where(a => a.Username == Username && a.Password == Password).FirstOrDefault();
            if (account != null)
            {
                //Tao Cookie
                //CookieOptions cookieOptions = new CookieOptions()
                //{
                //    Expires = DateTime.Now.AddDays(7)
                //};

                //    HttpContext.Response.Cookies.Append("AccountID", account.Id.ToString(), cookieOptions);
                //    HttpContext.Response.Cookies.Append("AccountUsername", account.Username.ToString(), cookieOptions);
                //    return RedirectToAction("Index", "Home");

                //Tao session
                if (account.Status == 1)
                {
                    HttpContext.Session.SetInt32("AccountID", account.Id);
                    HttpContext.Session.SetString("AccountUsername", account.Username);

                    //return RedirectToAction("Index", "Admin");
                    return RedirectToAction("Index", "Admin", new { area = "Admin" });
                }
                else
                {
                    HttpContext.Session.SetInt32("AccountID", account.Id);
                    HttpContext.Session.SetString("AccountUsername", account.Username);
                    return RedirectToAction("Index","Home");
                }

            }
            else
            {
                ViewBag.ErrorMessage = "Đăng Nhập Thất Bại";
                return View();
            }
        }
        public IActionResult Logout()
        {
            //Hủy session
            //hủy toàn bộ sesion
            //HttpContext.Session.Clear();
            HttpContext.Session.Remove("AccountID");
            HttpContext.Session.Remove("AccountUsername");
            //HttpContext.Response.Cookies.Append("AccountID", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            //HttpContext.Response.Cookies.Append("AccountUsername", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            return RedirectToAction("Index", "Home", new { area = "default" });
        }
       
        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Email,Password,Birthday,Gender,Status")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Email,Password,Birthday,Gender,Status")] Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
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
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Account.FindAsync(id);
            _context.Account.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.Id == id);
        }
    }
}


