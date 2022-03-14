using Microsoft.AspNetCore.Mvc;
using E_commerce.CustomerSite.Services;
using E_commerce.CustomerSite.Models;
using System.Threading.Tasks;

namespace E_commerce.CustomerSite.ViewComponents
{
    public class MedicinePDViewComponent: ViewComponent
    {
    //    
    private readonly IMedicineService _medicineService;
        public MedicinePDViewComponent(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var medicine = await _medicineService.GetMedicineAsync(id);
            return View(medicine);
        }
    }
}