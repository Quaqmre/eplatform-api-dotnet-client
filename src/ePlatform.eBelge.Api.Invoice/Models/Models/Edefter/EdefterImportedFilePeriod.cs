using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_ImportedFilePeriod")]
    public partial class EdefterImportedFilePeriod
    {
        public EdefterImportedFilePeriod()
        {
            EdefterImportedFile = new HashSet<EdefterImportedFile>();
        }

        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Column(TypeName = "date")]
        public DateTime PeriodCoveredStart { get; set; }
        [Column(TypeName = "date")]
        public DateTime PeriodCoveredEnd { get; set; }
        [Required]
        public bool? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [InverseProperty("Period")]
        public ICollection<EdefterImportedFile> EdefterImportedFile { get; set; }
    }
}
