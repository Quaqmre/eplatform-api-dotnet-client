
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class UploadInvoiceModel
    {
        public bool UseManualInvoiceId { get; set; }
        public bool CheckLocalReferenceId { get; set; }
        public string FileSource { get; set; }
        public string FileName { get; set; }
        public InvoiceAppType AppType { get; set; }
        public EArsivInfoModel EArsivInfo { get; set; }
    }
}