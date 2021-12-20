﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public enum Status
    {
        CONFIRM,
        SEND, 
        TRANSPORT,
        RECEIVED,
        CANCEL
    }
    public class Bill
    {
        public int BillId { get; set; }
        public string UserID { get; set; }
        [Display(Name = "Ngày đặt hàng")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        [Display(Name = "Tổng tiền")]
        public int TotalMoney { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Tên người nhận")]
        public string FullName { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Trạng thái")]
        public Status StatusBill { get; set; }
        [Display(Name = "Tài khoản")]
        public User User { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
    }
}
