using System;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class CustomDocumentReferenceModel
    {
        public string Id { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentType { get; set; }
        public DateTime? IssueDate { get; set; }
    }
}