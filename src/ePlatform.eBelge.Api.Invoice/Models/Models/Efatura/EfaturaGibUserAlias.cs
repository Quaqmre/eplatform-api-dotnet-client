using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_GibUserAlias")]
    public partial class EfaturaGibUserAlias
    {
        public int Id { get; set; }
        public int GibUserId { get; set; }
        [Required]
        [StringLength(250)]
        public string Alias { get; set; }
        public int GibAliasType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FirstCreationTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AliasCreationTime { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int? AppType { get; set; }

        [ForeignKey("GibUserId")]
        [InverseProperty("EfaturaGibUserAlias")]
        public EfaturaGibUser GibUser { get; set; }
    }
}
