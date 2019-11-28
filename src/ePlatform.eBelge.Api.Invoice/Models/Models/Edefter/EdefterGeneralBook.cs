using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_GeneralBook")]
    public partial class EdefterGeneralBook
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public Guid? UniqueId { get; set; }
        public int GeneralBookType { get; set; }
        public int Status { get; set; }
        [StringLength(500)]
        public string GeneralBookPath { get; set; }
        [StringLength(500)]
        public string LettersPatentPath { get; set; }
        [StringLength(500)]
        public string SignedLettersPatentPath { get; set; }
        [StringLength(500)]
        public string GeneralBookPath2 { get; set; }
        [StringLength(500)]
        public string LettersPatentPath2 { get; set; }
        [StringLength(500)]
        public string SignedLettersPatentPath2 { get; set; }
        [Column("GeneralBookOSKey")]
        [StringLength(100)]
        public string GeneralBookOskey { get; set; }
        [Column("LettersPatentOSKey")]
        [StringLength(100)]
        public string LettersPatentOskey { get; set; }
        [Column("SignedLettersPatentOSKey")]
        [StringLength(100)]
        public string SignedLettersPatentOskey { get; set; }
        [Required]
        [StringLength(500)]
        public string SignatureValue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int? GeneralBookFileSize { get; set; }

        [ForeignKey("PartId")]
        [InverseProperty("EdefterGeneralBook")]
        public EdefterPart Part { get; set; }
    }
}
