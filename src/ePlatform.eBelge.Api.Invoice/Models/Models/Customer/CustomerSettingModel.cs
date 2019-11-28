using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class CustomerSettingModel
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public bool IsEntegratorSign { get; set; }
        public int? CertificateId { get; set; }
        public string Certificate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}