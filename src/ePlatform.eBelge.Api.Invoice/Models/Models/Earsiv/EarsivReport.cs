using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_Report")]
    public partial class EarsivReport
    {
        public EarsivReport()
        {
            EarsivMreport = new HashSet<EarsivMreport>();
            EarsivReportInvoice = new HashSet<EarsivReportInvoice>();
            EarsivReportPart = new HashSet<EarsivReportPart>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        [Column(TypeName = "date")]
        public DateTime PeriodCoveredStart { get; set; }
        [Column(TypeName = "date")]
        public DateTime PeriodCoveredEnd { get; set; }
        public int Status { get; set; }
        public bool IsBlank { get; set; }
        public bool IsActive { get; set; }
        public int Progress { get; set; }
        [StringLength(500)]
        public string ProgressPath { get; set; }
        public int TaskStatus { get; set; }
        public string TaskMessage { get; set; }
        public int? AppMachineId { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsAppended { get; set; }
        public byte Type { get; set; }
        [StringLength(2000)]
        public string Message { get; set; }

        [InverseProperty("Report")]
        public ICollection<EarsivMreport> EarsivMreport { get; set; }
        [InverseProperty("Report")]
        public ICollection<EarsivReportInvoice> EarsivReportInvoice { get; set; }
        [InverseProperty("Report")]
        public ICollection<EarsivReportPart> EarsivReportPart { get; set; }
    }
}
