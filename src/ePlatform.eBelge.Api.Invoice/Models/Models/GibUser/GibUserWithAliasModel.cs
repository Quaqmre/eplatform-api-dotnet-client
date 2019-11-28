using System.Collections.Generic;
using ePlatform.eBelge.Api.Models.Models.Enums;

namespace ePlatform.eBelge.Api.Models.Models
{
    public class GibUserWithAliasModel
    {
        public GibUserWithAliasModel()
        {
        }
        public GibUserWithAliasModel(GibTokenModel definition)
        {
            this.Definition = definition;
            this.ReceiverboxAliases = new List<GibUserAliasModel>();
            this.SenderboxAliases = new List<GibUserAliasModel>();
        }

        public GibTokenModel Definition
        {
            get;
            set;
        }

        public List<GibUserAliasModel> ReceiverboxAliases
        {
            get;
            set;
        }

        public List<GibUserAliasModel> SenderboxAliases
        {
            get;
            set;
        }

        public void AddAlias(GibUserAliasModel alias)
        {
            if (alias.GibAliasTypeEnum == GibAliasType.Recipient)
            {
                this.ReceiverboxAliases.Add(alias);

            }
            else if (alias.GibAliasTypeEnum == GibAliasType.Sender)
            {
                this.SenderboxAliases.Add(alias);
            }
        }
    }
}
