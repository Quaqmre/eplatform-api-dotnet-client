using System;
using System.ComponentModel.DataAnnotations.Schema;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class StatusResponseModel
    {
        public int Status
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public int EnvelopeStatus
        {
            get;
            set;
        }

        public int EnvelopeSummaryStatus
        {
            get;
            set;
        }

        public string EnvelopeMessage
        {
            get;
            set;
        }

        [NotMapped]
        public EnvelopeStatus EnvelopeStatusEnum
        {
            get
            {
                return (EnvelopeStatus)this.EnvelopeStatus;
            }
            set
            {
                this.EnvelopeStatus = Convert.ToInt32(value);
            }
        }
    }
}