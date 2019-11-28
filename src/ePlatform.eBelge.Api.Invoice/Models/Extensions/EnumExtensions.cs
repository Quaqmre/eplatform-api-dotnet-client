using System.Linq;

namespace ePlatform.eBelge.Api.Models.Models
{
    public static class EnumExtensions
    {
        public static string ToEnumDisplayText(this object item)
        {
            var type = item.GetType();
            var member = type.GetMember(item.ToString());
            if (member != null && member.Length > 0)
            {
                var displayName = (EnumTextAttribute)member[0].GetCustomAttributes(typeof(EnumTextAttribute), false).FirstOrDefault();
                if (displayName != null)
                {
                    return displayName.DisplayText;
                }
            }
            return item.ToString();
        }
    }
}