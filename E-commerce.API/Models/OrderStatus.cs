using System.ComponentModel.DataAnnotations;


namespace E_commerce.API.Models
{
    public class OrderStatus
    {
        [Key]
        public int ID_TTDH{get;set;}

        public string? tinh_trang_DH{get;set;}
        public ICollection<Order>? Orders{get;set;}
    }
}