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
    public class APIpingServerList
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/pingServerList")]
        public static async Task pingServerList(IHttpContext context)
        {
            string resp = "{\r\n  \"cod\": 200,\r\n  \"msg\": \"SUCCESS\",\r\n  \"rst\": {\r\n    \"serverList\": [\r\n      {\r\n        \"rgd\": \"ap-northeast-2\",\r\n        \"rg\": \"GO\",\r\n        \"ip\": \"127.0.0.1\"\r\n      }\r\n    ]\r\n  },\r\n  \"eac\": 0\r\n}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/serverCheck")]
        public static async Task serverCheck(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"serverCheck\":false,\"beforeServerCheck\":false},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
