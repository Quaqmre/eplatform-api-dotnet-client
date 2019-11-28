using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    [Table("EDefter_CustomerAccountant")]
    public partial class EdefterCustomerAccountant
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        [Required]
        [StringLength(250)]
        public string AccountantName { get; set; }
        public int AccountantType { get; set; }
        [StringLength(250)]
        public string AccountantTypeOther { get; set; }
        [StringLength(100)]
        public string AccountantBuildingNumber { get; set; }
        [StringLength(500)]
        public string AccountantStreet { get; set; }
        [StringLength(500)]
        public string AccountantAddressStreet2 { get; set; }
        [StringLength(100)]
        public string AccountantCity { get; set; }
        [StringLength(100)]
        public string AccountantCountry { get; set; }
        [StringLength(100)]
        public string AccountantZipOrPostalCode { get; set; }
        [StringLength(100)]
        public string AccountantEngagementType { get; set; }
        [StringLength(250)]
        public string AccountantEngagementDescription { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AccountantEngagementDate { get; set; }
        [StringLength(100)]
        public string AccountantEngagementNumber { get; set; }
        [StringLength(100)]
        public string AccountantContactPhoneNumberDescription { get; set; }
        [StringLength(100)]
        public string AccountantContactPhoneNumber { get; set; }
        [StringLength(100)]
        public string AccountantContactFaxNumber { get; set; }
        [StringLength(250)]
        public string AccountantContactEmailAddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        [StringLength(11)]
        public string Identifier { get; set; }
        [StringLength(500)]
        public string CompanyExecutiveTitle { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AccountantEngagementEndDate { get; set; }
        [StringLength(100)]
        public string TradeRegistryNumber { get; set; }
        [StringLength(100)]
        public string SocialSecurityNumber { get; set; }
        public bool? SendDeclaration { get; set; }
        public int Status { get; set; }
    }
}
