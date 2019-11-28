using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class SorgulaAppGetResponseModel
    {
        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceStatus { get; set; }
        public string Html { get; set; }
        public byte[] File { get; set; }
        public byte[] Pdf { get; set; }
    }
}