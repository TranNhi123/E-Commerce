using System.ComponentModel.DataAnnotations;


namespace E_commerce.API.Models
{
    public class Rating
    {
        [Key]
        public int ID_Rating{get;set;}
        public int ID_KH{get;set;}
        public int Id_thc{get;set;}
        public string? noi_dung{get;set;}

        [Required]
        public int so_sao{get;set;}
        public bool tinh_trang{get;set;} = true;
        
    }
}