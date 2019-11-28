using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_ReportPart")]
    public partial class EarsivReportPart
    {
        public EarsivReportPart()
        {
            EarsivInvoiceReportPart = new HashSet<EarsivInvoiceReportPart>();
        }

        public Guid Id { get; set; }
        public Guid ReportId { get; set; }
        [Column(TypeName = "date")]
        public DateTime PartCoveredStart { get; set; }
        [Column(TypeName = "date")]
        public DateTime PartCoveredEnd { get; set; }
        public int PartIndex { get; set; }
        public int Status { get; set; }
        [Column("ReportPartOSKey")]
        [StringLength(100)]
        public string ReportPartOskey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int InvoiceIndex { get; set; }
        public int InvoiceCanceledIndex { get; set; }
        public byte Type { get; set; }
        [StringLength(2000)]
        public string Message { get; set; }
        public int TryCount { get; set; }

        [ForeignKey("ReportId")]
        [InverseProperty("EarsivReportPart")]
        public EarsivReport Report { get; set; }
        [InverseProperty("ReportPart")]
        public ICollection<EarsivInvoiceReportPart> EarsivInvoiceReportPart { get; set; }
    }
}
