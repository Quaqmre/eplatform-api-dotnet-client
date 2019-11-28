using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EArchiveMReportPostModel
    {
        public Guid ReportId { get; set; }
        public DateTime Period { get; set; }
        public string OKCRegistrationNumber { get; set; }
        public decimal SaleTotal { get; set; }
        public decimal VATTotal { get; set; }
        public List<EArchiveMReportTaxModel> TaxList { get; set; }
    }
}