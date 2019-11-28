using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_ReportInvoice")]
    public partial class EarsivReportInvoice
    {
        public Guid ReportId { get; set; }
        public Guid InvoiceId { get; set; }
        public int Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("InvoiceId")]
        [InverseProperty("EarsivReportInvoice")]
        public EarsivInvoice Invoice { get; set; }
        [ForeignKey("ReportId")]
        [InverseProperty("EarsivReportInvoice")]
        public EarsivReport Report { get; set; }
    }
}
