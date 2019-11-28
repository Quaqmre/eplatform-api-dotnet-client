using System.Collections.Generic;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class CacheStaticListModel
    {
        public List<CurrencyModel> CurrencyList { get; set; }
        public List<TaxExemptionReasonModel> TaxExemptionReasonList { get; set; }
        public List<UnitCodeModel> UnitCodelist { get; set; }
        public List<WithHoldingCodeModel> WithHoldingCodeList { get; set; }
    }
}