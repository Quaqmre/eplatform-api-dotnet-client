using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_InboxEnvelopeRelation")]
    public partial class EfaturaInboxEnvelopeRelation
    {
        public int Id { get; set; }
        public Guid InboxEnvelopeId { get; set; }
        public int InboxEnvelopeRelationType { get; set; }
        public Guid ObjectId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        [ForeignKey("InboxEnvelopeId")]
        [InverseProperty("EfaturaInboxEnvelopeRelation")]
        public EfaturaInboxEnvelope InboxEnvelope { get; set; }
    }
}
