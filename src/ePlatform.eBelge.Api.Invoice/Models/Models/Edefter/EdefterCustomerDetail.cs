using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_CustomerDetail")]
    public partial class EdefterCustomerDetail
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneNumberDescription { get; set; }
        [Required]
        [StringLength(100)]
        public string EntityPhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string EntityFaxNumber { get; set; }
        [Required]
        [StringLength(250)]
        public string EntityEmailAddress { get; set; }
        [Required]
        [StringLength(500)]
        public string OrganizationIdentifier { get; set; }
        [Required]
        [StringLength(100)]
        public string OrganizationBuildingNumber { get; set; }
        [Required]
        [StringLength(500)]
        public string OrganizationAddressStreet { get; set; }
        [StringLength(500)]
        public string OrganizationAddressStreet2 { get; set; }
        [Required]
        [StringLength(100)]
        public string OrganizationAddressCity { get; set; }
        [Required]
        [StringLength(100)]
        public string OrganizationAddressZipOrPostalCode { get; set; }
        [Required]
        [StringLength(100)]
        public string OrganizationAddressCountry { get; set; }
        [Required]
        [StringLength(250)]
        public string EntityWebSiteUrl { get; set; }
        [Required]
        [StringLength(250)]
        public string BusinessDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
    }
}
