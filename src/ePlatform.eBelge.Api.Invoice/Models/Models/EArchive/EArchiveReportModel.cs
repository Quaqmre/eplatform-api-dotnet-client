using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveReportModel
    {
        public Guid Id { get; set; }
        public DateTime PeriodCoveredStart { get; set; }
        public DateTime PeriodCoveredEnd { get; set; }
        public byte Type { get; set; }
        public int Status { get; set; }
    }
}