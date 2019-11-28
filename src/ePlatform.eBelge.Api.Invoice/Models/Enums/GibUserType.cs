using System.ComponentModel;

namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum GibUserType
    {
        [Description("Özel")]
        PublicCorp = 1,
        [Description("Kamu")]
        PrivateCorp = 2
    }
}