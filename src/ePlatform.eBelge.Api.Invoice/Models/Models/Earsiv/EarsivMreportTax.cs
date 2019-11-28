using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_MReportTax")]
    public partial class EarsivMreportTax
    {
        public Guid Id { get; set; }
        [Column("MReportId")]
        public Guid MreportId { get; set; }
        [Required]
        [StringLength(20)]
        public string TaxName { get; set; }
        public decimal TaxAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("MreportId")]
        [InverseProperty("EarsivMreportTax")]
        public EarsivMreport Mreport { get; set; }
    }
}
