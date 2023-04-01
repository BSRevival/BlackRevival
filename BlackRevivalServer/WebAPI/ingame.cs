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
    public class APIingame
    {
        //This is something we have to come back to in the future
        [RestRoute("Post", "/api/ingame/create/12")]
        public static async Task CreateBotGame(IHttpContext context)
        {
            string documentContents;
            using (Stream receiveStream = context.Request.InputStream)
            {
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    documentContents = readStream.ReadToEnd();
                }
            }
            try
            {
                Log.Debug($"REQ Contains Data: \n\r{Helpers.format_json(documentContents)}");
            }
            catch (Exception ex)
            {
            }
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"isChatRestricted\":false,\"ingameServerInfo\":{\"broadcast\":false,\"t\":\"BattleSeat:7562069:036645d100eb29bcb9ff3018083cbf988dfa6fd8\",\"a\":\"ws://127.0.0.1:27900\",\"b\":12,\"rk\":\"0\",\"c\":1,\"ib\":false,\"n\":0}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        [RestRoute("Get", "/api/battle/running/request")]
        public static async Task tryReconnectBattle(IHttpContext context)
        {

            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"battleHost\":\"ws://127.0.0.1:27900\",\"battleSeatKey\":\"BattleSeat:7562069:60402d218547757778e04d344f4d65b9aa5ac5a8\",\"isChatRestricted\":false,\"roomKey\":\"936787\",\"isStarted\":true},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }


        //
    }
}
