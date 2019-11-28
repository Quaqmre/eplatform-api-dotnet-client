using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_AccountAmount")]
    public partial class EdefterAccountAmount
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        [Required]
        [StringLength(100)]
        public string AccountCode { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("PartId")]
        [InverseProperty("EdefterAccountAmount")]
        public EdefterPart Part { get; set; }
    }
}
