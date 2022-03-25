using E_commerce.CustomerSite.ViewModels;
using E_commerce.CustomerSite.Models;

namespace E_commerce.CustomerSite.Services
{
    public interface IRatingService
    {
         Task<Medicine> PostRatingAsync(Rating ratingVM);
    }
}