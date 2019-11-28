using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveMReportReportListModel
    {
        public Guid Id { get; set; }
        public DateTime PeriodCoveredStart { get; set; }
        public DateTime PeriodCoveredEnd { get; set; }
        public int Status { get; set; }
        public decimal VATTotal { get; set; }
        public decimal SaleTotal { get; set; }
        public int OKCCount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}