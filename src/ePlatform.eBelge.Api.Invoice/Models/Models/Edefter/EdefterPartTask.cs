using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_PartTask")]
    public partial class EdefterPartTask
    {
        [Key]
        public int PartId { get; set; }
        public int? AppMachineId { get; set; }
        public int Status { get; set; }

        [ForeignKey("AppMachineId")]
        [InverseProperty("EdefterPartTask")]
        public AppMachine AppMachine { get; set; }
        [ForeignKey("PartId")]
        [InverseProperty("EdefterPartTask")]
        public EdefterPart Part { get; set; }
    }
}
