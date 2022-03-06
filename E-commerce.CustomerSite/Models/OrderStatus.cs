using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace E_commerce.CustomerSite.Models
{
    public class OrderStatus
    {
        [Key]
        public int ID_TTDH{get;set;}

        public string? tinh_trang_DH{get;set;}
        public ICollection<Order>? Orders{get;set;}
    }
}