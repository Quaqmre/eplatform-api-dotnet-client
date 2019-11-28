using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EIrsaliye_OutboxDespatch")]
    public partial class EirsaliyeOutboxDespatch
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EnvelopeId { get; set; }
        [StringLength(16)]
        public string DespatchNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        public int Status { get; set; }
        public int? ProfileId { get; set; }
        public int? TypeCode { get; set; }
        [StringLength(500)]
        public string TargetTitle { get; set; }
        [StringLength(11)]
        public string TargetVknTckn { get; set; }
        [StringLength(150)]
        public string TargetAlias { get; set; }
        public Guid? ReceiptEnvelopeId { get; set; }
        [Column("ReceiptUUID")]
        public Guid? ReceiptUuid { get; set; }
        public bool? ReceiptIsApproved { get; set; }
        [StringLength(150)]
        public string LocalReferenceId { get; set; }
        public bool IsArchived { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        [StringLength(2000)]
        public string Message { get; set; }
        [StringLength(100)]
        public string ObjectStorageKey { get; set; }
        public decimal TotalAmount { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SentDate { get; set; }
        [StringLength(3)]
        public string Prefix { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("EnvelopeId")]
        [InverseProperty("EirsaliyeOutboxDespatch")]
        public EfaturaOutboxEnvelope Envelope { get; set; }
        [ForeignKey("ReceiptEnvelopeId")]
        [InverseProperty("EirsaliyeOutboxDespatch")]
        public EfaturaInboxEnvelope ReceiptEnvelope { get; set; }
    }
}
