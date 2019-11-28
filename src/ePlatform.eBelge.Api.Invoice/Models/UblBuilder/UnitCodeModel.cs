using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class UnitCodeModel
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        [NotMapped]
        public bool IsSelectedUnitCode { get; set; }

        [NotMapped]
        public decimal UnitPrice { get; set; }
    }
}
