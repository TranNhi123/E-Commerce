using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using E_commerce.CustomerSite.Models;

namespace E_commerce.CustomerSite.Services
{
    public class ClassifyService : IClassifyService
    {
        public async Task<List<Classify>> GetClassifysAsync()
        {
            using (var client = new HttpClient())
            {
                var endPoint = "https://localhost:7165/api/Classifies";
                var json = await client.GetStringAsync(endPoint);
                return JsonConvert.DeserializeObject<List<Classify>>(json);
            }
        }
    }
}