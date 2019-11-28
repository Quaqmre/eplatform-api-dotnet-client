using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EnvelopeSearchModel
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string FilterQuery { get; set; }
        public string SortedColumn { get; set; }
        public bool IsDesc { get; set; }
        public bool IsGibStatus { get; set; }
        public int? Status { get; set; }
        public int? PackageType { get; set; }
        public int? Type { get; set; }
        public Guid? Id { get; set; }
        public Guid? CustomerId { get; set; }
    }
}