using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Họ và tên bị trống!")]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Số điện thoại bị trống!")]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        public int? AddressID { get; set; }
        [Required(ErrorMessage = "Tên đăng nhập bị trống!")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mật khẩu bị trống!")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Mật khẩu tối thiểu 8 kí tự!")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Display(Name = "Quyền hạn")]
        public byte Permission { get; set; }
        [Display(Name = "Địa chỉ")]
        public Address Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
