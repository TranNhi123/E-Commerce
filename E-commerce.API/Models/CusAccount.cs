using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace E_commerce.API.Models
{
    public class CusAccount
    {
        [Key]
        public int ID_TKKH{get;set;}

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? tai_khoan_KH{get;set;}

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? mat_khau {get;set;}
        public int ID_KH{get;set;}
        public Customer? Customers{get;set;}
    }
}