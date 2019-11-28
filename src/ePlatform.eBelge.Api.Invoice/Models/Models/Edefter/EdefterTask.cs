using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_Task")]
    public partial class EdefterTask
    {
        public EdefterTask()
        {
            EdefterAppMachineTask = new HashSet<EdefterAppMachineTask>();
            EdefterPeriod = new HashSet<EdefterPeriod>();
        }

        public Guid Id { get; set; }
        public int Progress { get; set; }
        [Required]
        [StringLength(500)]
        public string ProgressPath { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public int TryCount { get; set; }
        public int PartIndex { get; set; }
        public bool HasSchError { get; set; }

        [InverseProperty("Task")]
        public ICollection<EdefterAppMachineTask> EdefterAppMachineTask { get; set; }
        [InverseProperty("Task")]
        public ICollection<EdefterPeriod> EdefterPeriod { get; set; }
    }
}
