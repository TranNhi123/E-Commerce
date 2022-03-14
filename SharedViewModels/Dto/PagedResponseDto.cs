using System.Collections.Generic;

namespace SharedViewModels.Dto
{
    public class PagedResponseDto<TModel> : BaseQueryCriteriaDto
    {
        public int CurrentPage { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<TModel> Items { get; set; }
    }
}