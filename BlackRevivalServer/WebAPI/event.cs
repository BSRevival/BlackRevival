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
    public class APIevent
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/event")]
        public static async Task getEventList(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"attendanceEventRecords\":[{\"eid\":1,\"cnt\":3,\"atv\":false,\"sd\":1537475371000,\"lad\":1539345962000,\"ed\":1539529200000,\"rwd\":false},{\"eid\":5,\"cnt\":3,\"atv\":false,\"sd\":1614795872000,\"lad\":1665760840000,\"ed\":1667660399000,\"rwd\":false}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
