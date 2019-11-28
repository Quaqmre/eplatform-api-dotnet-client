using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("__EFatura_Prefix")]
    public partial class EfaturaPrefix
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int PrefixType { get; set; }
        [Required]
        [StringLength(3)]
        public string Prefix { get; set; }
        public int? Counter2015 { get; set; }
        public int PreCounter { get; set; }
        public int Counter { get; set; }
        public bool IsDefault { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
    }
}
