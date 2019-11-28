using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EarsivInvoiceModel : CreateUpdatedHistoryModel
    {
        public Guid Id { get; set; }
        public int FileType { get; set; }
        public int SendType { get; set; }
        public string FileName { get; set; }
        public string SummaryHash { get; set; }
        public TimeSpan InvoiceTime { get; set; }
        public string TargetLocalId { get; set; }
        public bool IsInternetSale { get; set; }
        public string InternetWebAddress { get; set; }
        public int? InternetPaymentType { get; set; }
        public string InternetPaymentTypeOther { get; set; }
        public string InternetPaymentAgent { get; set; }
        public DateTime? InternetPaymentDate { get; set; }
        public DateTime? InternetCargoDate { get; set; }
        public string InternetCargoIdentifier { get; set; }
        public string InternetCargoFullName { get; set; }
        public string OkcIdentifier { get; set; }
        public string OkcZNumber { get; set; }
        public string OkcVoucherNumber { get; set; }
        public int OkcVoucherType { get; set; }
        public DateTime? OkcVoucherCreatedDate { get; set; }
        public TimeSpan? OkcVoucherCreatedTime { get; set; }
        public bool SendEMail { get; set; }
        public string EMailAddress { get; set; }
        public List<EarsivInvoiceMailModel> EMailAddressList { get; set; }
        public int EMailStatus { get; set; }

        [NotMapped]
        public EarsivEmailStatusType EMailStatusEnum
        {
            get
            {
                return (EarsivEmailStatusType)this.EMailStatus;
            }
            set
            {
                this.EMailStatus = Convert.ToInt32(value);
            }
        }

        [NotMapped]
        public EArsivFileType FileTypeEnum
        {
            get
            {
                return (EArsivFileType)this.FileType;
            }
            set
            {
                this.FileType = Convert.ToInt32(value);
            }
        }

        [NotMapped]
        public EArsivSendType SendTypeEnum
        {
            get
            {
                return (EArsivSendType)this.SendType;
            }
            set
            {
                this.SendType = Convert.ToInt32(value);
            }
        }

        [NotMapped]
        public InternetPaymentType InternetPaymentTypeEnum
        {
            get
            {
                if (this.InternetPaymentType == null)
                    return Enums.InternetPaymentType.NULL;
                return
                    (InternetPaymentType)this.InternetPaymentType;
            }
            set
            {
                this.InternetPaymentType = Convert.ToInt32(value);
            }
        }

        [NotMapped]
        public VoucherType OkcVoucherTypeEnum
        {
            get
            {
                return (VoucherType)this.OkcVoucherType;
            }
            set
            {
                this.OkcVoucherType = Convert.ToInt32(value);
            }
        }

        [NotMapped]
        public string CustomerName { get; set; }

        [NotMapped]
        public OutboxInvoiceModel OutboxInvoice { get; set; }

        [NotMapped]
        public BaseInvoiceModel BaseInvoice { get; set; }

        [NotMapped]
        public List<OutboxInvoiceTaxModel> TaxList { get; set; }
        [NotMapped]
        public List<OutboxInvoiceTaxModel> WithholdingList { get; set; }
    }
}