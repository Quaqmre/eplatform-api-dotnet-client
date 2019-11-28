using System;
using System.Globalization;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArsivReportStatusModel
    {
        public Guid Id { get; set; }
        public Guid CustomerUniqueId { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string CustomerNo { get; set; }
        public int CustomerStatus { get; set; }
        public int? ReportStatus { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime? ReportStartDate { get; set; }
        public DateTime? ReportEndDate { get; set; }
    }
}