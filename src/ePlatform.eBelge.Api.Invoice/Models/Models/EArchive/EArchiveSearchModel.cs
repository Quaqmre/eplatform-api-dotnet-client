using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveSearchModel
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string FilterQuery { get; set; }
        public string SortedColumn { get; set; }
        public bool IsDesc { get; set; }
        public int? Status { get; set; }
        public int? PackageType { get; set; }
        public int? Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? Id { get; set; }
        public Guid? CustomerId { get; set; }
    }
}