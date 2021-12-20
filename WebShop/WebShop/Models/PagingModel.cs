using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class PagingModel
    {
        public int currentPage { get; set; }
        public int countpages { get; set; }

        public Func<int?, string> gererateUrl { get; set; }
    }
}
