using ePlatform.eBelge.Api.Models.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class GibTokenModel
    {
        public int Id { get; set; }

        public string Identifier { get; set; }

        public string Title { get; set; }

        public int GibUserType { get; set; }

        public System.DateTime CreatedDate { get; set; }

        [NotMapped]
        public GibUserType GibUserTypeEnum
        {
            get
            {
                return (GibUserType)this.GibUserType;
            }
            set
            {
                this.GibUserType = Convert.ToInt32(value);
            }
        }
    }
}
