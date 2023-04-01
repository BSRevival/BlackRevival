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
    public class APItutorial
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/tutorial/list")]
        public static async Task getTutorialList(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"userTutorialList\":[{\"tutorial\":\"TUTORIAL_101\",\"unm\":7562069,\"ttn\":101,\"clr\":true},{\"tutorial\":\"TUTORIAL_201\",\"unm\":7562069,\"ttn\":201,\"clr\":false},{\"tutorial\":\"TUTORIAL_202\",\"unm\":7562069,\"ttn\":202,\"clr\":false},{\"tutorial\":\"TUTORIAL_301\",\"unm\":7562069,\"ttn\":301,\"clr\":false}]},\"eac\":0}";             
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Post", "api/tutorial/startBattle/101")]
        public static async Task postStartTutorialBattle(IHttpContext context)
        {
            string resp = "{\"pds\": [],\"gsl\": [],\"tll\": null,\"uob\": false,\"ht\": false,\"pl\": [],\"sid\": []}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        //Finishing tutorial
        [RestRoute("Get", "api/tutorial/clear/101")]
        public static async Task getClearTutorial(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"reward\":true},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
