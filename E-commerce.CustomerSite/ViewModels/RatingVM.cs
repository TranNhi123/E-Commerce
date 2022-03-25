using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.CustomerSite.ViewModels{
    public class RatingVM{
        public int ID_Rating{get;set;}
        public string? noi_dung{get;set;}
        public int so_sao{get;set;}
        public bool tinh_trang{get;set;}
         public int Id_thc { get; set; }
        public int ID_KH { get; set; }

    }
}