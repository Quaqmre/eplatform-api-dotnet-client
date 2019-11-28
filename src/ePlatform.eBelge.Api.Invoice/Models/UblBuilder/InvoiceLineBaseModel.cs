using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class InvoiceLineBaseModel<TTax> where TTax : InvoiceLineTaxBaseModel
    {
        public long InventoryServiceType { get; set; }
        public string InventoryCard { get; set; }
        public bool SerialNoEnabled { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Negatif değer girilemez.")]
        public Decimal Amount { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Negatif değer girilemez.")]
        public long UnitCodeId { get; set; }
        public string UnitCode { get; set; }
        public Decimal UnitPrice { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Negatif değer girilemez.")]
        public Decimal DiscountRate { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Negatif değer girilemez.")]
        public Decimal DiscountAmount { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Negatif değer girilemez.")]
        public Decimal VatRate { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Negatif değer girilemez.")]
        public Decimal VatAmount { get; set; }
        public string VatExemptionReasonCode { get; set; }
        public string VatExemptionReason { get; set; }
        public virtual List<TTax> Taxes { get; set; }
        public InvoiceLineDeliveryInfoBaseModel InvoiceLineDeliveryInfoModel { get; set; }
        public List<string> SerialNumberList { get; set; }

        public InvoiceLineBaseModel()
        {
            this.Taxes = new List<TTax>();
            this.SerialNumberList = new List<string>();
            this.InvoiceLineDeliveryInfoModel = new InvoiceLineDeliveryInfoBaseModel();
        }
    }
}