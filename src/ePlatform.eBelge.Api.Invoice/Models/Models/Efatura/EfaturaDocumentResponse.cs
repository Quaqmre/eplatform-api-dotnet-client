using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_DocumentResponse")]
    public partial class EfaturaDocumentResponse
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid InvoiceId { get; set; }
        public Guid? EnvelopeId { get; set; }
        public int Status { get; set; }
        public int ResponseStatus { get; set; }
        [StringLength(500)]
        public string Reason { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        public string Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        [ForeignKey("EnvelopeId")]
        [InverseProperty("EfaturaDocumentResponse")]
        public EfaturaOutboxEnvelope Envelope { get; set; }
    }
}
