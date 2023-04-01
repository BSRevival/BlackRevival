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
    public class APIMiniLeague
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/miniLeague/current")]
        public static async Task getCurrentMiniLeague(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"miniLeague\":{\"u\":{\"gi\":81280,\"t\":4},\"g\":{\"c\":20,\"t\":4,\"e\":1633186800000},\"m\":{\"u\":2863408,\"n\":\"Lynity\",\"p\":35,\"r\":18,\"w\":1},\"e\":[{\"u\":3116698,\"n\":\"\u6276\u6B87\",\"p\":1755,\"r\":1,\"w\":13},{\"u\":5658628,\"n\":\"\u8D24\u72FC\u6B27\u6B27\",\"p\":1423,\"r\":2,\"w\":4},{\"u\":1499573,\"n\":\"\u304B\u3070\u3057\u307E\",\"p\":674,\"r\":3,\"w\":5},{\"u\":792964,\"n\":\"\uB9AC\uD504\uD06C\uB124\",\"p\":663,\"r\":4,\"w\":2},{\"u\":5372140,\"n\":\"\uB8E8\uD540\uB124\uC2A4\",\"p\":489,\"r\":5,\"w\":1},{\"u\":7149038,\"n\":\"\uC6D0\uCC54\uD604\uC6B0\",\"p\":299,\"r\":6,\"w\":3},{\"u\":5159782,\"n\":\"Sneaky Otter\",\"p\":271,\"r\":7,\"w\":4},{\"u\":2977416,\"n\":\"\u85CD\u8272\u591A\u7459\u6CB3\",\"p\":256,\"r\":8,\"w\":3},{\"u\":3831190,\"n\":\"\u5E7B\u5239\u90A3\",\"p\":238,\"r\":9,\"w\":1},{\"u\":5738228,\"n\":\"cocalime\",\"p\":204,\"r\":10,\"w\":1},{\"u\":277311,\"n\":\"PulgHole\",\"p\":200,\"r\":11,\"w\":2},{\"u\":5711145,\"n\":\"\u96F6\u70DF\u5BB9\",\"p\":160,\"r\":12,\"w\":0},{\"u\":6992494,\"n\":\"\u6C34\u8272\u5E9F\u5F03\u7269\",\"p\":151,\"r\":13,\"w\":1},{\"u\":4488990,\"n\":\"\u767D\u820C\u70CF\",\"p\":123,\"r\":14,\"w\":1},{\"u\":6052646,\"n\":\"\u672A\u95FB\u82B1\u540D1238\",\"p\":104,\"r\":15,\"w\":0},{\"u\":5288953,\"n\":\"\u5FEB\u4E50\u7684\u5200\u5149\u54E5\",\"p\":66,\"r\":16,\"w\":1},{\"u\":3470093,\"n\":\"\u65E0\u5FC3\u68A6\",\"p\":56,\"r\":17,\"w\":0},{\"u\":2863408,\"n\":\"Lynity\",\"p\":35,\"r\":18,\"w\":1},{\"u\":2971022,\"n\":\"Ralky\",\"p\":1,\"r\":19,\"w\":0},{\"u\":5525482,\"n\":\"\u6C5F\u627F\",\"p\":0,\"r\":20,\"w\":0}]},\"newRequestArrived\":true},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/miniLeague/reward")]
        public static async Task getMiniLeagueReward(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"miniLeague\":{\"u\":{\"gi\":97820,\"t\":3},\"g\":{\"c\":4,\"t\":3,\"e\":1666450800000},\"m\":{\"u\":2863408,\"n\":\"Lynity\",\"p\":0,\"r\":4,\"w\":0},\"e\":[{\"u\":388204,\"n\":\">_<\",\"p\":0,\"r\":4,\"w\":0},{\"u\":902263,\"n\":\"\uB0D0\uC544\uD56B\",\"p\":0,\"r\":4,\"w\":0},{\"u\":2863408,\"n\":\"Lynity\",\"p\":0,\"r\":4,\"w\":0},{\"u\":5158251,\"n\":\"Sunmoji\",\"p\":0,\"r\":4,\"w\":0}]}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
