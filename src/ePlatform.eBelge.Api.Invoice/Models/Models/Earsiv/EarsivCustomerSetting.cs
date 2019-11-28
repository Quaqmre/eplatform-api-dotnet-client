using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EArsiv_CustomerSetting")]
    public partial class EarsivCustomerSetting
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Column("EArsivUserStatus")]
        public int EarsivUserStatus { get; set; }
        [Column("EArsivArchiveUserStatus")]
        public int EarsivArchiveUserStatus { get; set; }
        [Column("EArsivStartDate", TypeName = "date")]
        public DateTime? EarsivStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
    }
}
