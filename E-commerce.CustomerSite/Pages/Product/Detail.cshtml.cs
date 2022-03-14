using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_commerce.CustomerSite.Services;

namespace E_commerce.CustomerSite.Pages.Product
{
    public class ProductDetailModel : PageModel
    {

        private readonly IMedicineService _medicineService;

        public ProductDetailModel(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [BindProperty(SupportsGet = true)]
        public int Id_thc { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ten_thc { get; set; }

        [BindProperty(SupportsGet = true)]
        public string gioi_thieu { get; set; }

        [BindProperty(SupportsGet = true)]
        public string mo_ta { get; set; }

        [BindProperty(SupportsGet = true)]
        public int gia_ban { get; set; }

        

        public async Task OnGetAsync(int id, int rating)
        {
            Id_thc = id;
            var medicine = await _medicineService.GetMedicineAsync(id);
            ten_thc = medicine.ten_thc;
            gioi_thieu = medicine.gioi_thieu;
            mo_ta = medicine.mo_ta;
            gia_ban = medicine.gia_ban;
            // Get rating later
        }
    }
}