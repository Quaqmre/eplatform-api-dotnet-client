using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using ePlatform.eBelge.Api.Models.Models.Enums;
using ePlatform.eBelge.Api.Invoice.Models;
using ePlatform.eBelge.Api.Models.Models.Envelope;
using ePlatform.eBelge.Api.Models.Models.Envelope.Base;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class BaseInvoiceModel
    {
        [ExcelAttribute(DisplayOrder = 12)]
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        [ExcelAttribute(DisplayOrder = 13)]
        public Guid? EnvelopeId { get; set; }
        [ExcelAttribute(DisplayOrder = 0)]
        public string InvoiceNumber { get; set; }
        [ExcelAttribute(DisplayOrder = 6)]
        public DateTime? ExecutionDate { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int TipType { get; set; }
        public int LineNumber { get; set; }
        [ExcelAttribute(DisplayOrder = 1)]
        public string TargetTitle { get; set; }
        [ExcelAttribute(DisplayOrder = 2)]
        public string TargetVknTckn { get; set; }
        public string TargetAlias { get; set; }
        public bool IsArchived { get; set; }
        public bool IsAgentNew { get; set; }
        [ExcelAttribute(DisplayOrder = 10)]
        public decimal TotalAmount { get; set; }
        [ExcelAttribute(DisplayOrder = 8)]
        public decimal PayableAmount { get; set; }
        [ExcelAttribute(DisplayOrder = 11)]
        public string Currency { get; set; }
        [ExcelAttribute(DisplayOrder = 9)]
        public decimal? TaxTotal { get; set; }

        [NotMapped]
        [ExcelAttribute(DisplayOrder = 5)]
        public InvoiceStatus StatusEnum
        {
            get
            {
                return (InvoiceStatus)this.Status;
            }
            set
            {
                this.Status = Convert.ToInt32(value);
            }
        }

        [NotMapped]
        [ExcelAttribute(DisplayOrder = 3)]
        public InvoiceTypes TypeEnum
        {
            get
            {
                return (InvoiceTypes)this.Type;
            }
            set
            {
                this.Type = Convert.ToInt32(value);
            }
        }

        [NotMapped]
        [ExcelAttribute(DisplayOrder = 4)]
        public InvoiceTipType TipTypeEnum
        {
            get
            {
                return (InvoiceTipType)this.TipType;
            }
            set
            {
                this.TipType = Convert.ToInt32(value);
            }
        }

        public string TableOperations { get; set; }
        public DateTime? SentDate { get; set; }
        [ExcelAttribute(DisplayOrder = 7)]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int CreatedBy { get; set; }
        public InboxEnvelopeModel Envelope { get; set; }
        public List<BaseEnvelopeModel> Envelopes { get; set; } //related envelopes
    }
}
