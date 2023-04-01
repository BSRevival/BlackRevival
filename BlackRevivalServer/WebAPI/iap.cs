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
    public class APIiap
    {
        [RestRoute("Get", "/api/iap/token")]
        public static async Task getVotePhase(IHttpContext context)
        {
            string resp = "{\"cod\":9164,\"msg\":\"PAYMENT_FAIL\",\"rst\":{},\"eac\":0}"; ;
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
