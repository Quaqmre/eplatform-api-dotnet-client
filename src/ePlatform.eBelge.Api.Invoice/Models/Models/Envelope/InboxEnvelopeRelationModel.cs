using System;

namespace ePlatform.eBelge.Api.Models.Models.Envelope
{
    public class InboxEnvelopeRelationModel
    {
        public Guid InboxEnvelopeId { get; set; }
        public int InboxEnvelopeRelationType { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
