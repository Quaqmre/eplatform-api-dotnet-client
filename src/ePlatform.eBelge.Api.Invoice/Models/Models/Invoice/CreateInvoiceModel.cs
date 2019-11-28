using System.ComponentModel.DataAnnotations;
using ePlatform.UBLBuilder.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class CreateInvoiceModel
    {
        [Required(ErrorMessage = "InvoiceZip alanı boş bırakılamaz.")]
        public string InvoiceZip { get; set; }
        public int Status { get; set; }
        public string LocalReferenceId { get; set; }
        public string Prefix { get; set; }
        public bool UseManualInvoiceId { get; set; }
        public bool? CheckLocalReferenceId { get; set; }
        public string TargetAlias { get; set; }
        public string XsltCode { get; set; }

        public int AppType { get; set; }
        public EArsivInfoModel EArsivInfo { get; set; }
    }
}