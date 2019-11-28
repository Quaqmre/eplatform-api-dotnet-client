using System;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class OutboxInvoiceTaxModel
    {
        public Guid Id { get; set; }
        public Guid InvoiceId { get; set; }
        public int InvoiceTaxType { get; set; }
        public decimal Assessment { get; set; }
        public string Code { get; set; }
        public decimal Amount { get; set; }
        public int Rate { get; set; }

        [NotMapped]
        public InvoiceTaxType InvoiceTaxTypeEnum
        {
            get
            {
                return (InvoiceTaxType)this.InvoiceTaxType;
            }
            set
            {
                this.InvoiceTaxType = Convert.ToInt32(value);
            }
        }
    }
}