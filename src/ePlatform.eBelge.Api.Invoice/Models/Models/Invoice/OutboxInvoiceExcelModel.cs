using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class OutboxInvoiceExcelModel
    {
        [ExcelAttribute(DisplayOrder = 12)]
        public Guid Id { get; set; }
        [ExcelAttribute(DisplayOrder = 13)]
        public Guid? EnvelopeId { get; set; }
        [ExcelAttribute(DisplayOrder = 0)]
        public string InvoiceNumber { get; set; }
        [ExcelAttribute(DisplayOrder = 6)]
        public DateTime? ExecutionDate { get; set; }
        [ExcelAttribute(DisplayOrder = 1)]
        public string TargetTitle { get; set; }
        [ExcelAttribute(DisplayOrder = 2)]
        public string TargetVknTckn { get; set; }
        [ExcelAttribute(DisplayOrder = 10)]
        public decimal TotalAmount { get; set; }
        [ExcelAttribute(DisplayOrder = 8)]
        public decimal PayableAmount { get; set; }
        [ExcelAttribute(DisplayOrder = 11)]
        public string Currency { get; set; }
        [ExcelAttribute(DisplayOrder = 9)]
        public decimal? TaxTotal { get; set; }
        [ExcelAttribute(DisplayOrder = 7)]
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int TipType { get; set; }
        public List<InvoiceTaxModel> EfaturaOutboxInvoiceTax { get; set; }

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

        [NotMapped]
        [ExcelAttribute(DisplayOrder = 14)]
        public decimal Assessment0 { get; set; }
        [NotMapped]
        [ExcelAttribute(DisplayOrder = 15)]
        public decimal Assessment1 { get; set; }
        [NotMapped]
        [ExcelAttribute(DisplayOrder = 17)]
        public decimal Assessment8 { get; set; }
        [NotMapped]
        [ExcelAttribute(DisplayOrder = 19)]
        public decimal Assessment18 { get; set; }
        [NotMapped]
        [ExcelAttribute(DisplayOrder = 16)]
        public decimal Kdv1 { get; set; }
        [NotMapped]
        [ExcelAttribute(DisplayOrder = 18)]
        public decimal Kdv8 { get; set; }
        [NotMapped]
        [ExcelAttribute(DisplayOrder = 20)]
        public decimal Kdv18 { get; set; }
    }
}
