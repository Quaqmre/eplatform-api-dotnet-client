using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class InvoiceGetStatisticsModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CustomerId { get; set; }
    }
}