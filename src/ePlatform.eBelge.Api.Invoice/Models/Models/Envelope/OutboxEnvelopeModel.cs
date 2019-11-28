using System;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Invoice.Models;
using ePlatform.eBelge.Api.Models.Models.Envelope.Base;

namespace ePlatform.eBelge.Api.Models.Models.Envelope
{
    public class OutboxEnvelopeModel : BaseEnvelopeModel
    {
        [NotMapped]
        public int InvoiceCount { get; set; }
    }
}
