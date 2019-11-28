using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class ExcelAttribute : Attribute
    {
        public ExcelAttribute()
        {
            DisplayOrder = 0;
        }
        public string ColumnName { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsEnum { get; set; }
    }
}