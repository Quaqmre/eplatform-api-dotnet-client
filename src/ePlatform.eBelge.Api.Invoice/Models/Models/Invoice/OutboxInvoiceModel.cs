using System;
using System.Collections.Generic;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class OutboxInvoiceModel : BaseInvoiceModel
    {
        public Guid? ResponseEnvelopeId { get; set; }
        public string LocalReferenceId { get; set; }
        public int TryCount { get; set; }
        public DateTime? LastTryDate { get; set; }
        public string Message { get; set; }
        public string ObjectStorageKey { get; set; }
        public int AppType { get; set; }
        public string Reason { get; set; }
        public string Prefix { get; set; }
        public EarsivInvoiceModel EarsivInvoice { get; set; }
        public List<InvoiceTaxModel> EfaturaOutboxInvoiceTax { get; set; }
        public InvoiceAppType AppTypeEnum
        {
            get
            {
                return (InvoiceAppType)this.AppType;
            }
            set
            {
                this.AppType = Convert.ToInt32(value);
            }
        }
    }
}
