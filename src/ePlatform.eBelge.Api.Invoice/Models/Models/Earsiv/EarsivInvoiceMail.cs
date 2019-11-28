using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_InvoiceMail")]
    public partial class EarsivInvoiceMail
    {
        public Guid Id { get; set; }
        public Guid InvoiceId { get; set; }
        [Required]
        [Column("EMailAddress")]
        [StringLength(500)]
        public string EmailAddress { get; set; }
        [Column("EMailStatus")]
        public int EmailStatus { get; set; }
        public int TryCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int Type { get; set; }

        [ForeignKey("InvoiceId")]
        [InverseProperty("EarsivInvoiceMail")]
        public EarsivInvoice Invoice { get; set; }
    }
}
