using BlackRevivalServer.Common.Util;
using Grapevine;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.WebAPI
{
    [RestResource]
    public class APImonster
    {
        [RestRoute("Get", "/api/metaData/monster")]
        public static async Task monster(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"monsters\":[{\"cod\":0,\"msc\":0,\"aft\":[],\"fdi\":[],\"sbt\":[],\"mtp\":\"NONE\",\"hlt\":100,\"atk\":10,\"def\":4,\"exp\":0,\"iis\":0,\"ris\":0},{\"cod\":1,\"msc\":1,\"aft\":[6,15,18],\"fdi\":[31105,51004],\"sbt\":[4],\"mtp\":\"LUMIA\",\"hlt\":40,\"atk\":15,\"def\":20,\"exp\":1,\"iis\":180,\"ris\":110},{\"cod\":2,\"msc\":2,\"aft\":[21,1,22],\"fdi\":[31104,51004],\"sbt\":[3],\"mtp\":\"LUMIA\",\"hlt\":40,\"atk\":15,\"def\":20,\"exp\":1,\"iis\":180,\"ris\":110},{\"cod\":3,\"msc\":3,\"aft\":[7,20,12],\"fdi\":[32004,31007],\"sbt\":[2],\"mtp\":\"LUMIA\",\"hlt\":60,\"atk\":20,\"def\":40,\"exp\":1,\"iis\":180,\"ris\":110},{\"cod\":4,\"msc\":4,\"aft\":[9,10,3],\"fdi\":[14002,51001],\"sbt\":[2,4],\"mtp\":\"LUMIA\",\"hlt\":100,\"atk\":30,\"def\":50,\"exp\":2,\"iis\":180,\"ris\":140},{\"cod\":5,\"msc\":5,\"aft\":[8,13,4],\"fdi\":[51007,51001],\"sbt\":[2,3],\"mtp\":\"LUMIA\",\"hlt\":100,\"atk\":30,\"def\":50,\"exp\":2,\"iis\":180,\"ris\":140},{\"cod\":6,\"msc\":6,\"aft\":[14,5,2],\"fdi\":[51005,31013],\"sbt\":[3,4],\"mtp\":\"LUMIA\",\"hlt\":200,\"atk\":60,\"def\":100,\"exp\":3,\"iis\":360,\"ris\":170},{\"cod\":7,\"msc\":7,\"aft\":[19,16,17],\"fdi\":[31004,25001],\"sbt\":[2,3,4],\"mtp\":\"LUMIA\",\"hlt\":150,\"atk\":70,\"def\":120,\"exp\":3,\"iis\":360,\"ris\":170},{\"cod\":8,\"msc\":8,\"aft\":[],\"fdi\":[51036,31019],\"sbt\":[2,3,4],\"mtp\":\"LUMIA\",\"hlt\":350,\"atk\":95,\"def\":160,\"exp\":5,\"iis\":540,\"ris\":9999},{\"cod\":9,\"msc\":9,\"aft\":[11],\"fdi\":[23017,31058,32032,14002],\"sbt\":[2,3,4],\"mtp\":\"LUMIA\",\"hlt\":400,\"atk\":105,\"def\":170,\"exp\":15,\"iis\":540,\"ris\":9999},{\"cod\":101,\"msc\":1,\"aft\":[],\"fdi\":[31007],\"sbt\":[],\"mtp\":\"SEOUL\",\"hlt\":40,\"atk\":10,\"def\":20,\"exp\":1,\"iis\":0,\"ris\":9999},{\"cod\":102,\"msc\":2,\"aft\":[],\"fdi\":[31007],\"sbt\":[],\"mtp\":\"SEOUL\",\"hlt\":40,\"atk\":10,\"def\":20,\"exp\":1,\"iis\":0,\"ris\":9999},{\"cod\":103,\"msc\":3,\"aft\":[],\"fdi\":[31007],\"sbt\":[],\"mtp\":\"SEOUL\",\"hlt\":60,\"atk\":15,\"def\":40,\"exp\":1,\"iis\":0,\"ris\":9999},{\"cod\":104,\"msc\":4,\"aft\":[],\"fdi\":[31010],\"sbt\":[],\"mtp\":\"SEOUL\",\"hlt\":150,\"atk\":30,\"def\":50,\"exp\":4,\"iis\":150,\"ris\":9999},{\"cod\":105,\"msc\":5,\"aft\":[],\"fdi\":[31010],\"sbt\":[],\"mtp\":\"SEOUL\",\"hlt\":150,\"atk\":20,\"def\":50,\"exp\":4,\"iis\":150,\"ris\":9999},{\"cod\":106,\"msc\":6,\"aft\":[],\"fdi\":[31034,53005],\"sbt\":[114],\"mtp\":\"SEOUL\",\"hlt\":400,\"atk\":65,\"def\":100,\"exp\":6,\"iis\":270,\"ris\":9999},{\"cod\":107,\"msc\":7,\"aft\":[],\"fdi\":[31021,53008],\"sbt\":[114],\"mtp\":\"SEOUL\",\"hlt\":350,\"atk\":75,\"def\":120,\"exp\":6,\"iis\":390,\"ris\":9999},{\"cod\":108,\"msc\":8,\"aft\":[],\"fdi\":[],\"sbt\":[110,115,116],\"mtp\":\"SEOUL\",\"hlt\":650,\"atk\":115,\"def\":160,\"exp\":10,\"iis\":450,\"ris\":9999}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
