using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EfaturaDataModel
    {
        public long Id { get; set; }
        public Guid CustomerId { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
    }
}