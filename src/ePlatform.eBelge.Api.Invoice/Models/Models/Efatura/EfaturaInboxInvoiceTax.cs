using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_InboxInvoiceTax")]
    public partial class EfaturaInboxInvoiceTax
    {
        public Guid Id { get; set; }
        public Guid InvoiceId { get; set; }
        public int InvoiceTaxType { get; set; }
        public decimal Assessment { get; set; }
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        public decimal Amount { get; set; }
        public int Rate { get; set; }

        [ForeignKey("InvoiceId")]
        [InverseProperty("EfaturaInboxInvoiceTax")]
        public EfaturaInboxInvoice Invoice { get; set; }
    }
}
