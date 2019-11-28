using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_SchError")]
    public partial class EdefterSchError
    {
        public Guid Id { get; set; }
        public int PartId { get; set; }
        public int? EntryNumber { get; set; }
        public int GeneralBookTypes { get; set; }
        public string Message { get; set; }

        [ForeignKey("PartId")]
        [InverseProperty("EdefterSchError")]
        public EdefterPart Part { get; set; }
    }
}
