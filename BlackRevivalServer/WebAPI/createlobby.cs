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
    public class APIcreateLobby
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/ingame/create/{lobbytype}")]
        public static async Task ingame(IHttpContext context)
        {
            string resp = "{\"isChatRestricted\":false,\"ingameServerInfo\":{\"broadcast\":false,\"t\":\"BattleSeat:2863408:6c00c43c54f5443915a9da5335768b3ef0e78693\",\"a\":\"ws://real-lbas-battle-381323980.us-east-2.elb.amazonaws.com:27932/battle-real-oh2\",\"b\":12,\"rk\":\"0\",\"c\":1,\"ib\":false,\"n\":0}},\"eac\":0}"; 
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
