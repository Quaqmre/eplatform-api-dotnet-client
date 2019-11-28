using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models.Envelope
{
    public class OutboxEnvelopeRelationModel
    {
        public Guid OutboxEnvelopeId { get; set; }
        public int OutboxEnvelopeRelationType { get; set; }
        public Guid ObjectId { get; set; }
    }
}
