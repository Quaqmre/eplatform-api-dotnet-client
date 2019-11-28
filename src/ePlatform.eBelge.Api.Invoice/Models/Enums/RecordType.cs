using System.ComponentModel;

namespace ePlatform.eBelge.Api.Invoice.Models.Enums
{
    public enum RecordType
    {
        [Description("e-Arşiv")]
        Archive = 0,
        [Description("e-Fatura")]
        Invoice = 1
    }
}