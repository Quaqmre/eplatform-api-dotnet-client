using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_TaxExemptionReason")]
    public partial class EfaturaTaxExemptionReason
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Value { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        public int RelatedType { get; set; }
        public bool IsEnabled { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
    }
}
