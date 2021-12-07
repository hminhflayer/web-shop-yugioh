using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Province
    {
        public int ProvinceID { get; set; }
        [Required(ErrorMessage = "Tỉnh bị trống!")]
        [Display(Name = "Tỉnh")]
        public string ProvinceName { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
