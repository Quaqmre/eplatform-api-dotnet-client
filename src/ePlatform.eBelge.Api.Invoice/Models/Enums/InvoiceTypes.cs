namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum InvoiceTypes
    {
        [EnumText("Temel")]
        BaseInvoice = 0,
        [EnumText("Ticari")]
        CommercialInvoice = 1,
        [EnumText("İhracat")]
        ExportInvoice = 2,
        [EnumText("Yolcu Beraberinde")]
        PassengerInvoice = 3,
        [EnumText("e-Arşiv")]
        EArchiveInvoice = 4
    }
}
