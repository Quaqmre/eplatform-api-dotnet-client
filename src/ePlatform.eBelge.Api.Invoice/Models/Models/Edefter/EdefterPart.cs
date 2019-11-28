using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_Part")]
    public partial class EdefterPart
    {
        public EdefterPart()
        {
            EdefterAccountAmount = new HashSet<EdefterAccountAmount>();
            EdefterGeneralBook = new HashSet<EdefterGeneralBook>();
            EdefterSchError = new HashSet<EdefterSchError>();
        }

        public int Id { get; set; }
        public int PeriodId { get; set; }
        public int IndexNumber { get; set; }
        public int YearIndexNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PeriodCoveredStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PeriodCoveredEnd { get; set; }
        public int EntryNumberStart { get; set; }
        public int EntryNumberEnd { get; set; }
        public int LineNumberStart { get; set; }
        public int LineNumberEnd { get; set; }
        [StringLength(100)]
        public string ControlKey { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public bool IsDone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int Status { get; set; }
        public int TryCount { get; set; }
        public string Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }

        [ForeignKey("PeriodId")]
        [InverseProperty("EdefterPart")]
        public EdefterPeriod Period { get; set; }
        [InverseProperty("Part")]
        public EdefterPartTask EdefterPartTask { get; set; }
        [InverseProperty("Part")]
        public ICollection<EdefterAccountAmount> EdefterAccountAmount { get; set; }
        [InverseProperty("Part")]
        public ICollection<EdefterGeneralBook> EdefterGeneralBook { get; set; }
        [InverseProperty("Part")]
        public ICollection<EdefterSchError> EdefterSchError { get; set; }
    }
}
