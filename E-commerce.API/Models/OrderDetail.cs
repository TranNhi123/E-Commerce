using System.ComponentModel.DataAnnotations;

namespace E_commerce.API.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID_Order{get;set;}
        [Key]
        public int ID_thc{get;set;}

        [Required]
        public int so_luong{get;set;}

        [Required]
        public int tong_gia{get;set;}

        public Order? Order {get;set;}
        public Medicine? Medicine {get;set;}

    }
}