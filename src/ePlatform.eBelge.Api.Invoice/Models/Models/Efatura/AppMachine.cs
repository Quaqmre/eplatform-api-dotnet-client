using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public partial class AppMachine
    {
        public AppMachine()
        {
            EdefterAppMachineTask = new HashSet<EdefterAppMachineTask>();
            EdefterPartTask = new HashSet<EdefterPartTask>();
            EfaturaTask = new HashSet<EfaturaTask>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string IpAddress { get; set; }
        [StringLength(100)]
        public string HostName { get; set; }
        public bool IsBaseMachine { get; set; }
        public bool IsRunning { get; set; }
        public int CoreCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BaseMachineUpdatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        [InverseProperty("AppMachine")]
        public ICollection<EdefterAppMachineTask> EdefterAppMachineTask { get; set; }
        [InverseProperty("AppMachine")]
        public ICollection<EdefterPartTask> EdefterPartTask { get; set; }
        [InverseProperty("AppMachine")]
        public ICollection<EfaturaTask> EfaturaTask { get; set; }
    }
}
