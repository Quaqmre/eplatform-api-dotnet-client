using System.ComponentModel;

namespace ePlatform.eFatura.Models
{
    public enum CustomerStatusType
    {
        [Description("Aktif")]
        Active = 1,
        [Description("Askıda")]
        Suspend = 2
    }
}