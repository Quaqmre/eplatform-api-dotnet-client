using System;
using System.Collections.Generic;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArsivInvoiceGetModel
    {
        public bool IsInternetSale { get; set; }
        public int EMailStatus { get; set; }
        public bool SendEmail { get; set; }
        public int SendType { get; set; }
    }
}