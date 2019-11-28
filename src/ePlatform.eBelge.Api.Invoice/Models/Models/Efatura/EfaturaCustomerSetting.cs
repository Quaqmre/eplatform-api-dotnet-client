using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_CustomerSetting")]
    public partial class EfaturaCustomerSetting
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Column("EFaturaUserStatus")]
        public int EfaturaUserStatus { get; set; }
        public int ArsivUserStatus { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
    }
}
