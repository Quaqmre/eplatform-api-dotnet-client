using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_ImportedFile")]
    public partial class EdefterImportedFile
    {
        public Guid Id { get; set; }
        public int ImportId { get; set; }
        public int PeriodId { get; set; }
        public Guid CustomerId { get; set; }
        [Required]
        [StringLength(100)]
        public string ObjectStorageKey { get; set; }
        [Required]
        [StringLength(100)]
        public string UniqueId { get; set; }
        [Required]
        [StringLength(11)]
        public string Identifier { get; set; }
        public int EntryType { get; set; }
        public int PartNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PeriodCoveredStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PeriodCoveredEnd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FiscalYearStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FiscalYearEnd { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("ImportId")]
        [InverseProperty("EdefterImportedFile")]
        public ImportedFile Import { get; set; }
        [ForeignKey("PeriodId")]
        [InverseProperty("EdefterImportedFile")]
        public EdefterImportedFilePeriod Period { get; set; }
    }
}
