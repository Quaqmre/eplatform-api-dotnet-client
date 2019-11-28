using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class GetInvoiceByDateRangeModel
    {
        public Guid CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsNew { get; set; }
    }
}