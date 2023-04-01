using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.WebAPI.api.products.purchase.normal
{
    class RLBP006 : ProtoPacket
    {
        string RLBP006Res()
        {
            string response = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"provideResult\":{\"duplication\":false,\"prt\":[{\"duplication\":false,\"rgs\":{\"c\":\"7-DETECT\",\"a\":5,\"rgg\":{\"grd\":\"C\",\"crd\":10},\"slm\":false,\"rfb\":0},\"igs\":{\"c\":\"7-DETECT\",\"a\":1,\"n\":351783,\"un\":2863408,\"ia\":false,\"ed\":1666192894317,\"activated\":false},\"rdp\":false,\"cbr\":1.0},{\"duplication\":false,\"rgs\":{\"c\":\"8-BEARPOINT\",\"a\":15,\"rgg\":{\"grd\":\"C\",\"crd\":10},\"slm\":false,\"rfb\":0},\"igs\":{\"c\":\"8-BEARPOINT\",\"a\":565,\"n\":2307304,\"un\":2863408,\"ia\":false,\"activated\":false},\"rdp\":false,\"cbr\":1.0},{\"duplication\":false,\"rgs\":{\"c\":\"7-RESTORATION\",\"a\":5,\"rgg\":{\"grd\":\"C\",\"crd\":10},\"slm\":false,\"rfb\":0},\"igs\":{\"c\":\"7-RESTORATION\",\"a\":1,\"n\":2339820,\"un\":2863408,\"ia\":false,\"ed\":1666192894323,\"activated\":false},\"rdp\":false,\"cbr\":1.0},{\"duplication\":false,\"rgs\":{\"c\":\"35-CATHY-A_GROWTH\",\"a\":3,\"rgg\":{\"grd\":\"B\",\"crd\":10},\"slm\":false,\"rfb\":0},\"igs\":{\"c\":\"35-CATHY-A_GROWTH\",\"a\":3,\"n\":3555837,\"un\":2863408,\"ia\":false,\"activated\":false},\"rdp\":false,\"cbr\":1.0},{\"duplication\":false,\"rgs\":{\"c\":\"7-FINDBULLET\",\"a\":5,\"rgg\":{\"grd\":\"C\",\"crd\":10},\"slm\":false,\"rfb\":0},\"igs\":{\"c\":\"7-FINDBULLET\",\"a\":1,\"n\":361000,\"un\":2863408,\"ia\":false,\"ed\":1666192894329,\"activated\":false},\"rdp\":false,\"cbr\":1.0},{\"duplication\":false,\"rgs\":{\"c\":\"7-FINDBULLET\",\"a\":5,\"rgg\":{\"grd\":\"C\",\"crd\":10},\"slm\":false,\"rfb\":0},\"igs\":{\"c\":\"7-FINDBULLET\",\"a\":1,\"n\":361000,\"un\":2863408,\"ia\":false,\"ed\":1666624894000,\"activated\":false},\"rdp\":false,\"cbr\":1.0}],\"rrt\":[{\"duplication\":false,\"gs\":{\"c\":\"1-MILEAGE\",\"a\":0},\"rdp\":false,\"cbr\":0.0},{\"duplication\":false,\"gs\":{\"c\":\"1-CREDIT\",\"a\":0},\"rdp\":false,\"cbr\":0.0},{\"duplication\":false,\"gs\":{\"c\":\"1-BEARPOINT\",\"a\":0},\"rdp\":false,\"cbr\":0.0}],\"rdp\":false,\"cbr\":0.0}},\"eac\":0}";
            return response;
        }
        public override string execute()
        {
            return RLBP006Res();
        }

    }
}







