using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EirsaliyeCustomerSettingModel
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int EirsaliyeUserStatus { get; set; }
        public int EirsaliyeArsivStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}