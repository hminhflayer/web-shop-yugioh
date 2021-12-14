using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Display(Name = "Nhóm sản phẩm")]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
