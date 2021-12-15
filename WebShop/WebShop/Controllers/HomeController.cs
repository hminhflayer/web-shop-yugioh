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
using Microsoft.AspNetCore.Authorization;
using WebShop.Libs;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {

        private readonly WebShopContext _context;

        public HomeController(WebShopContext context)
        {
            _context = context;
        }

        public IQueryable<Product> Search(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var products = _context.Product.Where(s => s.ProductName.Contains(searchString)
                                       || s.Provider.ProviderName.Contains(searchString));

                return products;
            }

            return _context.Product;
        }

        public IQueryable<Product> Sort(string sortOrder, IQueryable<Product> products)
        {
            //Sort product
            var nameSort = String.IsNullOrEmpty(sortOrder) ? "Name" : "name_desc";
            var priceSort = sortOrder == "Price" ? "Price" : "price_desc";

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(s => s.ProductName);
                    break;
                case "Price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.ProductName);
                    break;
            }

            return products;
        }

        public async Task<IActionResult> Index(int? id, string? searchString, string? sortOrder)
        {
            if(SupportClass.Category == null)
            {
                SupportClass.Category = _context.Category.ToList();
            }    
            //Search product
            var products = Search(searchString);
            products = Sort(sortOrder, products);

            if (id == null)
            {
                ViewBag.Home = "Tất cả sản phẩm";
                return View(await products.ToListAsync());
            }

            products = products.Where(p => p.CategoryId == id);
            ViewBag.Home = "Sản phẩm " + _context.Category.Find(id).CategoryName;
            if (products.ToList() == null || products.ToList().Count() == 0)
            {
                return View();
            }

            return View(await products.ToListAsync());
        }

        public IActionResult Cart()
        {
            return View(GetCarts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Cart> GetCarts()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("cart");
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<Cart>>(jsoncart);
            }

            return new List<Cart>();
        }

        void SaveCartSession(List<Cart> lst)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(lst);
            session.SetString("cart", jsoncart);
        }

        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove("cart");
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound("Sản phẩm không tồn tại");
            }

            var cart = GetCarts();
            var cartitem = cart.Find(p => p.Product.ProductID == id);
            if (cartitem != null)
            {
                cartitem.Quantity++;
            }
            else
            {
                cart.Add(new Cart() { Quantity = 1, Product = product });
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        public IActionResult RemoveItem(int id)
        {
            var cart = GetCarts();
            var cartitem = cart.Find(p => p.Product.ProductID == id);
            if (cartitem != null)
            {
                cart.Remove(cartitem);
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        public IActionResult UpdateItem(int id, int quantity)
        {
            var cart = GetCarts();
            var cartitem = cart.Find(p => p.Product.ProductID == id);
            if (cartitem != null)
            {
                cartitem.Quantity = quantity;
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(cart));
        }

        public async Task<IActionResult> DetailProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Provider)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }

}
