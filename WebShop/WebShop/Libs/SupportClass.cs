using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebShop.Models;

namespace WebShop.Libs
{
    public static class SupportClass
    {
        public static string Timestamp()
        {
            return DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
        }

        public static List<Category> Category { get; set; }

    }
}
