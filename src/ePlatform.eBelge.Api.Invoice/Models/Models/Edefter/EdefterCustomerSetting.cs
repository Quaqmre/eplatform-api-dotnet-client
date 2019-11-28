using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_CustomerSetting")]
    public partial class EdefterCustomerSetting
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Column("EDefterStartDate", TypeName = "date")]
        public DateTime EdefterStartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime FiscalYearStart { get; set; }
        public bool IsJavaAppletSign { get; set; }
        public int LastEntryNumberEnd { get; set; }
        public int LastLineNumberEnd { get; set; }
        public int LastYearIndex { get; set; }
        [StringLength(200)]
        public string CreatorFullName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsLiquidation { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LiquidationStartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime IncorporationDate { get; set; }
        public bool ShouldSort { get; set; }
    }
}
