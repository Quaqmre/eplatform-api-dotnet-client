using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public partial class EfaturaImportedFileModel
    {
        public Guid Id { get; set; }
        public int ImportId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EnvelopeId { get; set; }
        [ExcelAttribute(ColumnName = "ETTN", DisplayOrder = 1)]
        public Guid? InvoiceId { get; set; }
        [ExcelAttribute(ColumnName = "Fatura Numarası", DisplayOrder = 2)]
        public string InvoiceNumber { get; set; }
        public int AppType { get; set; }
        public int? ImportType { get; set; }
        public int? InvoiceType { get; set; }
        public int? InvoiceTipType { get; set; }
        public bool? IsInternetSale { get; set; }
        public int? SendType { get; set; }
        [ExcelAttribute(ColumnName = "Gönderilen Ünvan", DisplayOrder = 4)]
        public string TargetTitle { get; set; }
        [ExcelAttribute(ColumnName = "VKN/TCKN", DisplayOrder = 5)]
        public string TargetVknTckn { get; set; }
        public string TargetAlias { get; set; }
        public string ObjectStorageKey { get; set; }
        [ExcelAttribute(ColumnName = "Toplam Tutar", DisplayOrder = 6)]
        public decimal? TotalAmount { get; set; }
        [ExcelAttribute(ColumnName = "Ödenecek Tutar", DisplayOrder = 8)]
        public decimal? PayableAmount { get; set; }
        [ExcelAttribute(ColumnName = "Para Birimi", DisplayOrder = 9)]
        public string Currency { get; set; }
        [ExcelAttribute(ColumnName = "Vergi Toplamı", DisplayOrder = 7)]
        public decimal? TaxTotal { get; set; }
        [ExcelAttribute(ColumnName = "Fatura Tarihi", DisplayOrder = 10)]
        public DateTime IssueDate { get; set; }
        public bool Status { get; set; }
        [ExcelAttribute(ColumnName = "Oluşturulma Tarihi", DisplayOrder = 11)]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        [NotMapped]
        [ExcelAttribute(ColumnName = "Fatura Türü", DisplayOrder = 3)]
        public string InvoiceTypeString
        {
            get
            {
                return this.InvoiceType.HasValue ? ((InvoiceTypes)this.InvoiceType).ToEnumDisplayText() : string.Empty;
            }
        }
    }
}
