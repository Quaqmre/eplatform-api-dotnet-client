using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_GibUser")]
    public partial class EfaturaGibUser
    {
        public EfaturaGibUser()
        {
            EfaturaGibUserAlias = new HashSet<EfaturaGibUserAlias>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(11)]
        public string Identifier { get; set; }
        [Required]
        [StringLength(500)]
        public string Title { get; set; }
        public int GibUserType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [StringLength(250)]
        public string AccountType { get; set; }

        [InverseProperty("GibUser")]
        public ICollection<EfaturaGibUserAlias> EfaturaGibUserAlias { get; set; }
    }
}
