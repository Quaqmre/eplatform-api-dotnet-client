using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.UBLBuilder.Enums;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class PaymentMeansBaseModel
    {
        [Display(Name = "Ödeme Şekli Kodu")]
        //[RequiredWhen(new string[] { "PaymentDueDate", "PaymentChannelCode", "InstructionNote", "PayeeFinancialAccountId" })]
        public PaymentMeansType PaymentMeansCode { get; set; }

        [Display(Name = "Son Ödeme Tarihi")]
        //[RequiredIf("PaymentMeansCodeInt == 48 || PaymentMeansCodeInt == 30 || PaymentMeansCodeInt == 1", ErrorMessage = "Seçtiğiniz ödeme şekli için son ödeme tarihi zorunludur.")]
        public DateTime? PaymentDueDate { get; set; }

        [Display(Name = "Ödeme Kanal Kodu")]
        public string PaymentChannelCode { get; set; }

        [Display(Name = "Ödeme Açıklaması")]
        //[RequiredIf("PaymentMeansCodeInt == 97", ErrorMessage = "Seçtiğiniz ödeme şekli için ödeme açıklaması zorunludur.")]
        public string InstructionNote { get; set; }

        [Display(Name = "Hesap No")]
        public string PayeeFinancialAccountId { get; set; }
    }
}
