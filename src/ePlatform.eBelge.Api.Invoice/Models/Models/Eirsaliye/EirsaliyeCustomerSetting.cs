using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EIrsaliye_CustomerSetting")]
    public partial class EirsaliyeCustomerSetting
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Column("EIrsaliyeUserStatus")]
        public int EirsaliyeUserStatus { get; set; }
        [Column("EIrsaliyeArsivStatus")]
        public int EirsaliyeArsivStatus { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
    }
}
