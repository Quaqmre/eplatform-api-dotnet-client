using System;

namespace ePlatform.eBelge.Api.Models.Models
{

    [AttributeUsage(AttributeTargets.Field)]
    public class EnumTextAttribute : Attribute
    {
        public string DisplayText { get; set; }

        public EnumTextAttribute(string displayText)
        {
            this.DisplayText = displayText;
        }
    }
}