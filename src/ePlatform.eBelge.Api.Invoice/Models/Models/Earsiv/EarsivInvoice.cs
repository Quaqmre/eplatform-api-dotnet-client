using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_Invoice")]
    public partial class EarsivInvoice
    {
        public EarsivInvoice()
        {
            EarsivInvoiceMail = new HashSet<EarsivInvoiceMail>();
            EarsivInvoiceReportPart = new HashSet<EarsivInvoiceReportPart>();
            EarsivReportInvoice = new HashSet<EarsivReportInvoice>();
        }

        public Guid Id { get; set; }
        public int FileType { get; set; }
        public int SendType { get; set; }
        [Required]
        [StringLength(250)]
        public string FileName { get; set; }
        public string SummaryHash { get; set; }
        public TimeSpan InvoiceTime { get; set; }
        [StringLength(200)]
        public string TargetLocalId { get; set; }
        public bool IsInternetSale { get; set; }
        [StringLength(500)]
        public string InternetWebAddress { get; set; }
        public int? InternetPaymentType { get; set; }
        [StringLength(500)]
        public string InternetPaymentTypeOther { get; set; }
        [StringLength(500)]
        public string InternetPaymentAgent { get; set; }
        [Column(TypeName = "date")]
        public DateTime? InternetPaymentDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? InternetCargoDate { get; set; }
        [StringLength(11)]
        public string InternetCargoIdentifier { get; set; }
        [StringLength(500)]
        public string InternetCargoFullName { get; set; }
        [StringLength(200)]
        public string OkcIdentifier { get; set; }
        [Column("OkcZNumber")]
        [StringLength(200)]
        public string OkcZnumber { get; set; }
        [StringLength(200)]
        public string OkcVoucherNumber { get; set; }
        public int OkcVoucherType { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OkcVoucherCreatedDate { get; set; }
        public TimeSpan? OkcVoucherCreatedTime { get; set; }
        [Column("SendEMail")]
        public bool SendEmail { get; set; }
        [Column("EMailAddress")]
        [StringLength(500)]
        public string EmailAddress { get; set; }
        [Column("EMailStatus")]
        public int EmailStatus { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public bool? IsAppended { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("EarsivInvoice")]
        public EfaturaOutboxInvoice IdNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public EarsivInvoiceCanceled EarsivInvoiceCanceled { get; set; }
        [InverseProperty("Invoice")]
        public ICollection<EarsivInvoiceMail> EarsivInvoiceMail { get; set; }
        [InverseProperty("Invoice")]
        public ICollection<EarsivInvoiceReportPart> EarsivInvoiceReportPart { get; set; }
        [InverseProperty("Invoice")]
        public ICollection<EarsivReportInvoice> EarsivReportInvoice { get; set; }
    }
}
