
namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum InvoiceTipType
    {
        [EnumText("Satış")]
        Sale = 1,
        [EnumText("İade")]
        Return = 2,
        [EnumText("İstisna")]
        Istisna = 3,
        [EnumText("Özel Matrah")]
        OzelMatrah = 4,
        [EnumText("Tevkifat")]
        Tevkifat = 5,
        [EnumText("Araç Tescil")]
        AracTescil = 6,
        [EnumText("İhraç Kayıtlı")]
        IhracKayitli = 7,
        [EnumText("SGK")]
        SGK = 8
    }
}