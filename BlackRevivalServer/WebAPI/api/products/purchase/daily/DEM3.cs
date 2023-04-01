using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.WebAPI.api.products.daily
{
    class DEM3 : ProtoPacket
    {
        string DEM3Res()
        {
            string response = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"provideResult\":{\"duplication\":false,\"gs\":{\"c\":\"1-EXPERIMENT_MEMORY\",\"a\":3},\"rdp\":false,\"cbr\":0.0}},\"eac\":0}";
            return response;
        }
        public override string execute()
        {
            return DEM3Res();
        }
    }
}
