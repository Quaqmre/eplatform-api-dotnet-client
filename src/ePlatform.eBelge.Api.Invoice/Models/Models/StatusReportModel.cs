using System;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class StatusReportModel
    {
        public long CustomerId { get; set; }
        public Guid CustomerUniqueId { get; set; }
        public long? ParentCustomerId { get; set; }
        public int CustomerStatus { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string CustomerNo { get; set; }
        public long EInvoiceCustomerApplicationId { get; set; }
        public byte? EInvoiceActivationStatus { get; set; }
        public byte? EInvoiceApplicationStatus { get; set; }
        public int EInvoiceTotalCredit { get; set; }
        public int EInvoiceUsedCredit { get; set; }
        public int EInvoiceLeftCredit { get; set; }
        public long EArchiveCustomerApplicationId { get; set; }
        public byte? EArchiveActivationStatus { get; set; }
        public byte? EArchiveApplicationStatus { get; set; }
        public int EArchiveTotalCredit { get; set; }
        public int EArchiveUsedCredit { get; set; }
        public int EArchiveLeftCredit { get; set; }
        public long ELedgerCustomerApplicationId { get; set; }
        public byte? ELedgerActivationStatus { get; set; }
        public byte? ELedgerApplicationStatus { get; set; }
        public int ELedgerTotalCredit { get; set; }
        public int ELedgerUsedCredit { get; set; }
        public int ELedgerLeftCredit { get; set; }
        public long EDespatchCustomerApplicationId { get; set; }
        public byte? EDespatchActivationStatus { get; set; }
        public byte? EDespatchApplicationStatus { get; set; }
        public int EDespatchTotalCredit { get; set; }
        public int EDespatchUsedCredit { get; set; }
        public int EDespatchLeftCredit { get; set; }
        public long ETicketCustomerApplicationId { get; set; }
        public byte? ETicketActivationStatus { get; set; }
        public byte? ETicketApplicationStatus { get; set; }
        public int ETicketTotalCredit { get; set; }
        public int ETicketUsedCredit { get; set; }
        public int ETicketLeftCredit { get; set; }
        public long EStorageCustomerApplicationId { get; set; }
        public byte? EStorageActivationStatus { get; set; }
        public byte? EStorageApplicationStatus { get; set; }
        public int EStorageTotalCredit { get; set; }
        public int EStorageUsedCredit { get; set; }
        public int EStorageLeftCredit { get; set; }
    }
}