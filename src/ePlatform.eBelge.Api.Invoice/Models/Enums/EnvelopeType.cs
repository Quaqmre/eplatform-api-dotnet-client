using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ePlatform.eBelge.Api.Models.Models.Enums
{
    public enum EnvelopeType
    {
        [EnumText("Fatura")]
        SenderEnvelope = 0,
        [EnumText("Uygulama Yanıtı")]
        PostboxEnvelope = 1,

        SystemEnvelope = 2,

        UserEnvelope = 3,
    }
}
