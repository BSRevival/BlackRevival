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
    public class APIcolletions
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/colletions/list")]
        public static async Task getCollections(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"userCollectionList\":[{\"unm\":7562069,\"scd\":1000,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1001,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1002,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1003,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1004,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1005,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1006,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1007,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1008,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1100,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1101,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1102,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1103,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1104,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1105,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1106,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1107,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1108,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1109,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1110,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1111,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1200,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1201,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1202,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1203,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1204,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1205,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1206,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1207,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1208,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1209,\"vl\":0,\"rwd\":false,\"cdtm\":1665680828000,\"udtm\":1665680828000},{\"unm\":7562069,\"scd\":1210,\"vl\":0,\"rwd\":false,\"cdtm\":1665680828000,\"udtm\":1665680828000},{\"unm\":7562069,\"scd\":1301,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1302,\"vl\":0,\"rwd\":false,\"cdtm\":1665680827000,\"udtm\":1665680827000},{\"unm\":7562069,\"scd\":1303,\"vl\":0,\"rwd\":false,\"cdtm\":1665680828000,\"udtm\":1665680828000},{\"unm\":7562069,\"scd\":1304,\"vl\":0,\"rwd\":false,\"cdtm\":1665680828000,\"udtm\":1665680828000}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
