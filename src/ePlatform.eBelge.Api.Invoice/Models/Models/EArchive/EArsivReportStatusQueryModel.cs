using System;

namespace ePlatform.eBelge.Api.Models.Models.Models
{
    public class EArsivReportStatusQueryModel
    {
        public int? ApplicationStatus { get; set; }
        public DateTime? ReportStartDate { get; set; }
        public DateTime? ReportEndDate { get; set; }
        public int? ReportStatus { get; set; }
        public int? CustomerStatus { get; set; }
    }
}