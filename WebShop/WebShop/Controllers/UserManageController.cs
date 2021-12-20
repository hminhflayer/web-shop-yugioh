using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class UserManageController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public UserManageController(RoleManager<IdentityRole> roleManager,
                                    UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IQueryable<User> Search(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var users = _userManager.Users.Where(s => s.FullName.Contains(searchString)
                                       || s.Email.Contains(searchString)
                                       || s.PhoneNumber.Contains(searchString));

                return users;
            }

            return _userManager.Users;
        }
        // GET: UserManage
        [HttpGet]
        public ActionResult Index(string? searchString)
        {
            var user = Search(searchString);
            return View(user);
        }

        // GET: UserManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserManage/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserManage/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserManage/Delete/5
        [HttpPost, ActionName("DeleteUser")]
        public async Task<IActionResult> DeleteUser(string? id)
        {
            if(!string.IsNullOrEmpty(id))
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                    return View("NotFound");
                }    
                else
                {
                    var result = await _userManager.DeleteAsync(user);
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    return RedirectToAction("Index");
                }    
            }

            return RedirectToAction("Index");
        }

        // POST: UserManage/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
