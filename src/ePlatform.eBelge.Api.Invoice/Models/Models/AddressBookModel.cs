using System;
using System.ComponentModel.DataAnnotations;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class AddressBookModel
    {
        public int Id { get; set; }
        public System.Guid CustomerId { get; set; }
        public bool IsArchive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        //[Required(ErrorMessage = "Lütfen bir adres tanımı giriniz.")]
        //public string Description { get; set; }
        public string Alias { get; set; }
        [Required(ErrorMessage = "Lütfen vergi numarasını giriniz.")]
        public string IdentificationNumber { get; set; }
        [Required(ErrorMessage = "Lütfen alıcı ünvanını/Adını giriniz.")]
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string ReceiverPersonSurName { get; set; }
        public string ReceiverStreet { get; set; }
        public string ReceiverBuildingName { get; set; }
        public string ReceiverBuildingNumber { get; set; }
        public string ReceiverDoorNumber { get; set; }
        public string ReceiverSmallTown { get; set; }
        [Required(ErrorMessage = "Lütfen ilçe adını giriniz.")]
        public string ReceiverDistrict { get; set; }
        public string ReceiverZipCode { get; set; }
        [Required(ErrorMessage = "Lütfen şehir giriniz.")]
        public string ReceiverCity { get; set; }
        public string ReceiverCountry { get; set; }
        [Required(ErrorMessage = "Lütfen ülke giriniz.")]
        public int ReceiverCountryId { get; set; }
        public string ReceiverPhoneNumber { get; set; }
        public string ReceiverFaxNumber { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverWebSite { get; set; }
        public string ReceiverTaxOffice { get; set; }
        public bool IsDeleted { get; set; }
        public byte? Type { get; set; }
        public byte? Status { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsSaveAddress { get; set; }
    }
}