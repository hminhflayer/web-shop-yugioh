using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebShop.Data;
using WebShop.Libs;
using WebShop.Models;

namespace WebShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BillDetailsController : Controller
    {
        private readonly WebShopContext _context;

        public BillDetailsController(WebShopContext context)
        {
            _context = context;
        }

        public IQueryable<BillDetail> Search(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var bills = _context.BillDetail.Where(s => s.Product.ProductName.Contains(searchString));

                return bills;
            }

            return _context.BillDetail;
        }

        // GET: BillDetails
        public async Task<IActionResult> Index(string? searchString)
        {
            var billDetails = Search(searchString);
            var webShopContext = billDetails.Include(b => b.Bill).Include(b => b.Product);
            return View(await webShopContext.ToListAsync());
        }

        public async Task<IActionResult> Chart()
        {
            var top10 = _context.BillDetail.OrderByDescending(b => b.Quantity)
                                      .Include(b => b.Product)
                                      .Take(10).ToList();

            var name = new List<string>();
            var value = new List<int>();

            foreach (BillDetail item in top10)
            {
                name.Add(item.Product.ProductName);
                value.Add(item.Quantity);
            }

            SupportClass.NameTop10 = name;
            SupportClass.ValueTop10 = value;
            return View();
        }

        // GET: BillDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billDetail = await _context.BillDetail
                .Include(b => b.Bill)
                .Include(b => b.Product)
                .FirstOrDefaultAsync(m => m.BillDetailId == id);
            if (billDetail == null)
            {
                return NotFound();
            }

            return View(billDetail);
        }
        /*
         *  Not support function in version
         */

        //[Authorize(Roles = "Admin")]
        // GET: BillDetails/Create
        //public IActionResult Create()
        //{
        //    ViewData["BillId"] = new SelectList(_context.Bill, "BillId", "BillId");
        //    ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductName");
        //    return View();
        //}

        //[Authorize(Roles = "Admin")]
        // POST: BillDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("BillDetailId,BillId,ProductID,Money,Quantity,TotalMoney")] BillDetail billDetail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(billDetail);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["BillId"] = new SelectList(_context.Bill, "BillId", "BillId", billDetail.BillId);
        //    ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductName", billDetail.ProductID);
        //    return View(billDetail);
        //}

        //[Authorize(Roles = "Admin")]
        //// GET: BillDetails/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var billDetail = await _context.BillDetail.FindAsync(id);
        //    if (billDetail == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["BillId"] = new SelectList(_context.Bill, "BillId", "BillId", billDetail.BillId);
        //    ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductName", billDetail.ProductID);
        //    return View(billDetail);
        //}

        //[Authorize(Roles = "Admin")]
        //// POST: BillDetails/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("BillDetailId,BillId,ProductID,Money,Quantity,TotalMoney")] BillDetail billDetail)
        //{
        //    if (id != billDetail.BillDetailId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(billDetail);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BillDetailExists(billDetail.BillDetailId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["BillId"] = new SelectList(_context.Bill, "BillId", "BillId", billDetail.BillId);
        //    ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductName", billDetail.ProductID);
        //    return View(billDetail);
        //}

        //[Authorize(Roles = "Admin")]
        // GET: BillDetails/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var billDetail = await _context.BillDetail
        //        .Include(b => b.Bill)
        //        .Include(b => b.Product)
        //        .FirstOrDefaultAsync(m => m.BillDetailId == id);
        //    if (billDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(billDetail);
        //}

        //[Authorize(Roles = "Admin")]
        //// POST: BillDetails/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var billDetail = await _context.BillDetail.FindAsync(id);
        //    _context.BillDetail.Remove(billDetail);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool BillDetailExists(int id)
        //{
        //    return _context.BillDetail.Any(e => e.BillDetailId == id);
        //}
    }
}
