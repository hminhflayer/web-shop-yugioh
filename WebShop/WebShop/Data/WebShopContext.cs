using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebShop.Models;

namespace WebShop.Data
{
    public class WebShopContext : DbContext
    {
        public WebShopContext (DbContextOptions<WebShopContext> options)
            : base(options)
        {
        }

        public DbSet<WebShop.Models.Province> Province { get; set; }

        public DbSet<WebShop.Models.GroupProductDetail> GroupProductDetail { get; set; }

        public DbSet<WebShop.Models.GroupProduct> GroupProduct { get; set; }

        public DbSet<WebShop.Models.OrderDetail> OrderDetail { get; set; }

        public DbSet<WebShop.Models.Order> Order { get; set; }

        public DbSet<WebShop.Models.Provider> Provider { get; set; }

        public DbSet<WebShop.Models.Product> Product { get; set; }

        public DbSet<WebShop.Models.Address> Address { get; set; }

        public DbSet<WebShop.Models.User> User { get; set; }

        public DbSet<WebShop.Models.CartDetail> CartDetail { get; set; }

        public DbSet<WebShop.Models.Cart> Cart { get; set; }
    }
}
