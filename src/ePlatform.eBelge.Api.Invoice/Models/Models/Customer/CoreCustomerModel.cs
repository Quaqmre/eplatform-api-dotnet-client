using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class CoreCustomerModel
    {
        [NotMapped]
        public long Id { get; set; }
        [NotMapped]
        public long? ParentId { get; set; }
        public Guid UniqueId { get; set; }
        public string CustomerNo { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public int? CustomerType { get; set; }
        public bool? IsApproved { get; set; }
        public bool IsImportedCustomer { get; set; }
        public bool IsSharedModel { get; set; }
        public byte Status { get; set; }
        public long? VendorId { get; set; }
        public string DealerCode { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}