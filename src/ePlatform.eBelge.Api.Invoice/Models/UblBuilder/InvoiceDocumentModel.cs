using System;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class InvoiceDocumentModel
    {
        public string InvoiceId { get; set; }
        public string DocumentId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentBase64 { get; set; }
        public byte[] Bytes { get; set; }
        public string FileName { get; set; }
        public DateTime? DocumentDate { get; set; }
        public bool IsFileExist { get; set; }
        public string DocumentDateInString
        {
            get
            {
                return this.DocumentDate.HasValue ? this.DocumentDate.Value.ToString("dd.MM.yyyy") : string.Empty;
            }
        }
    }
}