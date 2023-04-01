//MYSTERY PC SUMMON
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.WebAPI.api.products.normal
{
    class CV062 : ProtoPacket
    {
        string CV062Res()
        {
            string response = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"provideResult\":{\"duplication\":false,\"igs\":{\"c\":\"20-VOICE_JENNY_TINKERBELL\",\"a\":1,\"n\":3656837,\"un\":2863408,\"ia\":false,\"activated\":false},\"rdp\":false,\"cbr\":0.0}},\"eac\":0}";
            return response;
        }
        public override string execute()
        {
            return CV062Res();
        }

    }
}
