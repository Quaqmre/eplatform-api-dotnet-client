using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_PrefixHistory")]
    public partial class EfaturaPrefixHistory
    {
        public Guid Id { get; set; }
        public int PrefixId { get; set; }
        public int Counter { get; set; }
        public int Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ExpirationDate { get; set; }
        public bool IsPreviousYear { get; set; }

        [ForeignKey("PrefixId")]
        [InverseProperty("EfaturaPrefixHistory")]
        public EfaturaPrefix Prefix { get; set; }
    }
}
