using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class GroupProduct
    {
        public int GroupProductID { get; set; }
        [Display(Name = "Nhóm sản phẩm")]
        public string GroupProductName { get; set; }
        public ICollection<GroupProductDetail> GroupProductDetails { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
