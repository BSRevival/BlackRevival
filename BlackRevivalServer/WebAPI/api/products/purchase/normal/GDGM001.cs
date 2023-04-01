//MYSTERY PC SUMMON
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.WebAPI.api.products.normal
{
    class GDGM001 : ProtoPacket
    {
        string GDGM001Res()
        {
            string response = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"provideResult\":{\"duplication\":false,\"gs\":{\"c\":\"1-GOLD\",\"a\":5600},\"rdp\":false,\"cbr\":0.0}},\"eac\":0}";
            return response;
        }
        public override string execute()
        {
            return GDGM001Res();
        }
    }
}

