using System;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class StatisticsResponseModel
    {
        public int AppType { get; set; }
        public int Status { get; set; }
        public string StatusDescription
        {
            get
            {
                return ((InvoiceStatus)this.Status).ToEnumDisplayText();
            }
        }
        public long Count { get; set; }
        public decimal SumAmount { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}