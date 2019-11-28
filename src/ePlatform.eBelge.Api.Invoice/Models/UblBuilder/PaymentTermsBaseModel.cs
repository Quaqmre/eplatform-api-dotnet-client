using System;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class PaymentTermsBaseModel
    {
        public Decimal? Amount { get; set; }
        public string Note { get; set; }
        public Decimal? PenaltySurchargePercent { get; set; }
    }
}