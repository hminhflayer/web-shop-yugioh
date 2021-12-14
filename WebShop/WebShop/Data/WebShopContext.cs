using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Models;

namespace WebShop.Data
{
    public class WebShopContext : IdentityDbContext
    {
        public WebShopContext (DbContextOptions<WebShopContext> options)
            : base(options)
        {
        }


        public DbSet<WebShop.Models.Category> Category { get; set; }

        public DbSet<WebShop.Models.BillDetail> BillDetail { get; set; }

        public DbSet<WebShop.Models.Bill> Bill { get; set; }

        public DbSet<WebShop.Models.Provider> Provider { get; set; }

        public DbSet<WebShop.Models.Product> Product { get; set; }

        public DbSet<WebShop.Models.User> User { get; set; }

    }
}
