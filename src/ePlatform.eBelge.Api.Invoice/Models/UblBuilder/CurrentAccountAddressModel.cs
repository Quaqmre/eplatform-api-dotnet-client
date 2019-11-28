
using System;

namespace ePlatform.eBelge.Api.Invoice.Models
{
    /// <summary>
    /// İlgili Carinin adres kayıt bilgisi
    /// </summary>
    public partial class CurrentAccountAddressModel
    {
        /// <summary>
        /// ilgili adres kaydının ID bilgisini belirtmektedir.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// İlgili Carinin Id bilgisini belirtmektedir.
        /// </summary>
        public long CurrentAccountId { get; set; }
        /// <summary>
        /// Ülke Id bilgisini belirtmektedir.
        /// </summary>
        public int? CountryId { get; set; }
        /// <summary>
        /// Adres Alanı bilgisini belirtmektedir.
        /// </summary>
        public string AddressName { get; set; }
        /// <summary>
        /// Sokak Adı bilgisini belirtmektedir.
        /// </summary>
        public string StreetName { get; set; }
        /// <summary>
        /// Bina Adı bilgisini belirtmektedir.
        /// </summary>
        public string BuildingName { get; set; }
        /// <summary>
        /// Bina No bilgisini belirtmektedir.
        /// </summary>
        public string BuildingNumber { get; set; }
        /// <summary>
        /// Kapı No bilgisini belirtmektedir.
        /// </summary>
        public string DoorNumber { get; set; }
        /// <summary>
        /// Bölge bilgisini belirtmektedir.
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// Ülke bilgisini belirtmektedir.
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Şehir bilgisini belirtmektedir.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// İlçe/Semt bilgisini belirtmektedir.
        /// </summary>
        public string SubDivisionName { get; set; }
        /// <summary>
        /// Posta Kodu bilgisini belirtmektedir.
        /// </summary>
        public string PostalZone { get; set; }
        /// <summary>
        /// Telefon bilgisini belirtmektedir.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Fax bilgisini belirtmektedir.
        /// </summary>
        public string FaxNumber { get; set; }
        /// <summary>
        /// E-mail bilgisini belirtmektedir.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Website bilgisini belirtmektedir.
        /// </summary>
        public string WebSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDefault { get; set; }
        /// <summary>
        /// Şube Id'si
        /// </summary>
        public long BranchId { get; set; }

        public DateTime CreateDate { get; set; }

        public byte Status { get; set; }
        public string CurrentAccountIdentifier { get; set; }
        public string CurrentAccountName { get; set; }
        public string CurrentAccountTaxOffice { get; set; }
        public string CurrentAccountSurname { get; set; }
        public string CurrentAccountRegistrationNumber { get; set; }
    }
}
