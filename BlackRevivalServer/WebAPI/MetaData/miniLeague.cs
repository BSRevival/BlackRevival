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
    public class APIMetaDataMiniLeague
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/miniLeague")]
        public static async Task miniLeague(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"tier\":[{\"c\":\"0\",\"p\":\"0\",\"r\":\"0\"},{\"c\":\"1\",\"p\":\"10\",\"r\":\"16\"},{\"c\":\"2\",\"p\":\"9\",\"r\":\"15\"},{\"c\":\"3\",\"p\":\"8\",\"r\":\"14\"},{\"c\":\"4\",\"p\":\"7\",\"r\":\"14\"},{\"c\":\"5\",\"p\":\"7\",\"r\":\"14\"},{\"c\":\"6\",\"p\":\"0\",\"r\":\"9\"}],\"rewards\":[{\"t\":1,\"sr\":1,\"er\":1,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":500}},{\"t\":1,\"sr\":2,\"er\":2,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":400}},{\"t\":1,\"sr\":3,\"er\":3,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":350}},{\"t\":1,\"sr\":4,\"er\":4,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":300}},{\"t\":1,\"sr\":5,\"er\":5,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":250}},{\"t\":1,\"sr\":6,\"er\":8,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":200}},{\"t\":1,\"sr\":9,\"er\":14,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":100}},{\"t\":2,\"sr\":1,\"er\":1,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1000}},{\"t\":2,\"sr\":2,\"er\":2,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":800}},{\"t\":2,\"sr\":3,\"er\":3,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":700}},{\"t\":2,\"sr\":4,\"er\":4,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":600}},{\"t\":2,\"sr\":5,\"er\":5,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":500}},{\"t\":2,\"sr\":6,\"er\":8,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":400}},{\"t\":2,\"sr\":9,\"er\":14,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":200}},{\"t\":3,\"sr\":1,\"er\":1,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":2000}},{\"t\":3,\"sr\":2,\"er\":2,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1600}},{\"t\":3,\"sr\":3,\"er\":3,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1400}},{\"t\":3,\"sr\":4,\"er\":4,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1200}},{\"t\":3,\"sr\":5,\"er\":5,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1000}},{\"t\":3,\"sr\":6,\"er\":8,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":800}},{\"t\":3,\"sr\":9,\"er\":14,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":400}},{\"t\":4,\"sr\":1,\"er\":1,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":3000}},{\"t\":4,\"sr\":2,\"er\":2,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":2400}},{\"t\":4,\"sr\":3,\"er\":3,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":2100}},{\"t\":4,\"sr\":4,\"er\":4,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1800}},{\"t\":4,\"sr\":5,\"er\":5,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1500}},{\"t\":4,\"sr\":6,\"er\":8,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1200}},{\"t\":4,\"sr\":9,\"er\":14,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":800}},{\"t\":5,\"sr\":1,\"er\":1,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":4000}},{\"t\":5,\"sr\":2,\"er\":2,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":3200}},{\"t\":5,\"sr\":3,\"er\":3,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":2800}},{\"t\":5,\"sr\":4,\"er\":4,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":2400}},{\"t\":5,\"sr\":5,\"er\":5,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":2000}},{\"t\":5,\"sr\":6,\"er\":8,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1600}},{\"t\":5,\"sr\":9,\"er\":14,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1200}},{\"t\":6,\"sr\":1,\"er\":1,\"r\":{\"c\":\"1-GEM\",\"a\":600}},{\"t\":6,\"sr\":2,\"er\":2,\"r\":{\"c\":\"1-GEM\",\"a\":480}},{\"t\":6,\"sr\":3,\"er\":3,\"r\":{\"c\":\"1-GEM\",\"a\":420}},{\"t\":6,\"sr\":4,\"er\":4,\"r\":{\"c\":\"1-GEM\",\"a\":360}},{\"t\":6,\"sr\":5,\"er\":5,\"r\":{\"c\":\"1-GEM\",\"a\":300}},{\"t\":6,\"sr\":6,\"er\":8,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":2000}},{\"t\":6,\"sr\":9,\"er\":14,\"r\":{\"c\":\"1-BEARPOINT\",\"a\":1600}}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
