using System.ComponentModel;

namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum GibAliasType
    {
        [Description("Posta Kutusu")]
        Recipient = 1,
        [Description("Gönderen Birim")]
        Sender = 2
    }
}