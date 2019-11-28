using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_InvoiceCanceled")]
    public partial class EarsivInvoiceCanceled
    {
        public Guid Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime CanceledDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("EarsivInvoiceCanceled")]
        public EfaturaOutboxInvoice Id1 { get; set; }
        [ForeignKey("Id")]
        [InverseProperty("EarsivInvoiceCanceled")]
        public EarsivInvoice IdNavigation { get; set; }
    }
}
