using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models;
using WebShop.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {

        private readonly WebShopContext _context;
        public HomeController(WebShopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.GroupProduct = _context.GroupProduct.ToList();
            return View(await _context.Product.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("UserID,FullName,Email,Phone,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                var exits = await _context.User
                .FirstOrDefaultAsync(m => m.UserName == user.UserName);
                if(exits != null)
                {
                    return RedirectToAction(nameof(Register));
                }    
                Address address = new Address
                {
                    AddressID = user.UserID,
                    ProvinceID = 1,
                    AddressDetail = "An Giang"
                };
                _context.Add(address);
                await _context.SaveChangesAsync();

                user.AddressID = address.AddressID;
                user.Permission = 1;
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["AddressID"] = new SelectList(_context.Address, "AddressID", "AddressID", user.AddressID);
            return View(user);
        }


        public IActionResult Login()
        {
            if (TempData["Error"] != null)
            {
                if (TempData["Error"].ToString() != "")
                {
                    ViewBag.Error = TempData["Error"].ToString();
                }
            }

            return View();
        }

        //Users/Login
        public async Task<IActionResult> ActionLogin(string? UserName, string? Password)
        {
            var user = await _context.User
                .FirstOrDefaultAsync(m => m.UserName == UserName);

            var pass = await _context.User
                .FirstOrDefaultAsync(m => m.Password == Password);
            if (user == null || pass == null)
            {
                TempData["Error"] = "Tên đăng nhập hoặc mật khẩu không đúng!";
                return RedirectToAction(nameof(Login));
            }

            string input = Libs.SHA1.ComputeHash(UserName + Password);
            var session = HttpContext.Session;
            session.SetString("logining", input);

            return RedirectToAction(nameof(Index));
        }
    }
}
