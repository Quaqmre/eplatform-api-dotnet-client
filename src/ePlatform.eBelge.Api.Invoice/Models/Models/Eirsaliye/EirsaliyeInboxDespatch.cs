using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EIrsaliye_InboxDespatch")]
    public partial class EirsaliyeInboxDespatch
    {
        public Guid Id { get; set; }
        [StringLength(36)]
        public string IdString { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EnvelopeId { get; set; }
        [Required]
        [StringLength(16)]
        public string DespatchNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        public int Status { get; set; }
        public int ProfileId { get; set; }
        public int TypeCode { get; set; }
        [Required]
        [StringLength(500)]
        public string TargetTitle { get; set; }
        [Required]
        [StringLength(11)]
        public string TargetVknTckn { get; set; }
        [Required]
        [StringLength(150)]
        public string TargetAlias { get; set; }
        public bool IsNew { get; set; }
        public bool IsRead { get; set; }
        public bool IsArchived { get; set; }
        public bool IsVerified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SigningDate { get; set; }
        [Column(TypeName = "ntext")]
        public string VerificationResult { get; set; }
        public decimal TotalAmount { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
    }
}
