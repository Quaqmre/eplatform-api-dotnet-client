using System;
using ePlatform.eBelge.Api.Models.Models.Enum;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class EfaturaCustomerDetailModel
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public int OwnerType { get; set; }
        public string TaxOffice { get; set; }
        public string Senderbox { get; set; }
        public string Receiverbox { get; set; }
        public string EIrsaliyeSenderbox { get; set; }
        public string EIrsaliyeReceiverbox { get; set; }
        public string WebSite { get; set; }
        public string AddressCountry { get; set; }
        public string AddressCity { get; set; }
        public string AddressSubDivisionName { get; set; }
        public string AddressStreetName { get; set; }
        public string AddressBuildingName { get; set; }
        public string AddressBuildingNumber { get; set; }
        public string AddressRoom { get; set; }
        public string AddressPostalZone { get; set; }
        public string AddressRegion { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string NameSuffix { get; set; }
        public string Title { get; set; }
        public string MersisNo { get; set; }
        public string RegisterNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneType { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public int CreatedBy { get; set; }
        public string VkTckNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CustomerType { get; set; }
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