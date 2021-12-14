using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Họ và tên bị trống!")]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime BirthDay { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
