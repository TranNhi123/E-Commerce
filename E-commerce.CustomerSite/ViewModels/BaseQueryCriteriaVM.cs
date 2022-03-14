using SharedViewModels.Enum;

namespace E_commerce.CustomerSite.ViewModels
{
    public class BaseQueryCriteriaVM
    {
        public string Search { get; set; }
        public SortOrderEnum SortOrder { get; set; }
        public string SortColumn { get; set; }
        public int Limit { get; set; } = 9;
        public int Page { get; set; } = 1;
    }
}