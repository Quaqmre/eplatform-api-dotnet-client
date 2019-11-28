using System;

namespace ePlatform.eBelge.Api.Invoice.Models.Models
{
    public class ApproveRejectInvoiceModel
    {
        public Guid InvoiceId { get; set; }
        public int Status { get; set; }
        public string Reason { get; set; }
        public int? ResponseStatus { get; set; }
    }
}