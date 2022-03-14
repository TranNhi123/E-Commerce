using AutoMapper;
using E_commerce.API.Models;
using SharedViewModels.Dto;

namespace E_commerce.API.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()  
        {  
            CreateMap<Medicine, MedicineDto>();
            CreateMap<Classify, ClassifyDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Rating, RatingDto>();
        }  
    }
}