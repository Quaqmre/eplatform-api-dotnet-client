using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public partial class ImportedFile
    {
        public ImportedFile()
        {
            EdefterImportedFile = new HashSet<EdefterImportedFile>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        public Guid CustomerId { get; set; }
        [Required]
        [StringLength(100)]
        public string ObjectStorageId { get; set; }
        public int DocumentType { get; set; }
        public int Type { get; set; }
        public bool Status { get; set; }
        public decimal? Size { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [InverseProperty("Import")]
        public ICollection<EdefterImportedFile> EdefterImportedFile { get; set; }
    }
}
