using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_Task")]
    public partial class EfaturaTask
    {
        public Guid Id { get; set; }
        public int Progress { get; set; }
        public int? AppMachineId { get; set; }
        public int TaskStatus { get; set; }
        public int TryCount { get; set; }
        public string Message { get; set; }

        [ForeignKey("AppMachineId")]
        [InverseProperty("EfaturaTask")]
        public AppMachine AppMachine { get; set; }
    }
}
