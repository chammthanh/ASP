using Cake_Store.Data;
using Cake_Store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Cake_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly Cake_StoreContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(Cake_StoreContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;

        }

        public async Task<IActionResult> Index()
        {
            var ct = _context.Product_Detail.Include(p => p.Product).Include(p => p.Images).Include(p=>p.Size);
            var danhsach = ct.Include(p => p.Product.ProductType).Take(8);
            //hien thi username tu cookie            
            //if(HttpContext.Request.Cookies.ContainsKey("AccountUsername"))
            //    {
            //    ViewBag.AccountUsername = HttpContext.Request.Cookies["AccountUsername"].ToString();
            //}

            if (HttpContext.Session.Keys.Contains("AccountUsername"))
            {
                ViewBag.AccountUsername = HttpContext.Session.GetString("AccountUsername");
            }
            return View(await danhsach.ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            if (HttpContext.Session.Keys.Contains("AccountUsername"))
            {
                ViewBag.AccountUsername = HttpContext.Session.GetString("AccountUsername");
            }
            return View();
        }
        public IActionResult Account()
        {
            if (HttpContext.Session.Keys.Contains("AccountUsername"))
            {
                ViewBag.AccountUsername = HttpContext.Session.GetString("AccountUsername");
            }

            return View();
        }
        public IActionResult Add(int id)
        {
            //if(HttpContext.Session.Keys.Contains("ProductId"))
            //{
            //    ViewBag.ProductName = HttpContext.Session.GetString("ProductName");
            //    ViewBag.Image = HttpContext.Session.GetString("Image");
            //}

            return Add(id, 1);
        }
        [HttpPost]
        public IActionResult Add(int id, int sl)
        {
            var tensp = _context.Product.FirstOrDefault(p => p.Id == id).ProductName;
            var giasp = _context.Product_Detail.FirstOrDefault(p => p.ProductId == id).Product_Price;
            var img =_context.Product_Detail.Include(p=>p.Images).FirstOrDefault(p=>p.ProductId ==id).Images.Images;
            var size = _context.Product_Detail.Include(p => p.Size).FirstOrDefault(p => p.ProductId == id).Size.Size;

            var cart = HttpContext.Session.GetString("cart");
            if (cart == null)
            {

                List<Cart> carts = new List<Cart>()
                {
                    new Cart
                    {
                        ID = id,
                        Image = img,
                        Size = size,
                        price = giasp,
                        soluong = 1,
                        name = tensp

                    }
                };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(carts));
            }
            else
            {
                List<Cart> dta = JsonConvert.DeserializeObject<List<Cart>>(cart);
                bool check = true;
                for(int i = 0; i<dta.Count; i++)
                {
                    if(dta[i].ID == id)
                    {
                        dta[i].soluong++;
                        check = false;
                    }    
                }
                if(check)
                {
                    dta.Add(new Cart
                    {
                        ID = id,
                        Image = img,
                        Size =size,
                        price = giasp,
                        soluong = 1,
                        name = tensp
                    });
                }    
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dta));
            }
            //if (!HttpContext.Session.Keys.Contains("AccountUsername"))
            //{
            //    return RedirectToAction("Signin", "Accounts");
            //}
            //if (HttpContext.Session.Keys.Contains("ProductId"))
            //{
            //    ViewBag.Soluong += sl;
            //}
            //else
            //{
            //    var tensp = _context.Product.FirstOrDefault(p => p.Id == id).ProductName;
            //    var giasp = _context.Product_Detail.FirstOrDefault(p => p.ProductId == id).Product_Price;
            //    var img =_context.Product_Detail.Include(p=>p.Images).FirstOrDefault(p=>p.ProductId ==id).Images.Images;
            //    HttpContext.Session.SetInt32("ProductId", id);
            //    HttpContext.Session.SetString("ProductName", tensp);
            //    HttpContext.Session.SetInt32("Product_Price", giasp);
            //    HttpContext.Session.SetString("Image", img);
            //    ViewBag.ProductName = HttpContext.Session.GetString("ProductName");
            //    ViewBag.ProductPrice = HttpContext.Session.GetInt32("Product_Price");
            //    ViewBag.Image = HttpContext.Session.GetString("Image");
            //    ViewBag.Soluong = 1;
            //    ViewBag.tong = ViewBag.ProductPrice * ViewBag.Soluong;
            //    ViewBag.tongtien += ViewBag.tong;

            //}
            return RedirectToAction("Cart", "Home");
        }
        public IActionResult Cart()
        {
            if (!HttpContext.Session.Keys.Contains("AccountUsername"))
            {
                return RedirectToAction("Signin", "Accounts");
            }
            else
            {
                ViewBag.AccountUsername = HttpContext.Session.GetString("AccountUsername");
            }
            var cart = HttpContext.Session.GetString("cart");
            if(cart != null)
            {
                List<Cart> carts = JsonConvert.DeserializeObject<List<Cart>>(cart);
                ViewBag.Cart = carts;
            }    
            
            return View();
        }
        
        public IActionResult Contact()
        {
            if (HttpContext.Session.Keys.Contains("AccountUsername"))
            {
                ViewBag.AccountUsername = HttpContext.Session.GetString("AccountUsername");
            }
            return View();
        }
        public async Task<IActionResult> Shop()
        {
            if (HttpContext.Session.Keys.Contains("AccountUsername"))
            {
                ViewBag.AccountUsername = HttpContext.Session.GetString("AccountUsername");
            }
            var ct = _context.Product_Detail.Include(p => p.Product).Include(p => p.Images).Include(p=>p.Size);
            var danhsach = ct.Include(p => p.Product.ProductType);
            return View(await danhsach.ToListAsync());
        }
        public IActionResult Signin()
        { 
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Single()
        {
            if (HttpContext.Session.Keys.Contains("AccountUsername"))
            {
                ViewBag.AccountUsername = HttpContext.Session.GetString("AccountUsername");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
