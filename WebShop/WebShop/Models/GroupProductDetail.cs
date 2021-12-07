using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class GroupProductDetail
    {
        public int GroupProductDetailID { get; set; }
        [Display(Name = "Nhóm sản phẩm chi tiết")]
        public string GroupProductDetailName { get; set; }
        public int GroupProductID { get; set; }
        [Display(Name = "Nhóm sản phẩm")]
        public GroupProduct GroupProduct { get; set; }
    }
}
