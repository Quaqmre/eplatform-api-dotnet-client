using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_OutboxEnvelope")]
    public partial class EfaturaOutboxEnvelope
    {
        public EfaturaOutboxEnvelope()
        {
            EfaturaAccountApplication = new HashSet<EfaturaAccountApplication>();
            EfaturaDocumentResponse = new HashSet<EfaturaDocumentResponse>();
            EfaturaOutboxEnvelopeRelation = new HashSet<EfaturaOutboxEnvelopeRelation>();
            EfaturaOutboxInvoice = new HashSet<EfaturaOutboxInvoice>();
            EirsaliyeOutboxDespatch = new HashSet<EirsaliyeOutboxDespatch>();
            EirsaliyeOutboxReceipt = new HashSet<EirsaliyeOutboxReceipt>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int PackageType { get; set; }
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

        [InverseProperty("Envelope")]
        public ICollection<EfaturaAccountApplication> EfaturaAccountApplication { get; set; }
        [InverseProperty("Envelope")]
        public ICollection<EfaturaDocumentResponse> EfaturaDocumentResponse { get; set; }
        [InverseProperty("OutboxEnvelope")]
        public ICollection<EfaturaOutboxEnvelopeRelation> EfaturaOutboxEnvelopeRelation { get; set; }
        [InverseProperty("Envelope")]
        public ICollection<EfaturaOutboxInvoice> EfaturaOutboxInvoice { get; set; }
        [InverseProperty("Envelope")]
        public ICollection<EirsaliyeOutboxDespatch> EirsaliyeOutboxDespatch { get; set; }
        [InverseProperty("Envelope")]
        public ICollection<EirsaliyeOutboxReceipt> EirsaliyeOutboxReceipt { get; set; }
    }
}
