using System;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Models.Models.Enum;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class CustomerCoreModel
    {
        public long Id { get; set; }
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

        public CustomerType CustomerTypeEnum
        {
            get
            {
                return (CustomerType)this.CustomerType;
            }
            set
            {
                this.CustomerType = Convert.ToInt32(value);
            }
        }
    }
}