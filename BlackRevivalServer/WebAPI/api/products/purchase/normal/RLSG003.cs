//MYSTERY PC SUMMON
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.WebAPI.api.products.normal
{
    class RLSG003 : ProtoPacket
    {
        string RLSG003Res()
        {
            //"c" : "17-FOREST_N" is the product we got from the gacha
            //"crd":50 credits earned for doing a summon
            string response = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"provideResult\":{\"duplication\":false,\"prt\":[{\"duplication\":false,\"rgs\":{\"c\":\"17-FOREST_N\",\"a\":1,\"rgg\":{\"grd\":\"A\",\"crd\":50},\"slm\":false,\"rfb\":0},\"igs\":{\"c\":\"17-FOREST_N\",\"a\":1,\"n\":3555876,\"un\":2863408,\"ia\":false,\"activated\":false},\"rdp\":false,\"cbr\":1.0}],\"rrt\":[{\"duplication\":false,\"gs\":{\"c\":\"1-MILEAGE\",\"a\":1},\"rdp\":false,\"cbr\":0.0},{\"duplication\":false,\"gs\":{\"c\":\"1-CREDIT\",\"a\":0},\"rdp\":false,\"cbr\":0.0},{\"duplication\":false,\"gs\":{\"c\":\"1-BEARPOINT\",\"a\":0},\"rdp\":false,\"cbr\":0.0}],\"rdp\":false,\"cbr\":0.0}},\"eac\":0}";
            return response;
        }
        public override string execute()
        {
            return RLSG003Res();
        }

    }
}
