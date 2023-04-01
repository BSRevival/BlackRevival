using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.WebAPI.api.products.purchase.normal
{
    class MSC150 : ProtoPacket
    {
        string MSC150Res()
        {
            //BUY SKIN FROM CREDIT SHOP - MAGICAL GIRL ELEVEN
            string response = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"provideResult\":{\"duplication\":false,\"gs\":{\"c\":\"4-3907\",\"a\":1},\"cs\":{\"unm\":2863408,\"cls\":39,\"ckt\":3907,\"own\":true,\"live\":false,\"setp\":1},\"rdp\":false,\"cbr\":0.0}},\"eac\":0}";
            return response;
        }
        public override string execute()
        {
            return MSC150Res();
        }

    }
}