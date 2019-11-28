using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class ImportedFileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid CustomerId { get; set; }
        public string ObjectStorageId { get; set; }
        public int DocumentType { get; set; }
        public int Type { get; set; }
        public bool? Status { get; set; }
        public decimal? Size { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
