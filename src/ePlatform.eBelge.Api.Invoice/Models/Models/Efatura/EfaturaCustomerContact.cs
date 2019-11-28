using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_CustomerContact")]
    public partial class EfaturaCustomerContact
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int Type { get; set; }
        [Required]
        [StringLength(250)]
        public string Value { get; set; }
        [StringLength(50)]
        public string ChannelCode { get; set; }
        [StringLength(150)]
        public string Channel { get; set; }
    }
}
