using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public int UserID { get; set; }
        public int ProvinceID { get; set; }
        [Display(Name = "Địa chỉ chi tiết")]
        public string AddressDetail { get; set; }
        [Display(Name = "Tỉnh")]
        public Province Province { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
