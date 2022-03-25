using Microsoft.AspNetCore.Mvc;
using E_commerce.CustomerSite.Services;
using E_commerce.CustomerSite.Models;
using System.Threading.Tasks;

namespace E_commerce.CustomerSite.ViewComponents
{
    public class MedicineByClassifyViewComponent : ViewComponent
    {
        private readonly IMedicineService _medicineService;
        public MedicineByClassifyViewComponent(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int ID_phan_loai)
        {
            var medicines = await _medicineService.GetMedicinebyClassifyAsync(ID_phan_loai);
            return View(medicines);
        }
    }
}