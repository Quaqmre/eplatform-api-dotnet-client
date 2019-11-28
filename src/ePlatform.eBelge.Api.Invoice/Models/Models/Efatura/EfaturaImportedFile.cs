using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_ImportedFile")]
    public partial class EfaturaImportedFile
    {
        public Guid Id { get; set; }
        public int ImportId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EnvelopeId { get; set; }
        public Guid? InvoiceId { get; set; }
        [Required]
        [StringLength(150)]
        public string InvoiceNumber { get; set; }
        public int AppType { get; set; }
        public int? ImportType { get; set; }
        public int? InvoiceType { get; set; }
        public int? InvoiceTipType { get; set; }
        public bool? IsInternetSale { get; set; }
        public int? SendType { get; set; }
        [StringLength(500)]
        public string TargetTitle { get; set; }
        [StringLength(11)]
        public string TargetVknTckn { get; set; }
        [StringLength(150)]
        public string TargetAlias { get; set; }
        [StringLength(100)]
        public string ObjectStorageKey { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? PayableAmount { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        public decimal? TaxTotal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IssueDate { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
