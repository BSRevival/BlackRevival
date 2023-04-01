using BlackRevivalServer.Common.Util;
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
    public class APIMetaDataLeague
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/league")]
        public static async Task league(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"leaguers\":[{\"cod\":0,\"lgt\":0,\"rpu\":0,\"wgr\":0.0,\"ltd\":0,\"nup\":0,\"lub\":0},{\"cod\":1,\"lgt\":1,\"rpu\":59,\"wgr\":0.0,\"ltd\":1,\"nup\":0,\"lub\":0},{\"cod\":2,\"lgt\":1,\"rpu\":119,\"wgr\":0.04,\"ltd\":1,\"nup\":0,\"lub\":4000},{\"cod\":3,\"lgt\":1,\"rpu\":179,\"wgr\":0.08,\"ltd\":1,\"nup\":0,\"lub\":4000},{\"cod\":4,\"lgt\":1,\"rpu\":239,\"wgr\":0.12,\"ltd\":1,\"nup\":0,\"lub\":4000},{\"cod\":5,\"lgt\":1,\"rpu\":299,\"wgr\":0.16,\"ltd\":1,\"nup\":0,\"lub\":4000},{\"cod\":6,\"lgt\":1,\"rpu\":379,\"wgr\":0.2,\"ltd\":2,\"nup\":0,\"lub\":12000},{\"cod\":7,\"lgt\":1,\"rpu\":459,\"wgr\":0.24,\"ltd\":2,\"nup\":0,\"lub\":5000},{\"cod\":8,\"lgt\":1,\"rpu\":539,\"wgr\":0.28,\"ltd\":2,\"nup\":0,\"lub\":5000},{\"cod\":9,\"lgt\":1,\"rpu\":619,\"wgr\":0.32,\"ltd\":2,\"nup\":0,\"lub\":5000},{\"cod\":10,\"lgt\":1,\"rpu\":699,\"wgr\":0.36,\"ltd\":2,\"nup\":0,\"lub\":5000},{\"cod\":11,\"lgt\":1,\"rpu\":799,\"wgr\":0.4,\"ltd\":3,\"nup\":0,\"lub\":15000},{\"cod\":12,\"lgt\":1,\"rpu\":899,\"wgr\":0.44,\"ltd\":3,\"nup\":0,\"lub\":6000},{\"cod\":13,\"lgt\":1,\"rpu\":999,\"wgr\":0.48,\"ltd\":3,\"nup\":0,\"lub\":6000},{\"cod\":14,\"lgt\":1,\"rpu\":1099,\"wgr\":0.52,\"ltd\":3,\"nup\":0,\"lub\":6000},{\"cod\":15,\"lgt\":1,\"rpu\":1199,\"wgr\":0.56,\"ltd\":3,\"nup\":0,\"lub\":6000},{\"cod\":16,\"lgt\":1,\"rpu\":1319,\"wgr\":0.6,\"ltd\":4,\"nup\":0,\"lub\":18000},{\"cod\":17,\"lgt\":1,\"rpu\":1439,\"wgr\":0.64,\"ltd\":4,\"nup\":0,\"lub\":7000},{\"cod\":18,\"lgt\":1,\"rpu\":1559,\"wgr\":0.68,\"ltd\":4,\"nup\":0,\"lub\":7000},{\"cod\":19,\"lgt\":1,\"rpu\":1679,\"wgr\":0.72,\"ltd\":4,\"nup\":0,\"lub\":7000},{\"cod\":20,\"lgt\":1,\"rpu\":1799,\"wgr\":0.76,\"ltd\":4,\"nup\":0,\"lub\":7000},{\"cod\":21,\"lgt\":1,\"rpu\":1949,\"wgr\":0.8,\"ltd\":5,\"nup\":0,\"lub\":21000},{\"cod\":22,\"lgt\":1,\"rpu\":2099,\"wgr\":0.84,\"ltd\":5,\"nup\":0,\"lub\":8000},{\"cod\":23,\"lgt\":1,\"rpu\":2249,\"wgr\":0.88,\"ltd\":5,\"nup\":0,\"lub\":8000},{\"cod\":24,\"lgt\":1,\"rpu\":2399,\"wgr\":0.92,\"ltd\":5,\"nup\":0,\"lub\":8000},{\"cod\":25,\"lgt\":1,\"rpu\":2549,\"wgr\":0.96,\"ltd\":5,\"nup\":0,\"lub\":8000},{\"cod\":26,\"lgt\":2,\"rpu\":2649,\"wgr\":1.0,\"ltd\":6,\"nup\":0,\"lub\":40000},{\"cod\":27,\"lgt\":2,\"rpu\":2749,\"wgr\":1.0,\"ltd\":6,\"nup\":0,\"lub\":0},{\"cod\":28,\"lgt\":2,\"rpu\":2849,\"wgr\":1.0,\"ltd\":6,\"nup\":0,\"lub\":0},{\"cod\":29,\"lgt\":2,\"rpu\":2949,\"wgr\":1.0,\"ltd\":6,\"nup\":0,\"lub\":0},{\"cod\":30,\"lgt\":2,\"rpu\":3049,\"wgr\":1.0,\"ltd\":6,\"nup\":0,\"lub\":0},{\"cod\":31,\"lgt\":2,\"rpu\":3149,\"wgr\":1.0,\"ltd\":7,\"nup\":0,\"lub\":0},{\"cod\":32,\"lgt\":2,\"rpu\":3249,\"wgr\":1.0,\"ltd\":7,\"nup\":0,\"lub\":0},{\"cod\":33,\"lgt\":2,\"rpu\":3349,\"wgr\":1.0,\"ltd\":7,\"nup\":0,\"lub\":0},{\"cod\":34,\"lgt\":2,\"rpu\":3449,\"wgr\":1.0,\"ltd\":7,\"nup\":0,\"lub\":0},{\"cod\":35,\"lgt\":2,\"rpu\":3549,\"wgr\":1.0,\"ltd\":7,\"nup\":0,\"lub\":0},{\"cod\":36,\"lgt\":2,\"rpu\":3649,\"wgr\":1.0,\"ltd\":8,\"nup\":5,\"lub\":0},{\"cod\":37,\"lgt\":2,\"rpu\":3749,\"wgr\":1.0,\"ltd\":8,\"nup\":0,\"lub\":0},{\"cod\":38,\"lgt\":2,\"rpu\":3849,\"wgr\":1.0,\"ltd\":8,\"nup\":0,\"lub\":0},{\"cod\":39,\"lgt\":2,\"rpu\":3949,\"wgr\":1.0,\"ltd\":8,\"nup\":0,\"lub\":0},{\"cod\":40,\"lgt\":2,\"rpu\":4049,\"wgr\":1.0,\"ltd\":8,\"nup\":0,\"lub\":0},{\"cod\":41,\"lgt\":2,\"rpu\":4149,\"wgr\":1.0,\"ltd\":9,\"nup\":10,\"lub\":0},{\"cod\":42,\"lgt\":2,\"rpu\":4249,\"wgr\":1.0,\"ltd\":9,\"nup\":0,\"lub\":0},{\"cod\":43,\"lgt\":2,\"rpu\":4349,\"wgr\":1.0,\"ltd\":9,\"nup\":0,\"lub\":0},{\"cod\":44,\"lgt\":2,\"rpu\":4449,\"wgr\":1.0,\"ltd\":9,\"nup\":0,\"lub\":0},{\"cod\":45,\"lgt\":2,\"rpu\":4549,\"wgr\":1.0,\"ltd\":9,\"nup\":0,\"lub\":0},{\"cod\":46,\"lgt\":2,\"rpu\":4749,\"wgr\":1.0,\"ltd\":10,\"nup\":15,\"lub\":0},{\"cod\":47,\"lgt\":2,\"rpu\":4949,\"wgr\":1.0,\"ltd\":10,\"nup\":0,\"lub\":0},{\"cod\":48,\"lgt\":2,\"rpu\":5149,\"wgr\":1.0,\"ltd\":10,\"nup\":0,\"lub\":0},{\"cod\":49,\"lgt\":2,\"rpu\":5349,\"wgr\":1.0,\"ltd\":10,\"nup\":0,\"lub\":0},{\"cod\":50,\"lgt\":2,\"rpu\":2147483647,\"wgr\":1.0,\"ltd\":10,\"nup\":0,\"lub\":0}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
