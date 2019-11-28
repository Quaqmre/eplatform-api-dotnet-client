using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EFatura_CustomerDetail")]
    public partial class EfaturaCustomerDetail
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        public int OwnerType { get; set; }
        [StringLength(150)]
        public string TaxOffice { get; set; }
        [StringLength(150)]
        public string Senderbox { get; set; }
        [StringLength(150)]
        public string Receiverbox { get; set; }
        [Column("EIrsaliyeSenderbox")]
        [StringLength(150)]
        public string EirsaliyeSenderbox { get; set; }
        [Column("EIrsaliyeReceiverbox")]
        [StringLength(150)]
        public string EirsaliyeReceiverbox { get; set; }
        [StringLength(250)]
        public string WebSite { get; set; }
        [StringLength(100)]
        public string AddressCountry { get; set; }
        [StringLength(100)]
        public string AddressCity { get; set; }
        [StringLength(100)]
        public string AddressSubDivisionName { get; set; }
        [StringLength(100)]
        public string AddressStreetName { get; set; }
        [StringLength(100)]
        public string AddressBuildingName { get; set; }
        [StringLength(100)]
        public string AddressBuildingNumber { get; set; }
        [StringLength(100)]
        public string AddressRoom { get; set; }
        [StringLength(100)]
        public string AddressPostalZone { get; set; }
        [StringLength(100)]
        public string AddressRegion { get; set; }
        [StringLength(250)]
        public string Surname { get; set; }
        [StringLength(250)]
        public string MiddleName { get; set; }
        [StringLength(50)]
        public string NameSuffix { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string MersisNo { get; set; }
        [StringLength(50)]
        public string RegisterNumber { get; set; }
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string PhoneType { get; set; }
        [StringLength(100)]
        public string FaxNumber { get; set; }
        [StringLength(250)]
        public string EmailAddress { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
    }
}
