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
    public class APIsignatures
    {

        [RestRoute("Get", "/api/signature/decompose/{charId}/{dnaType}/{quantity}")]
        public static async Task dnaDecompose(IHttpContext context)
        {
            string resp = "";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);


            //If decompose fails for what ever reason
            //string resp = "{\"cod\":9601,\"msg\":\"NOT_ENOUGH_DNA_COUNT\",\"rst\":{},\"eac\":0}";
            /*
            context.Response.StatusCode = 9601;
            context.Response.ContentType = "application/json";
            string Msg = "NOT_ENOUGH_DNA_COUNT";
            context.Response.ContentLength64 = Msg.Length;
            Log.Debug(Helpers.format_json(Msg));
            await context.Response.SendResponseAsync(Msg);
            */

        }

        [RestRoute("Post", "/api/signature/decompose/batch")]
        public static async Task dnaDecomposeBatch(IHttpContext context)
        {
            string resp = "";
            //This here is an example json array of all DNAs we want to decompose from bulk decompose
            /*
             [
             {
               "n": 3577185,
               "un": 2863408, - {uid}
               "ia": false,
               "ed": -62135596800000,
               "a": 1,  - Amount
               "c": "35-SILVIA-B_GROWTH", - Which DNA
               "goodsType": 35,
               "subType": "SILVIA-B_GROWTH"
             },
             {
               "n": 3635693,
               "un": 2863408,
               "ia": false,
               "ed": -62135596800000,
               "a": 2,
               "c": "35-DAILIN-A_GROWTH",
               "goodsType": 35,
               "subType": "DAILIN-A_GROWTH"
             },
             {
               "n": 3014277,
               "un": 2863408,
               "ia": false,
               "ed": -62135596800000,
               "a": 2,
               "c": "35-DAILIN-B_GROWTH",
               "goodsType": 35,
               "subType": "DAILIN-B_GROWTH"
             }
           ]
           */
            //After this we then update the users dnaInventory with the updated outcome from their dna amounts
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
            //updateDnaInvetory();
        }

        [RestRoute("Get", "/api/signature/upgrade/{charId}/{dnaType}")]
        public static async Task dnaUpgrade(IHttpContext context)
        {
            //Usually here we would return the update to dnaIventory and also update characterSignatureList
            //We should probably create update dnaIventory as a seprate function and call it here when upgrading
            string resp = "{\"characterSignatureList\":[{\"unm\":2863408,\"cc\":29,\"ats\":101,\"att\":101,\"lv\":1},{\"unm\":2863408,\"cc\":29,\"ats\":101,\"att\":201,\"lv\":0},{\"unm\":2863408,\"cc\":29,\"ats\":101,\"att\":301,\"lv\":0},{\"unm\":2863408,\"cc\":29,\"ats\":101,\"att\":401,\"lv\":0}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
            //updateDnaInvetory();

        }
    }
}
