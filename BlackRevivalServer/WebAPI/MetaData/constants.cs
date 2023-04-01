using Grapevine;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Common.Util;

namespace BlackRevivalServer.WebAPI
{
    [RestResource]
    public class APIconstants
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/constants")]
        public static async Task constants(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"FREE_BP_ROULETTE_HOURS\":8},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
