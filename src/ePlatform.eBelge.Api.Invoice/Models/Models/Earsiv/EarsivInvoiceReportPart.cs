using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_InvoiceReportPart")]
    public partial class EarsivInvoiceReportPart
    {
        public Guid InvoiceId { get; set; }
        public short Type { get; set; }
        public Guid ReportPartId { get; set; }

        [ForeignKey("InvoiceId")]
        [InverseProperty("EarsivInvoiceReportPart")]
        public EarsivInvoice Invoice { get; set; }
        [ForeignKey("ReportPartId")]
        [InverseProperty("EarsivInvoiceReportPart")]
        public EarsivReportPart ReportPart { get; set; }
    }
}
