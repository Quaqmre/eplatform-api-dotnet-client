using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveMReportDetailModel
    {
        public string OKCRegistrationNumber { get; set; }
        public decimal SaleTotal { get; set; }
        public decimal VATTotal { get; set; }
        public List<EArchiveMReportTaxModel> TaxList { get; set; }
    }
}