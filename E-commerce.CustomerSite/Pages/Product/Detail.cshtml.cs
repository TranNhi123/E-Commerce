using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_commerce.CustomerSite.Services;
using E_commerce.CustomerSite.ViewModels;
using E_commerce.CustomerSite.Models;
using SharedViewModels.Dto;
using Newtonsoft.Json;
using AutoMapper;

namespace E_commerce.CustomerSite.Pages.Product
{
    public class ProductDetailModel : PageModel
    {

        private readonly IMedicineService _medicineService;
        private readonly IRatingService _ratingService;
         private readonly IMapper _mapper;
        public ProductDetailModel(IMedicineService medicineService, IMapper mapper, IRatingService ratingService)
        {
            _medicineService = medicineService;
            _mapper = mapper;
            _ratingService = ratingService;
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

        [BindProperty(SupportsGet = true)]
        public string hinh_anh { get; set; }

        

        public async Task OnGetAsync(int id)
        {
            Id_thc = id;
            var medicine = await _medicineService.GetMedicineAsync(id);
            ten_thc = medicine.ten_thc;
            gioi_thieu = medicine.gioi_thieu;
            mo_ta = medicine.mo_ta;
            gia_ban = medicine.gia_ban;
            hinh_anh = medicine.hinh_anh;
            
        }

         public async Task OnGetRatingAsync(int number, int Id_thc)
        {
            var ratingVM = new RatingVM {
                    Id_thc = Id_thc,
                    ID_KH = 1,
                    so_sao = number,
                    noi_dung =""
                };
            Console.WriteLine(JsonConvert.SerializeObject(ratingVM));
            var rating = _mapper.Map<Rating>(ratingVM);
            await _ratingService.PostRatingAsync(rating);
            await OnGetAsync(Id_thc);
        }
    }
}