using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class BillDetail
    {
        public int BillDetailId { get; set; }
        public int BillId { get; set; }
        public int ProductID { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        [Display(Name = "Giá tiền")]
        public int Money { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        [Display(Name = "Tổng tiền")]
        public int TotalMoney { get; set; }
        [Display(Name = "Sản phẩm")]
        public Product Product { get; set; }
        [Display(Name = "Đơn hàng")]
        public Bill Bill { get; set; }
    }
}
