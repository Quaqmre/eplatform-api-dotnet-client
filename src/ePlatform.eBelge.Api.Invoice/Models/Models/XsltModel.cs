using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class XsltModel
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public string Data { get; set; }
        public DateTime IssueDate { get; set; }
    }
}