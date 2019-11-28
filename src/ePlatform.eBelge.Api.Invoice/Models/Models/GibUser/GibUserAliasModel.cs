using ePlatform.eBelge.Api.Models.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class GibUserAliasModel
    {

        public int Id { get; set; }

        public int GibUserId { get; set; }

        public string Alias { get; set; }
        public int? AppType { get; set; }
        public int GibAliasType { get; set; }
        public string Identifier { get; set; }
        public string Title { get; set; }
        public int GibUserType { get; set; }

        public System.DateTime FirstCreationTime { get; set; }

        public System.DateTime AliasCreationTime { get; set; }

        public bool IsActive { get; set; }

        public System.DateTime CreatedDate { get; set; }

        public System.DateTime UpdatedDate { get; set; }

        [NotMapped]
        public GibAliasType GibAliasTypeEnum
        {
            get
            {
                return (GibAliasType)this.GibAliasType;
            }
            set
            {
                this.GibAliasType = Convert.ToInt32(value);
            }
        }
    }
}
