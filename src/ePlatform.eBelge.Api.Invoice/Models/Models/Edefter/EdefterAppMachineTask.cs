using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_AppMachineTask")]
    public partial class EdefterAppMachineTask
    {
        public Guid TaskId { get; set; }
        public int AppMachineId { get; set; }
        public int TaskStatus { get; set; }
        public string Message { get; set; }

        [ForeignKey("AppMachineId")]
        [InverseProperty("EdefterAppMachineTask")]
        public AppMachine AppMachine { get; set; }
        [ForeignKey("TaskId")]
        [InverseProperty("EdefterAppMachineTask")]
        public EdefterTask Task { get; set; }
    }
}
