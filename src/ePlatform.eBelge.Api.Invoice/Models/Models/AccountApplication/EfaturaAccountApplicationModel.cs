using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EfaturaAccountApplicationModel
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public long? CustomerApplicationId { get; set; }
        public int ApplicationType { get; set; }
        public bool IsCreateOperation { get; set; }
        public int ApplicationStatus { get; set; }
        public string Oskey { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public int TryCount { get; set; }
        public DateTime? LastTryDate { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
    }
}