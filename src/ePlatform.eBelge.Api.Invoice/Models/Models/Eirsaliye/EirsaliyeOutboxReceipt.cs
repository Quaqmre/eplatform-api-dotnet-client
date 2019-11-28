using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EIrsaliye_OutboxReceipt")]
    public partial class EirsaliyeOutboxReceipt
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EnvelopeId { get; set; }
        public Guid InboxDespatchId { get; set; }
        [StringLength(16)]
        public string ReceiptNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        public int Status { get; set; }
        public int? ProfileId { get; set; }
        public int? TypeCode { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        [StringLength(2000)]
        public string Message { get; set; }
        [StringLength(100)]
        public string ObjectStorageKey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SentDate { get; set; }
        [StringLength(3)]
        public string Prefix { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("EnvelopeId")]
        [InverseProperty("EirsaliyeOutboxReceipt")]
        public EfaturaOutboxEnvelope Envelope { get; set; }
    }
}
