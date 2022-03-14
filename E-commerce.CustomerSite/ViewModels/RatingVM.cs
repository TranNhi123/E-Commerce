using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.CustomerSite.ViewModels{
    public class RatingVM{
        public int ID_Rating{get;set;}
        public string? noi_dung{get;set;}
        public int so_sao{get;set;}
        public bool tinh_trang{get;set;}
         public int RatingMedicineId { get; set; }
        public MedicineVM? Medicine { get; set; }
        public int RatingCustomerId { get; set; }
        public CustomerVM? CustomerRating { get; set; }

    }
}