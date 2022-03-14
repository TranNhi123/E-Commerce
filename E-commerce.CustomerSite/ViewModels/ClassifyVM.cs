namespace E_commerce.CustomerSite.ViewModels
{
    public class ClassifyVM
    {
        public int ID_phan_loai {get;set;}

        public string? ten_phan_loai {get; set;}
        public IEnumerable<MedicineVM>? Medicines { get; set; }
    }
}