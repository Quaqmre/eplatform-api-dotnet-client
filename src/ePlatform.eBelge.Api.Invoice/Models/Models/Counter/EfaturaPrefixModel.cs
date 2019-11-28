using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EfaturaPrefixModel
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int Type { get; set; }
        public string Prefix { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}