using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace E_commerce.API.Models
{
    public class Classify
    {
        [Key]
        public int ID_phan_loai {get;set;}

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string? ten_phan_loai {get; set;}
        public ICollection<ClassificationDetail>? ClassificationDetails { get; set; }
    }
}