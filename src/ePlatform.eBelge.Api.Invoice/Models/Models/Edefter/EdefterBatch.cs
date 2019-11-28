using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_Batch")]
    public partial class EdefterBatch
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Required]
        [StringLength(4)]
        public string BatchNo { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Required]
        public bool? IsActive { get; set; }
    }
}
