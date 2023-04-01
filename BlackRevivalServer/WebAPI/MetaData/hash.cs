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
    public class APIhash
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/hash")]
        public static async Task hash(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"expeditionArea\":2497034735,\"expeditionSkill\":2012329204,\"expeditionEnemyGroup\":445964749,\"webResource\":3495377667,\"signature\":1266420709,\"radarMinMax\":236026859,\"preset\":617090108,\"quest\":2332923331,\"expeditionUnit\":3454411765,\"character\":263111916,\"attendanceEvent\":1006069378,\"avatarBonus\":1460219137,\"miniLeague\":2615343674,\"expeditionEvent\":3861349004,\"skill\":2457923802,\"perk\":952561296,\"tutorial\":4288244954,\"gacha\":479887755,\"constants\":688682256,\"vote\":1770788980,\"expeditionCard\":1975305243,\"expTable\":2693631609,\"item\":2042719681,\"product\":3247076470,\"aglaiaPass\":2606242170,\"league\":3542305455,\"collection\":41317042,\"researcherLevel\":1573952504,\"monster\":2732406530,\"battle\":717919958,\"field\":4156588914,\"unitStat\":4122206408,\"sns\":628188196,\"expeditionMastery\":1138951080},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
