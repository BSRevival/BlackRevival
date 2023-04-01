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
    public class APITournament
    {

        [RestRoute("Get", "/api/tournament/enter")]
        public static async Task getTournamentEneter(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"isChatRestricted\":false,\"ingameServerInfo\":{\"broadcast\":false,\"t\":\"BattleSeat:2863408:a6d7571ae1e5075686ee28b259b563488de5227b\",\"a\":\"ws://127.0.0.1:80\",\"b\":50,\"rk\":\"0\",\"c\":1,\"ib\":false,\"n\":0}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/tournament/summary")]
        public static async Task getTournamentSummary(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"leagueBorder\":2,\"stage\":0,\"typeTicketMap\":{\"0\":0,\"1\":0,\"2\":1,\"3\":2,\"4\":4},\"totalParticipant\":0,\"stateList\":[],\"rank\":0,\"serverTime\":1665925735474,\"tournament\":{\"finished\":false,\"md\":1,\"sd\":1666004400000,\"if\":false},\"modeSetting\":{\"sd\":25,\"ms\":2,\"md\":5},\"userEntryList\":[],\"isFinished\":true},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/tournament/shop")]
        public static async Task getTournamentShop(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"showList\":[\"TS001\",\"TS002\",\"TS003\",\"TS004\",\"TS005\",\"TS006\",\"TS007\",\"TS008\",\"TS009\",\"TSLT001\",\"TSLT002\",\"TSLT003\"],\"productList\":[{\"pid\":\"MLTP001\",\"iap\":\"\",\"gs\":{\"c\":\"29-ROZZI_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":10000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP002\",\"iap\":\"\",\"gs\":{\"c\":\"29-ELEVEN_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":10000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP007\",\"iap\":\"\",\"gs\":{\"c\":\"29-DAILIN_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP008\",\"iap\":\"\",\"gs\":{\"c\":\"29-SISSELA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP009\",\"iap\":\"\",\"gs\":{\"c\":\"29-EVA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP003\",\"iap\":\"\",\"gs\":{\"c\":\"29-EMMA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":15000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP004\",\"iap\":\"\",\"gs\":{\"c\":\"29-YUKI_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP005\",\"iap\":\"\",\"gs\":{\"c\":\"29-ADRIANA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP006\",\"iap\":\"\",\"gs\":{\"c\":\"29-LUKE_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"ABTP001\",\"iap\":\"\",\"gs\":{\"c\":\"32-ART_BOOK\",\"a\":1},\"pm\":9,\"pri\":200000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TTP008\",\"iap\":\"\",\"gs\":{\"c\":\"31-TOURNAMENT_SILVIA\",\"a\":1},\"pm\":9,\"pri\":10000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TTP003\",\"iap\":\"\",\"gs\":{\"c\":\"31-TOURNAMENT_CHALLENGER\",\"a\":1},\"pm\":9,\"pri\":5000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TTP002\",\"iap\":\"\",\"gs\":{\"c\":\"31-TOURNAMENT_PIONEER\",\"a\":1},\"pm\":9,\"pri\":7000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TTP001\",\"iap\":\"\",\"gs\":{\"c\":\"31-TOURNAMENT_RULER\",\"a\":1},\"pm\":9,\"pri\":10000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TTP007\",\"iap\":\"\",\"gs\":{\"c\":\"31-TOURNAMENT_XIUKAI\",\"a\":1},\"pm\":9,\"pri\":10000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TTP006\",\"iap\":\"\",\"gs\":{\"c\":\"31-TOURNAMENT_FIORA\",\"a\":1},\"pm\":9,\"pri\":10000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TTP005\",\"iap\":\"\",\"gs\":{\"c\":\"31-TOURNAMENT_HYUNWOO\",\"a\":1},\"pm\":9,\"pri\":10000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TTP004\",\"iap\":\"\",\"gs\":{\"c\":\"31-TOURNAMENT_JACKIE\",\"a\":1},\"pm\":9,\"pri\":10000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485852,\"edtm\":1665655485852},{\"pid\":\"TSLT002\",\"iap\":\"\",\"gs\":{\"c\":\"6-1707\",\"a\":1},\"pm\":9,\"pri\":50000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1614733200000,\"edtm\":4070912400000},{\"pid\":\"TSLT001\",\"iap\":\"\",\"gs\":{\"c\":\"6-2807\",\"a\":1},\"pm\":9,\"pri\":50000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1614733200000,\"edtm\":4070912400000},{\"pid\":\"TSLT003\",\"iap\":\"\",\"gs\":{\"c\":\"6-1210\",\"a\":1},\"pm\":9,\"pri\":50000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1614733200000,\"edtm\":4070912400000},{\"pid\":\"MLTP021\",\"iap\":\"\",\"gs\":{\"c\":\"29-SHOICHI_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP022\",\"iap\":\"\",\"gs\":{\"c\":\"29-TIA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP023\",\"iap\":\"\",\"gs\":{\"c\":\"29-DANIEL_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP024\",\"iap\":\"\",\"gs\":{\"c\":\"29-RIO_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP020\",\"iap\":\"\",\"gs\":{\"c\":\"29-LAURA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP025\",\"iap\":\"\",\"gs\":{\"c\":\"29-AYA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP026\",\"iap\":\"\",\"gs\":{\"c\":\"29-AIDEN_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP027\",\"iap\":\"\",\"gs\":{\"c\":\"29-ELENA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"TS005\",\"iap\":\"\",\"gs\":{\"c\":\"4-1707\",\"a\":1},\"pm\":9,\"pri\":40000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1605661200000,\"edtm\":4070912400000},{\"pid\":\"TS006\",\"iap\":\"\",\"gs\":{\"c\":\"4-2807\",\"a\":1},\"pm\":9,\"pri\":40000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1608598800000,\"edtm\":4070912400000},{\"pid\":\"TS003\",\"iap\":\"\",\"gs\":{\"c\":\"5-1908\",\"a\":1},\"pm\":9,\"pri\":90000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1597798800000,\"edtm\":4070912400000},{\"pid\":\"TS004\",\"iap\":\"\",\"gs\":{\"c\":\"5-208\",\"a\":1},\"pm\":9,\"pri\":90000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1600822800000,\"edtm\":4070912400000},{\"pid\":\"TS001\",\"iap\":\"\",\"gs\":{\"c\":\"5-408\",\"a\":1},\"pm\":9,\"pri\":90000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1592960400000,\"edtm\":4070912400000},{\"pid\":\"TS002\",\"iap\":\"\",\"gs\":{\"c\":\"5-108\",\"a\":1},\"pm\":9,\"pri\":90000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1592960400000,\"edtm\":4070912400000},{\"pid\":\"TS009\",\"iap\":\"\",\"gs\":{\"c\":\"5-1507\",\"a\":1},\"pm\":9,\"pri\":90000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1619571600000,\"edtm\":4070912400000},{\"pid\":\"TS007\",\"iap\":\"\",\"gs\":{\"c\":\"4-1210\",\"a\":1},\"pm\":9,\"pri\":40000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1612141200000,\"edtm\":4070912400000},{\"pid\":\"TS008\",\"iap\":\"\",\"gs\":{\"c\":\"5-1611\",\"a\":1},\"pm\":9,\"pri\":90000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1614733200000,\"edtm\":4070912400000},{\"pid\":\"MLTP010\",\"iap\":\"\",\"gs\":{\"c\":\"29-HYEJIN_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP011\",\"iap\":\"\",\"gs\":{\"c\":\"29-BIANCA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP012\",\"iap\":\"\",\"gs\":{\"c\":\"29-ADELA_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP013\",\"iap\":\"\",\"gs\":{\"c\":\"29-LEON_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP018\",\"iap\":\"\",\"gs\":{\"c\":\"29-CELINE_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP019\",\"iap\":\"\",\"gs\":{\"c\":\"29-ALEX_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP014\",\"iap\":\"\",\"gs\":{\"c\":\"29-WILLIAM_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP015\",\"iap\":\"\",\"gs\":{\"c\":\"29-NICKY_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP016\",\"iap\":\"\",\"gs\":{\"c\":\"29-CHLOE_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851},{\"pid\":\"MLTP017\",\"iap\":\"\",\"gs\":{\"c\":\"29-JOHANN_DEFAULT\",\"a\":1},\"pm\":9,\"pri\":20000.0,\"scp\":-1.0,\"mcp\":-1.0,\"enable\":true,\"dailyShop\":false,\"pc\":\"NONE\",\"pcn\":1,\"bdtm\":1665655485851,\"edtm\":1665655485851}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/tournament/shop/purchase/TTP002")]
        public static async Task getTournamentShopPurchaseTTP002(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"titleCode\":102,\"provideResult\":{\"duplication\":false,\"igs\":{\"c\":\"31-TOURNAMENT_PIONEER\",\"a\":1,\"n\":3578200,\"un\":2863408,\"ia\":false,\"activated\":false},\"rdp\":false,\"cbr\":0.0}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //This is something we have to come back to in the future
        [RestRoute("Post", "/api/tournament/lastUpdate")]
        public static async Task postTournamentLastUpdate(IHttpContext context)
        {
            string resp = "{\"t\": 4,\"lb\": 2,\"s\": 1,\"bp\": null}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/tournament/lastUpdate")]
        public static async Task getTournamentLastUpdate(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"userEntryList\":[]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}