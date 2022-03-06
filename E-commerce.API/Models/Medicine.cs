using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace E_commerce.API.Models
{
    public class Medicine
    {
        [Key]
        public int Id_thc {get;set;}

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? ten_thc{get;set;}

        [Required]
        [Column(TypeName ="nvarchar(500)")]
        public string? gioi_thieu {get; set;}

        [Required]
        [Column(TypeName ="nvarchar(1000)")]
        public string? mo_ta {get; set;}

        [Required]
        public int sl_ton {get; set;}

        [Required]
        public int gia_nhap{get; set;}

        [Required]
        public int gia_ban {get; set;}

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? hinh_anh {get;set;}
        public Classify? Classifys {get; set;}

    }
}