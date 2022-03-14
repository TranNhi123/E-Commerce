namespace SharedViewModels.Dto
{
    public class MedicineDto
    {
        public int Id_thc {get;set;}
        public string? ten_thc{get;set;}

        public string? gioi_thieu {get; set;}

        public string? mo_ta {get; set;}

        public int sl_ton {get; set;}

        public int gia_nhap{get; set;}

        public int gia_ban {get; set;}

        public string? hinh_anh {get;set;}
        public ClassifyDto? Classifys {get; set;}
    }
}

