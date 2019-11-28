using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_MReport")]
    public partial class EarsivMreport
    {
        public EarsivMreport()
        {
            EarsivMreportTax = new HashSet<EarsivMreportTax>();
        }

        public Guid Id { get; set; }
        public Guid ReportId { get; set; }
        [Required]
        [Column("OKCRegistrationNumber")]
        [StringLength(50)]
        public string OkcregistrationNumber { get; set; }
        public decimal SaleTotal { get; set; }
        [Column("VATTotal")]
        public decimal Vattotal { get; set; }
        public byte Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("ReportId")]
        [InverseProperty("EarsivMreport")]
        public EarsivReport Report { get; set; }
        [InverseProperty("Mreport")]
        public ICollection<EarsivMreportTax> EarsivMreportTax { get; set; }
    }
}
