using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class InvoicePdfModel
    {
        public Guid[] Ids { get; set; }
        public bool IsStandartXslt { get; set; }
    }
}