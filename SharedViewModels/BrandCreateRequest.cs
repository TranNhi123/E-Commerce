using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using SharedViewModels.Enum;

namespace SharedViewModels
{
    public class BrandCreateRequest
    {
        [Required]
        public string Name { get; set; }
        public BrandTypeEnum Type { get; set; }
    }
}