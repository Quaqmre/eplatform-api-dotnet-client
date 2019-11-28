using System;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EarsivInvoiceMailModel
    {
        public EarsivInvoiceMailModel()
        {
            this.CreatedDate = DateTime.Now;
            this.UpdatedDate = DateTime.Now;
        }

        public Guid Id { get; set; }
        public Guid InvoiceId { get; set; }
        public string EmailAddress { get; set; }
        public int EmailStatus { get; set; }
        public int TryCount { get; set; }
        public DateTime? LastTryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public int Type { get; set; }

        [NotMapped]
        public EarsivEmailStatusType EmailStatusEnum
        {
            get
            {
                return (EarsivEmailStatusType)this.EmailStatus;
            }
            set
            {
                this.EmailStatus = Convert.ToInt32(value);
            }
        }
    }
}