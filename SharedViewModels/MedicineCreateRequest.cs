using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using SharedViewModels.Enum;

namespace SharedViewModels
{
    public class MedicineCreateRequest
    {
        [Required]
        public string ten_thc { get; set; }
        public BrandTypeEnum Type { get; set; }
    }
}