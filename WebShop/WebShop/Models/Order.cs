using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        [Display(Name = "Ngày đặt hàng")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        [Display(Name = "Tổng tiền")]
        public int TotalMoney { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Người dùng")]
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
