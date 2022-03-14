using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using E_commerce.CustomerSite.Models;
using SharedViewModels.Constants;

namespace E_commerce.CustomerSite.ViewModels
{
    public class CustomerVM
    {
        public int ID_KH {get; set;}
        public string? ten_KH  {get; set;}

        public int SDT {get;set;}
        public string? Email {get;set;}

        public string? dia_chi{get;set;}

        public DateTime ngay_sinh {get;set;}
    }
}