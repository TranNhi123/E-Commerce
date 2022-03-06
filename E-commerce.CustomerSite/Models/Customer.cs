using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace E_commerce.CustomerSite.Models
{
    public class Customer
    {
        [Key]
        public int ID_KH {get; set;}

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? ten_KH  {get; set;}

        [Required]
        public int SDT {get;set;}

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? Email {get;set;}

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? dia_chi{get;set;}

        [Required]
        [DataType(DataType.Date)]
        public DateTime ngay_sinh {get;set;}
        public ICollection<CusAccount>? CusAccounts{get;set;}
        public ICollection<Order>? Orders{get;set;}
    }
}