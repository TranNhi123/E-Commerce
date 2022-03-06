using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using E_commerce.CustomerSite.Models;

namespace E_commerce.CustomerSite.Services
{
    public class MedicineService : IMedicineService
    {
        public async Task<List<Medicine>> GetMedicinesAsync()
        {
            using (var client = new HttpClient())
            {
                var endPoint = "https://localhost:7165/api/Medicines";
                var json = await client.GetStringAsync(endPoint);
                return JsonConvert.DeserializeObject<List<Medicine>>(json);
            }
        }
        public async Task<Medicine> GetMedicineAsync(int id)
        {
            using (var client = new HttpClient())
            {
                var endPoint = $"https://localhost:7165/api/Medicines/{id}";
                var json = await client.GetStringAsync(endPoint);
                return JsonConvert.DeserializeObject<Medicine>(json);
            }
        }
    }
}