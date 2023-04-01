using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Common.Util;
using Serilog;
using Grapevine;

namespace BlackRevivalServer.WebAPI
{
    [RestResource]
    public class Init
    {
        [RestRoute("Get", "/api/init")]
        public async Task InitConnection(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"hideLabyrinth\":false,\"assetDownloadUrlChn\":\"http://127.0.0.1/LIVE\",\"hideContents\":false,\"url\":{\"steamNotice\":\"http://steamcommunity.com/app/690510\",\"helpShiftJa\":\"https://archbears.helpshift.com/a/blacksurvival/?p=all&l=ja\",\"cafeDefault\":\"https://www.facebook.com/BlackSurvivalEN\",\"communityEtc\":\"https://www.reddit.com/r/BlackSurvival/wiki/index\",\"NetEaseDiscord\":\"https://discord.com/invite/rRkJjvzzQw\",\"cafeQQ\":\"https://www.taptap.com/app/67771/topic?type=official\",\"dmmPay\":\"https://point.dmm.com/choice/pay\",\"netEasePay\":\"https://game.boltrend.com/supportPage/en/createForm?abbr=Blacksurvival&qtype=10039\",\"helpShiftEn\":\"https://archbears.helpshift.com/a/blacksurvival/?p=all&l=en\",\"storeChina\":\"http://theblacksurvival.com/\",\"dmmTermPage\":\"http://dmg.archbears.net/termPage04.html\",\"steamCS\":\"https://game.boltrend.com/supportPage/en/services?abbr=Blacksurvival&staffId=4115293\",\"twitch\":\"https://www.twitch.tv/directory/game/Black%20Survival\",\"cafeNaver\":\"https://cafe.naver.com/blacksurvival\",\"dmmFAQ\":\"https://archbears.helpshift.com/a/blacksurvival/?p=web&l=ja\",\"helpShift\":\"https://archbears.helpshift.com\",\"cafeNetEase\":\"https://www.facebook.com/BlackSurvivalEN\",\"steamPatchNote\":\"https://archbears.helpshift.com/a/blacksurvival/?p=all\",\"dmmNotice\":\"https://archbears.helpshift.com/a/blacksurvival/?p=web&l=ja\",\"storeIOS\":\"https://itunes.apple.com/app/beullaegseobaibeol/id1131137981\",\"cafeJapan\":\"https://twitter.com/BlackSurvival_J\",\"storeAndroid\":\"https://play.google.com/store/apps/details?id=com.archbears.bs\",\"steamFAQ\":\"http://steamcommunity.com/app/690510\",\"chinaCS\":\"https://archbears.helpshift.com/a/blacksurvival/?p=all&l=zh\",\"helpShiftAll\":\"https://archbears.helpshift.com/a/blacksurvival/?p=all\"},\"showTransferContents\":true,\"updateRecommended\":false,\"hideUnpack\":false,\"retryRequestPopup\":true,\"hideDownload\":false,\"hideProgress\":false,\"assetDownloadUrlAws\":\"http://127.0.0.1:10080/LIVE\",\"assetDownloadUrlBase\":\"http://127.0.0.1:10080/LIVE\",\"exceptionAreaList\":[]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

    }
}
