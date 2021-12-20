using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm bị trống!")]
        [Display(Name = "Tên Sản Phẩm")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Số lượng bị trống!")]
        [Display(Name = "Số lượng")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        [Required(ErrorMessage = "Giá bị trống!")]
        [Display(Name = "Giá")]
        public int Price { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
        [Display(Name = "Mô tả sản phẩm")]
        public string Description { get; set; }
        [Display(Name = "Nhập khẩu")]
        public int ProviderID { get; set; }
        [Display(Name = "Nhập khẩu")]
        public Provider Provider { get; set; }
        [Display(Name = "Loại sản phẩm")]
        public int CategoryId { get; set; }
        [Display(Name = "Loại sản phẩm")]
        public Category Category { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
