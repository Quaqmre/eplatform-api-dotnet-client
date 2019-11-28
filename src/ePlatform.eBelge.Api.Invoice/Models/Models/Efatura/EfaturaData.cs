using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_Data")]
    public partial class EfaturaData
    {
        public long Id { get; set; }
        public Guid CustomerId { get; set; }
        public int Status { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
    }
}
