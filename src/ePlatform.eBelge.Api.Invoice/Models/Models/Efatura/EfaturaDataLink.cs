using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_DataLink")]
    public partial class EfaturaDataLink
    {
        public long Id { get; set; }
        public long DataId { get; set; }
        public int DownloadCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ExpirationDate { get; set; }
        public Guid SecureKey { get; set; }
        [Required]
        [StringLength(50)]
        public string FileName { get; set; }
        [Required]
        [Column("OSKey")]
        [StringLength(100)]
        public string Oskey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
    }
}
