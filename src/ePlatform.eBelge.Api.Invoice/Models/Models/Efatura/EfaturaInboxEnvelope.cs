using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_InboxEnvelope")]
    public partial class EfaturaInboxEnvelope
    {
        public EfaturaInboxEnvelope()
        {
            EfaturaInboxEnvelopeRelation = new HashSet<EfaturaInboxEnvelopeRelation>();
            EfaturaInboxInvoice = new HashSet<EfaturaInboxInvoice>();
            EfaturaOutboxInvoice = new HashSet<EfaturaOutboxInvoice>();
            EirsaliyeOutboxDespatch = new HashSet<EirsaliyeOutboxDespatch>();
        }

        public Guid Id { get; set; }
        [StringLength(36)]
        public string IdString { get; set; }
        public Guid CustomerId { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int PackageType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnvelopeCreationDateAndTime { get; set; }
        public int TargetSystemUserId { get; set; }
        public int FileSize { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        public string Message { get; set; }
        [StringLength(100)]
        public string ObjectStorageKey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("InverseIdNavigation")]
        public EfaturaInboxEnvelope IdNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public EfaturaInboxEnvelope InverseIdNavigation { get; set; }
        [InverseProperty("InboxEnvelope")]
        public ICollection<EfaturaInboxEnvelopeRelation> EfaturaInboxEnvelopeRelation { get; set; }
        [InverseProperty("Envelope")]
        public ICollection<EfaturaInboxInvoice> EfaturaInboxInvoice { get; set; }
        [InverseProperty("ResponseEnvelope")]
        public ICollection<EfaturaOutboxInvoice> EfaturaOutboxInvoice { get; set; }
        [InverseProperty("ReceiptEnvelope")]
        public ICollection<EirsaliyeOutboxDespatch> EirsaliyeOutboxDespatch { get; set; }
    }
}
