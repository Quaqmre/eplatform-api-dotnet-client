using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_TaxBase")]
    public partial class EfaturaTaxBase
    {
        public int Id { get; set; }
        public int TaxTypeId { get; set; }
        public int BaseTaxTypeId { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
    }
}
