namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum DocumentResponseStatus
    {
        [EnumText("Kabul")]
        Approved = 1,
        [EnumText("Red")]
        Declined = 2,
        [EnumText("İade")]
        Return = 3
    }
}