using System.Collections.Generic;
using System.Threading.Tasks;
using E_commerce.CustomerSite.Models;


namespace E_commerce.CustomerSite.Services
{
    public interface IMedicineService
    {
        Task<List<Medicine>> GetMedicinesAsync();
        Task<Medicine> GetMedicineAsync(int id);
        Task<List<Medicine>> GetMedicinebyClassifyAsync(int ID_phan_loai);
    }
}