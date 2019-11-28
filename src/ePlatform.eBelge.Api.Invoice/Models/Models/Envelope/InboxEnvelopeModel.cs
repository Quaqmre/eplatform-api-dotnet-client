using System;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Invoice.Models;
using ePlatform.eBelge.Api.Models.Models.Envelope.Base;

namespace ePlatform.eBelge.Api.Models.Models.Envelope
{
    public class InboxEnvelopeModel : BaseEnvelopeModel
    {
        public string IdString { get; set; }
        public DateTime? EnvelopeCreationDateAndTime { get; set; }

    }
}
