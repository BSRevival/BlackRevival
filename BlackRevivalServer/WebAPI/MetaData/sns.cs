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
    public class APIsns
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/sns")]
        public static async Task sns(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"snsLinks\":[{\"plf\":\"android\",\"lan\":\"ko\",\"lnk\":\"https://bsinstall.page.link/android\"},{\"plf\":\"android\",\"lan\":\"en\",\"lnk\":\"https://bsinstall.page.link/android\"},{\"plf\":\"android\",\"lan\":\"zh_CN\",\"lnk\":\"https://bsinstall.page.link/android\"},{\"plf\":\"android\",\"lan\":\"jp\",\"lnk\":\"https://bsinstall.page.link/android\"},{\"plf\":\"android\",\"lan\":\"zh_TW\",\"lnk\":\"https://bsinstall.page.link/android\"},{\"plf\":\"ios\",\"lan\":\"ko\",\"lnk\":\"https://bsinstall.page.link/iosKr\"},{\"plf\":\"ios\",\"lan\":\"en\",\"lnk\":\"https://bsinstall.page.link/iosEn\"},{\"plf\":\"ios\",\"lan\":\"zh_CN\",\"lnk\":\"http://cnbs.17m3.com/ios_d\"},{\"plf\":\"ios\",\"lan\":\"jp\",\"lnk\":\"https://bsinstall.page.link/iosJp\"},{\"plf\":\"ios\",\"lan\":\"zh_TW\",\"lnk\":\"http://cnbs.17m3.com/ios_d\"},{\"plf\":\"steam\",\"lan\":\"ko\",\"lnk\":\"https://bsinstall.page.link/steam\"},{\"plf\":\"steam\",\"lan\":\"en\",\"lnk\":\"https://bsinstall.page.link/steam\"},{\"plf\":\"steam\",\"lan\":\"zh_CN\",\"lnk\":\"http://cnbs.17m3.com/steam_d\"},{\"plf\":\"steam\",\"lan\":\"jp\",\"lnk\":\"https://bsinstall.page.link/steam\"},{\"plf\":\"steam\",\"lan\":\"zh_TW\",\"lnk\":\"http://cnbs.17m3.com/steam_d\"}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
