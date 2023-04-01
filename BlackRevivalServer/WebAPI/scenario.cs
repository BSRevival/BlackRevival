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
    public class APIscenario
    {
        
        [RestRoute("Get", "/api/scenario/clearedScenario")]
        public static async Task getClearedScenario(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"tasks\":[{\"unm\":7562069,\"tnm\":10101,\"anm\":1,\"ptn\":0,\"ptp\":0,\"atp\":1,\"pab\":true,\"cct\":0,\"crd\":false},{\"unm\":7562069,\"tnm\":20001,\"anm\":2,\"ptn\":10101,\"ptp\":1,\"atp\":2,\"pab\":false,\"cct\":0,\"crd\":false},{\"unm\":7562069,\"tnm\":30001,\"anm\":1,\"ptn\":0,\"ptp\":0,\"atp\":3,\"pab\":false,\"cct\":0,\"crd\":false},{\"unm\":7562069,\"tnm\":30002,\"anm\":2,\"ptn\":0,\"ptp\":0,\"atp\":3,\"pab\":false,\"cct\":0,\"crd\":false},{\"unm\":7562069,\"tnm\":30003,\"anm\":3,\"ptn\":0,\"ptp\":0,\"atp\":3,\"pab\":false,\"cct\":0,\"crd\":false},{\"unm\":7562069,\"tnm\":30004,\"anm\":4,\"ptn\":0,\"ptp\":0,\"atp\":3,\"pab\":false,\"cct\":0,\"crd\":false},{\"unm\":7562069,\"tnm\":30005,\"anm\":5,\"ptn\":0,\"ptp\":0,\"atp\":3,\"pab\":false,\"cct\":0,\"crd\":false}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
