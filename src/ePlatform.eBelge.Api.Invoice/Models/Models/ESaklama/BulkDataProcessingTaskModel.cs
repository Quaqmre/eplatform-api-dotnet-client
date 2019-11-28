using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class BulkDataProcessingTaskModel
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public int ProgressType { get; set; }
        public int? AppMachineId { get; set; }
        public int TaskStatus { get; set; }
        public string Message { get; set; }
        public int TryCount { get; set; }
        public string ImportedFileKey { get; set; }
        public string GeneratedFileKey { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
