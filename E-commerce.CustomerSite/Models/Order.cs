using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace E_commerce.CustomerSite.Models
{
    public class Order
    {
        [Key]
        public int ID_Order {get;set;}

        [Required]
        public int ID_KH {get;set;}

        [Required]
        public DateTime ngay_dat{get;set;}

        [Required]
        public DateTime ngay_nhan{get;set;}

        [Required]
        public string? ghi_chu{get;set;}

        [Required]
        public int ship{get;set;}

        [Required]
        public int tong{get;set;}

        [Required]
        public int ID_TTDH {get;set;}
        public OrderStatus? OrderStatus{get;set;}
        public Customer? Customers {get;set;}
    }
}