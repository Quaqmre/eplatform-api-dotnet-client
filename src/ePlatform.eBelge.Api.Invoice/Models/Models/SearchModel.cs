using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class SearchModel
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string QueryFilter { get; set; }
        public string FilterQuery { get; set; }
        public string SortedColumn { get; set; }
        public bool IsDesc { get; set; }
        public Guid? CustomerId { get; set; }
    }
}