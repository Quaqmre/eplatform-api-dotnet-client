using System;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    public class CustomerWithDetailsModel
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public Guid UniqueId { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public int? CustomerType { get; set; }
        public bool? IsApproved { get; set; }
        public byte Status { get; set; }

        //Details
        public int? CountryId { get; set; }
        public int OwnerType { get; set; }
        public string TaxOfficeCode { get; set; }
        public string TaxOffice { get; set; }
        public string Senderbox { get; set; }
        public string Receiverbox { get; set; }
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
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}