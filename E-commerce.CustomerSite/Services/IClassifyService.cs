using System.Collections.Generic;
using System.Threading.Tasks;
using E_commerce.CustomerSite.Models;

namespace E_commerce.CustomerSite.Services
{
    public interface IClassifyService
    {
        Task<List<Classify>> GetClassifysAsync();
        // Task<Classify> GetClassifyAsync(int id);
         
        
    }
}