using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveReportPartModel
    {
        public Guid Id { get; set; }
        public int PartIndex { get; set; }
        public DateTime PartCoveredStart { get; set; }
        public DateTime PartCoveredEnd { get; set; }
        public int Status { get; set; }
    }
}