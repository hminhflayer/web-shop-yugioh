using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Provider
    {
        public int ProviderID { get; set; }
        [Required(ErrorMessage = "Nơi nhập khẩu bị trống!")]
        [Display(Name = "Nơi nhập khẩu")]
        public string ProviderName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
