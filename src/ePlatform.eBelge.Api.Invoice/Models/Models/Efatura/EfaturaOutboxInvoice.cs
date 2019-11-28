using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_OutboxInvoice")]
    public partial class EfaturaOutboxInvoice
    {
        public EfaturaOutboxInvoice()
        {
            EfaturaOutboxInvoiceTax = new HashSet<EfaturaOutboxInvoiceTax>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EnvelopeId { get; set; }
        [StringLength(16)]
        public string InvoiceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExecutionDate { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int TipType { get; set; }
        public int LineNumber { get; set; }
        [StringLength(500)]
        public string TargetTitle { get; set; }
        [StringLength(11)]
        public string TargetVknTckn { get; set; }
        [StringLength(150)]
        public string TargetAlias { get; set; }
        public Guid? ResponseEnvelopeId { get; set; }
        [StringLength(150)]
        public string LocalReferenceId { get; set; }
        public bool IsArchived { get; set; }
        public bool IsAgentNew { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        public string Message { get; set; }
        [StringLength(100)]
        public string ObjectStorageKey { get; set; }
        public int AppType { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PayableAmount { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        public decimal? TaxTotal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SentDate { get; set; }
        [StringLength(500)]
        public string Reason { get; set; }
        [StringLength(3)]
        public string Prefix { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        [ForeignKey("EnvelopeId")]
        [InverseProperty("EfaturaOutboxInvoice")]
        public EfaturaOutboxEnvelope Envelope { get; set; }
        [ForeignKey("ResponseEnvelopeId")]
        [InverseProperty("EfaturaOutboxInvoice")]
        public EfaturaInboxEnvelope ResponseEnvelope { get; set; }
        [InverseProperty("IdNavigation")]
        public EarsivInvoice EarsivInvoice { get; set; }
        [InverseProperty("Id1")]
        public EarsivInvoiceCanceled EarsivInvoiceCanceled { get; set; }
        [InverseProperty("Invoice")]
        public ICollection<EfaturaOutboxInvoiceTax> EfaturaOutboxInvoiceTax { get; set; }
    }
}
