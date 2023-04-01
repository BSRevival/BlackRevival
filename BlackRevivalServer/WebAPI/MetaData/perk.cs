﻿using BlackRevivalServer.Common.Util;
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
    public class APIperk
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/perk")]
        public static async Task perk(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"perkData\":[{\"rid\":0,\"pcg\":0,\"plv\":0,\"ski\":0},{\"rid\":10001,\"pcg\":10001,\"plv\":1,\"ski\":7011},{\"rid\":10101,\"pcg\":10001,\"plv\":100,\"ski\":7012},{\"rid\":10102,\"pcg\":10001,\"plv\":100,\"ski\":7013},{\"rid\":10201,\"pcg\":10001,\"plv\":200,\"ski\":7014},{\"rid\":10202,\"pcg\":10001,\"plv\":200,\"ski\":7015},{\"rid\":20001,\"pcg\":20001,\"plv\":1,\"ski\":7021},{\"rid\":20101,\"pcg\":20001,\"plv\":100,\"ski\":7022},{\"rid\":20102,\"pcg\":20001,\"plv\":100,\"ski\":7023},{\"rid\":20201,\"pcg\":20001,\"plv\":200,\"ski\":7024},{\"rid\":20202,\"pcg\":20001,\"plv\":200,\"ski\":7025},{\"rid\":30001,\"pcg\":30001,\"plv\":1,\"ski\":7031},{\"rid\":30101,\"pcg\":30001,\"plv\":100,\"ski\":7032},{\"rid\":30102,\"pcg\":30001,\"plv\":100,\"ski\":7033},{\"rid\":30201,\"pcg\":30001,\"plv\":200,\"ski\":7034},{\"rid\":30202,\"pcg\":30001,\"plv\":200,\"ski\":7035},{\"rid\":40001,\"pcg\":40001,\"plv\":1,\"ski\":7041},{\"rid\":40101,\"pcg\":40001,\"plv\":100,\"ski\":7042},{\"rid\":40102,\"pcg\":40001,\"plv\":100,\"ski\":7043},{\"rid\":40201,\"pcg\":40001,\"plv\":200,\"ski\":7044},{\"rid\":40202,\"pcg\":40001,\"plv\":200,\"ski\":7045},{\"rid\":50001,\"pcg\":50001,\"plv\":1,\"ski\":7051},{\"rid\":50101,\"pcg\":50001,\"plv\":100,\"ski\":7052},{\"rid\":50102,\"pcg\":50001,\"plv\":100,\"ski\":7053},{\"rid\":50201,\"pcg\":50001,\"plv\":200,\"ski\":7054},{\"rid\":50202,\"pcg\":50001,\"plv\":200,\"ski\":7055}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
