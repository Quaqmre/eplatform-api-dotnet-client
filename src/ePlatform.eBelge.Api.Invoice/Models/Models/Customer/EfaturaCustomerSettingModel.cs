using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EfaturaCustomerSettingModel
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int EfaturaUserStatus { get; set; }
        public int ArsivUserStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}