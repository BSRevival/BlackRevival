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
    public class APIlab
    {
        //This is something we have to come back to in the future
        [RestRoute("Post", "/api/lab/all/2863408")]
        public static async Task getLabResult(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"labProductionList\":[],\"labList\":[{\"unm\":2863408,\"lnm\":34659,\"ltp\":1,\"sbt\":\"CHRISTMARS_HOMEPARTY\",\"acti\":true,\"cps\":\"\",\"igl\":[]},{\"unm\":2863408,\"lnm\":34660,\"ltp\":2,\"sbt\":\"BASIC\",\"acti\":false,\"cps\":\"\",\"igl\":[]},{\"unm\":2863408,\"lnm\":6432562,\"ltp\":4,\"sbt\":\"GENERATION_ROOM\",\"acti\":false,\"cps\":\"\",\"igl\":[]}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/lab/get/6432562")]
        public static async Task getLabChange(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"labInfo\":{\"unm\":2863408,\"lnm\":6432562,\"ltp\":4,\"sbt\":\"GENERATION_ROOM\",\"acti\":false,\"cps\":\"\",\"igl\":[]},\"labProductionInfo\":{\"unm\":2863408,\"lnm\":6432562,\"cps\":\"\",\"pcnt\":2,\"acq\":false,\"nts\":36000,\"igl\":[]}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/lab/set/34660")]
        public static async Task getSetLab(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"labInfo\":{\"unm\":2863408,\"lnm\":34660,\"ltp\":2,\"sbt\":\"BASIC\",\"acti\":false,\"cps\":\"2560856\",\"igl\":[2560856]}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/lab/set/34659")]
        public static async Task getSetLabBackground(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"labInfo\":{\"unm\":2863408,\"lnm\":34659,\"ltp\":1,\"sbt\":\"CHRISTMARS_HOMEPARTY\",\"acti\":true,\"cps\":\"\",\"igl\":[]}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}