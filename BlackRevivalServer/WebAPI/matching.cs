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
    public class APImatching
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/ingame/matching/rank")]
        public static async Task startRankMatchmaking(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"isChatRestricted\":false,\"ingameServerInfo\":{\"broadcast\":false,\"t\":\"BattleSeat:2863408:4a111a11c65894c7d5a433a99e72062374c59eac\",\"a\":\"ws://real-lbas-matching-1061112685.us-east-2.elb.amazonaws.com:27900\",\"b\":30,\"rk\":\"0\",\"c\":1,\"ib\":false,\"n\":0}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        //This is something we have to come back to in the future
        [RestRoute("Post", "/api/ingame/matching/normal")]
        public static async Task startNormalMatchmaking(IHttpContext context)
        {
            string documentContents;
            using (Stream receiveStream = context.Request.InputStream)
            {
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    documentContents = readStream.ReadToEnd();
                }
            }
            Log.Debug(Helpers.format_json(documentContents));

            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"isChatRestricted\":false,\"ingameServerInfo\":{\"broadcast\":false,\"t\":\"BattleSeat:2863408:4a111a11c65894c7d5a433a99e72062374c59eac\",\"a\":\"ws://127.0.0.1:27900\",\"b\":30,\"rk\":\"0\",\"c\":1,\"ib\":false,\"n\":0}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
