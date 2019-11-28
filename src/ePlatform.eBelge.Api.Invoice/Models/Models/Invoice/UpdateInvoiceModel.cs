using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class UpdateInvoiceModel
    {
        public Guid[] Ids { get; set; }
        public bool IsArchived { get; set; }
        public Enums.InvoiceStatus Status { get; set; }

    }
}