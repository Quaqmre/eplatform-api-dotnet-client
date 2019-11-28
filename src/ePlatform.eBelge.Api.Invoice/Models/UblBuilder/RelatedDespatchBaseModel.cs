using System;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class RelatedDespatchBaseModel
    {
        public string DespatchNumber { get; set; }
        public DateTime? IssueDate { get; set; }
    }
}