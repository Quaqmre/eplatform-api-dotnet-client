using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_OutboxEnvelopeRelation")]
    public partial class EfaturaOutboxEnvelopeRelation
    {
        public int Id { get; set; }
        public Guid OutboxEnvelopeId { get; set; }
        public int OutboxEnvelopeRelationType { get; set; }
        public Guid ObjectId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        [ForeignKey("OutboxEnvelopeId")]
        [InverseProperty("EfaturaOutboxEnvelopeRelation")]
        public EfaturaOutboxEnvelope OutboxEnvelope { get; set; }
    }
}
