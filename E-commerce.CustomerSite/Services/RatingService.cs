using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using E_commerce.CustomerSite.ViewModels;
using E_commerce.CustomerSite.Models;

namespace E_commerce.CustomerSite.Services
{
    public class RatingService : IRatingService
    {
        public async Task<Medicine> PostRatingAsync(Rating ratingVM)
        {
            using (var client = new HttpClient())
            {
                
                var formData = new MultipartFormDataContent();
                formData.Add(new StringContent(ratingVM.ID_KH.ToString()), "ID_KH");
                formData.Add(new StringContent(ratingVM.Id_thc.ToString()), "Id_thc");
                formData.Add(new StringContent(ratingVM.noi_dung), "noi_dung");
                formData.Add(new StringContent(ratingVM.so_sao.ToString()), "so_sao");

                var endPoint = "https://localhost:7165/api/Ratings";
                var response = await client.PostAsync(endPoint, formData);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Medicine>(json);
            }
        }
    }
}