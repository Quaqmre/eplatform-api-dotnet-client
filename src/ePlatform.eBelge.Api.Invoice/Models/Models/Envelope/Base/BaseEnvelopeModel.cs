using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models.Envelope.Base
{
    public class BaseEnvelopeModel
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int PackageType { get; set; }
        public int TargetSystemUserId { get; set; }
        public int FileSize { get; set; }
        public int TryCount { get; set; }
        public DateTime? LastTryDate { get; set; }
        public string Message { get; set; }
        public string ObjectStorageKey { get; set; }

        public DateTime CreatedDate { get; set; }

        [NotMapped]
        public EnvelopeStatus StatusEnum
        {
            get
            {
                return (EnvelopeStatus)this.Status;
            }
            set
            {
                this.Status = Convert.ToInt32(value);
            }
        }

        [NotMapped]
        public EnvelopeType TypeEnum
        {
            get
            {
                return (EnvelopeType)this.Type;
            }
            set
            {
                this.Type = Convert.ToInt32(value);
            }
        }
        [NotMapped]

        public PackageType PackageTypeEnum
        {
            get
            {
                return (PackageType)this.PackageType;
            }
            set
            {
                this.PackageType = Convert.ToInt32(value);
            }
        }

        // [NotMapped]
        // public EFatura_TaskVievModel Efatura_Task { get; set; }

        [XmlIgnore]
        [IgnoreDataMember]
        [NotMapped]
        public string TableOperations { get; set; }

        public string GibStatus { get; set; }

        public string GibDescription { get; set; }

        [XmlIgnore]
        [IgnoreDataMember]
        [NotMapped]
        public string IdString2 { get; set; }
    }
}
