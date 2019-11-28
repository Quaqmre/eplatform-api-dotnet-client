using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_InboxInvoice")]
    public partial class EfaturaInboxInvoice
    {
        public EfaturaInboxInvoice()
        {
            EfaturaInboxInvoiceTax = new HashSet<EfaturaInboxInvoiceTax>();
        }

        public Guid Id { get; set; }
        [StringLength(36)]
        public string IdString { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EnvelopeId { get; set; }
        [Required]
        [StringLength(20)]
        public string InvoiceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExecutionDate { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int TipType { get; set; }
        public int LineNumber { get; set; }
        [Required]
        [StringLength(500)]
        public string TargetTitle { get; set; }
        [Required]
        [StringLength(11)]
        public string TargetVknTckn { get; set; }
        [Required]
        [StringLength(150)]
        public string TargetAlias { get; set; }
        public bool IsNew { get; set; }
        public bool IsRead { get; set; }
        public bool IsArchived { get; set; }
        public bool IsVerified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SigningDate { get; set; }
        [Column(TypeName = "ntext")]
        public string VerificationResult { get; set; }
        public bool IsAgentNew { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PayableAmount { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        public decimal? TaxTotal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        [ForeignKey("EnvelopeId")]
        [InverseProperty("EfaturaInboxInvoice")]
        public EfaturaInboxEnvelope Envelope { get; set; }
        [InverseProperty("Invoice")]
        public ICollection<EfaturaInboxInvoiceTax> EfaturaInboxInvoiceTax { get; set; }
    }
}
