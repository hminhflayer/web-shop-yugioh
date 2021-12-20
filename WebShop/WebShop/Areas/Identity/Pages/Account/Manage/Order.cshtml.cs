using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShop.Data;
using WebShop.Libs;
using WebShop.Models;

namespace WebShop.Areas.Identity.Pages.Account.Manage
{
    public class OrderModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly WebShopContext _context;

        public OrderModel(WebShopContext context,
                          UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public void OnGet()
        {
            SupportClass.Bill = _context.Bill.Where(b => b.UserID == _userManager.GetUserId(User)).ToList();
        }
    }
}
