using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebShop.Data;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class GroupProductDetailsController : Controller
    {
        private readonly WebShopContext _context;

        public GroupProductDetailsController(WebShopContext context)
        {
            _context = context;
        }

        // GET: GroupProductDetails
        public async Task<IActionResult> Index()
        {
            var webShopContext = _context.GroupProductDetail.Include(g => g.GroupProduct);
            return View(await webShopContext.ToListAsync());
        }

        // GET: GroupProductDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProductDetail = await _context.GroupProductDetail
                .Include(g => g.GroupProduct)
                .FirstOrDefaultAsync(m => m.GroupProductDetailID == id);
            if (groupProductDetail == null)
            {
                return NotFound();
            }

            return View(groupProductDetail);
        }

        // GET: GroupProductDetails/Create
        public IActionResult Create()
        {
            ViewData["GroupProductID"] = new SelectList(_context.Set<GroupProduct>(), "GroupProductID", "GroupProductID");
            return View();
        }

        // POST: GroupProductDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupProductDetailID,GroupProductDetailName,GroupProductID")] GroupProductDetail groupProductDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupProductDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupProductID"] = new SelectList(_context.Set<GroupProduct>(), "GroupProductID", "GroupProductID", groupProductDetail.GroupProductID);
            return View(groupProductDetail);
        }

        // GET: GroupProductDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProductDetail = await _context.GroupProductDetail.FindAsync(id);
            if (groupProductDetail == null)
            {
                return NotFound();
            }
            ViewData["GroupProductID"] = new SelectList(_context.Set<GroupProduct>(), "GroupProductID", "GroupProductID", groupProductDetail.GroupProductID);
            return View(groupProductDetail);
        }

        // POST: GroupProductDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupProductDetailID,GroupProductDetailName,GroupProductID")] GroupProductDetail groupProductDetail)
        {
            if (id != groupProductDetail.GroupProductDetailID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupProductDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupProductDetailExists(groupProductDetail.GroupProductDetailID))
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
            ViewData["GroupProductID"] = new SelectList(_context.Set<GroupProduct>(), "GroupProductID", "GroupProductID", groupProductDetail.GroupProductID);
            return View(groupProductDetail);
        }

        // GET: GroupProductDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupProductDetail = await _context.GroupProductDetail
                .Include(g => g.GroupProduct)
                .FirstOrDefaultAsync(m => m.GroupProductDetailID == id);
            if (groupProductDetail == null)
            {
                return NotFound();
            }

            return View(groupProductDetail);
        }

        // POST: GroupProductDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupProductDetail = await _context.GroupProductDetail.FindAsync(id);
            _context.GroupProductDetail.Remove(groupProductDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupProductDetailExists(int id)
        {
            return _context.GroupProductDetail.Any(e => e.GroupProductDetailID == id);
        }
    }
}
