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
    public class APIinven
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/inven")]
        public static async Task inven(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"invenGoodsList\":[{\"c\":\"12-LABYRINTH_TICKET\",\"a\":3,\"n\":3517694,\"un\":7562069,\"ia\":false,\"activated\":false}],\"newRequestArrived\":false,\"tournamentStartDtm\":1665745200000},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
