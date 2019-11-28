using System.ComponentModel;

namespace ePlatform.UBLBuilder.Enums
{
    public enum InvoiceProfileType
    {
        [Description("Temel")]
        TEMELFATURA = 0,
        [Description("Ticari")]
        TICARIFATURA = 1,
        [Description("İhracat")]
        IHRACAT = 2,
        [Description("Yolcu Beraber")]
        YOLCUBERABERFATURA = 3,
        [Description("E-Arşiv")]
        EARSIVFATURA = 4,
        [Description("Kağıt")]
        KAGIT = 5
    }
}