using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EarsivCustomerSettingModel
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int EarsivUserStatus { get; set; }
        public int EarsivArchiveUserStatus { get; set; }
        public DateTime? EarsivStartDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}