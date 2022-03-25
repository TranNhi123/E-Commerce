using AutoMapper;
using E_commerce.CustomerSite.Models;
using E_commerce.CustomerSite.ViewModels;
using SharedViewModels.Dto;
using E_commerce.CustomerSite.Services;

namespace E_commerce.CustomerSite.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()  
        {  
            CreateMap<Medicine, MedicineVM>();
            CreateMap<Classify, ClassifyVM>();
            CreateMap<Customer, CustomerVM>();
            CreateMap<Rating, RatingVM>();
            CreateMap<RatingVM, Rating>();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();  
            CreateMap<PagedModelDto<Medicine>, PagedResponseVM<MedicineVM>>();
        }  
    }
}