using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_LineResponse")]
    public partial class EfaturaLineResponse
    {
        public Guid Id { get; set; }
        public Guid DocumentResponseId { get; set; }
        public int LineNumber { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
}
