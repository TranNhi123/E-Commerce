using Microsoft.AspNetCore.Mvc;
using E_commerce.CustomerSite.Services;
using System.Threading.Tasks;

namespace E_commerce.CustomerSite.ViewComponents
{
    public class MedicinesViewComponent : ViewComponent
    {
        private IMedicineService _medicineService;
        public MedicinesViewComponent(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var medicines = await _medicineService.GetMedicinesAsync();
            return View(medicines);
        }
        
    }
}