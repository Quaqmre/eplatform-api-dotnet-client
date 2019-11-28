using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_Period")]
    public partial class EdefterPeriod
    {
        public EdefterPeriod()
        {
            EdefterPart = new HashSet<EdefterPart>();
        }

        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int? BatchId { get; set; }
        public Guid TaskId { get; set; }
        [Column(TypeName = "date")]
        public DateTime FiscalYearStart { get; set; }
        [Column(TypeName = "date")]
        public DateTime FiscalYearEnd { get; set; }
        [StringLength(100)]
        public string ObjectStorageKey { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; }
        public int SplitSize { get; set; }
        public bool IsTimeStamp { get; set; }
        public bool WithoutTaxDetail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsLiquidation { get; set; }
        public string Message { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }

        [ForeignKey("TaskId")]
        [InverseProperty("EdefterPeriod")]
        public EdefterTask Task { get; set; }
        [InverseProperty("Period")]
        public ICollection<EdefterPart> EdefterPart { get; set; }
    }
}
