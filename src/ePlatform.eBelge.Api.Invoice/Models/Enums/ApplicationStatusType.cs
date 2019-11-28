using System.ComponentModel;

namespace ePlatform.eFatura.Models
{
    public enum ApplicationStatusType
    {
        [Description("Aktif")]
        Active = 1,
        [Description("Pasif")]
        Passive = 2,
        [Description("Beklemede")]
        Waiting = 3
    }
}