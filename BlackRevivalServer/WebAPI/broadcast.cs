﻿using Grapevine;
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
    public class APIbroadcast
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/broadcast/getInfo/{uid}")]
        public static async Task getBroadcastInfo(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        [RestRoute("Get", "/api/broadcast/getAllRoom")]
        public static async Task getBroadcastAllRoom(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"broadcastRoomList\":[]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        
    }
}
