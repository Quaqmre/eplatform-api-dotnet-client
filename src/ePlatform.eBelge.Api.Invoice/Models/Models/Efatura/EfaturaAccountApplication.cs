using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_AccountApplication")]
    public partial class EfaturaAccountApplication
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EnvelopeId { get; set; }
        public long? CustomerApplicationId { get; set; }
        public int ApplicationType { get; set; }
        public bool IsCreateOperation { get; set; }
        public int ApplicationStatus { get; set; }
        [Column("OSKey")]
        [StringLength(100)]
        public string Oskey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApplicationDate { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        public string Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }

        [ForeignKey("EnvelopeId")]
        [InverseProperty("EfaturaAccountApplication")]
        public EfaturaOutboxEnvelope Envelope { get; set; }
    }
}
