namespace ePlatform.eBelge.Api.Models.Models
{
    public class InboxInvoiceExcelModel : InboxInvoiceModel
    {
        [ExcelAttribute(DisplayOrder = 14)]
        public decimal Assessment0 { get; set; }
        [ExcelAttribute(DisplayOrder = 15)]
        public decimal Assessment1 { get; set; }
        [ExcelAttribute(DisplayOrder = 17)]
        public decimal Assessment8 { get; set; }
        [ExcelAttribute(DisplayOrder = 19)]
        public decimal Assessment18 { get; set; }
        [ExcelAttribute(DisplayOrder = 16)]
        public decimal Kdv1 { get; set; }
        [ExcelAttribute(DisplayOrder = 18)]
        public decimal Kdv8 { get; set; }
        [ExcelAttribute(DisplayOrder = 20)]
        public decimal Kdv18 { get; set; }
    }
}
