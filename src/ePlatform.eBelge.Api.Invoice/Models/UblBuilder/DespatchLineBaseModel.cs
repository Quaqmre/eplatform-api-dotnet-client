using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class DespatchLineBaseModel
    {
        public string ProductName { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Negatif değer girilemez.")]
        public Decimal Amount { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Negatif değer girilemez.")]
        public long UnitCodeId { get; set; }
        public string UnitCode { get; set; }
        public Decimal? UnitPrice { get; set; }
    }
}