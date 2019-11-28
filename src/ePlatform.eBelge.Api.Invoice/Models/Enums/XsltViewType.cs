using System.ComponentModel;

namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum XsltViewType
    {
        [Description("Invoice")]
        Invoice = 0,
        [Description("AproveInvoice")]
        AproveInvoice = 1,
        [Description("CancelInvoice")]
        CancelInvoice = 2,
        [Description("EArsivInvoice")]
        EArsivInvoice = 3
    }
}