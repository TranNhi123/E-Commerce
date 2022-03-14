namespace SharedViewModels.Dto
{
    public class ClassifyDto
    {
        public int ID_phan_loai {get;set;}

        public string? ten_phan_loai {get; set;}

        public ICollection<MedicineDto>? Medicines { get; set; }
    }
}