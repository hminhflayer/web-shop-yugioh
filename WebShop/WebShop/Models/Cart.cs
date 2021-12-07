using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public int QuantityProduct { get; set; }
        public User User { get; set; }
        public ICollection<CartDetail> CartDetails { get; set; }
    }
}
