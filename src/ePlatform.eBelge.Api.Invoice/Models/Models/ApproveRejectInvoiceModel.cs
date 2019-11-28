using System;
using System.ComponentModel.DataAnnotations;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class ApproveRejectInvoiceModel
    {
        public Guid InvoiceId { get; set; }
        public int Status { get; set; }
        public string Reason { get; set; }
    }
}