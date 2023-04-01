using Grapevine;
using Serilog;
using ChoETL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.Data;
using BlackRevivalServer.Common.Model;
using BlackRevivalServer.Common.Util;
using Microsoft.Data.Sqlite;

namespace BlackRevivalServer.WebAPI
{
    [RestResource]
    public class APIrankings
    {

        //Get season 1's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/1/NONE")]
        public static async Task getSeason1Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;

            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season1 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            //Lets make a check so that if the user isn't accessing the API via the game client, we return null
            /*if context.Request.ContentType = "blacksurvival/json" {
                var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
                var definer = "{\"honor\":";
                var body = json;
                var footer = "},\"eac\":0}";
                string resp = (header + definer + body + footer);
                context.Response.StatusCode = 200;
                context.Response.ContentType = "application/json";
            }
            else {
                 string resp = "<h2>You are not authorised to access this API</h2>";
                 Log.Debug("Invalid Access to request to '/api/rankings/honor/1/NONE'");
                 return;
            }
            */
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get season 2's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/2/NONE")]
        public static async Task getSeason2Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;

            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season2 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get season 2.5's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/25/GO")]
        public static async Task getSeason25Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season25 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get season 3's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/3/NONE")]
        public static async Task getSeason3Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season3 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get season 4's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/4/NONE")]
        public static async Task getSeason4Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season4 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get season 5's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/5/NONE")]
        public static async Task getSeason5Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season5 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get season 6's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/6/NONE")]
        public static async Task getSeason6Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season6 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get season 7's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/7/NONE")]
        public static async Task getSeason7Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season7 LIMIT 100", conn);
                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);

        }

        //Get season 8's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/8/NONE")]
        public static async Task getSeason8Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season8 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get season 9's ranking histiry
        [RestRoute("Get", "/api/rankings/honor/9/NONE")]
        public static async Task getSeason9Ranking(IHttpContext context)
        {

            string connectionstring = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/rankings/rankinghistory.db")}";
            string json = String.Empty;
            using (var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                var comm = new SQLiteCommand("SELECT * FROM Season9 LIMIT 100", conn);

                var reader = comm.ExecuteReader();
                json = Helpers.ConvertDBRequestToJson<Honor>(reader, true);
            }

            var header = "{\"cod\":" + context.Response.StatusCode + ",\"msg\":\"SUCCESS\",\"rst\":";
            var definer = "{\"honor\":";
            var body = json;
            var footer = "},\"eac\":0}";
            string resp = (header + definer + body + footer);
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //Get this seasons current rankings
        [RestRoute("Get", "/api/rankings/top/NONE")]
        public static async Task getRankingsCurrentSeason(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"rankings\":[{\"rank\":1,\"rankPoint\":17098,\"nickname\":\"\u3086\u305A\u306E\u30CD\u30B3\",\"league\":50},{\"rank\":2,\"rankPoint\":10003,\"nickname\":\"\u516B\u54AB\u8885\u8885\",\"league\":50},{\"rank\":3,\"rankPoint\":9108,\"nickname\":\"\u8424\u706B\u591C\u4E4B\u68A6\",\"league\":50},{\"rank\":4,\"rankPoint\":8805,\"nickname\":\"\u80FD\u4E0D\u80FD\u662F\u5E78\u8FD0A\",\"league\":50},{\"rank\":5,\"rankPoint\":7779,\"nickname\":\"\u8D85\u7EDD\u53EF\u7231\u5929\u4F7F\u9171\",\"league\":50},{\"rank\":6,\"rankPoint\":7704,\"nickname\":\"\u70DF\u5377 superman\",\"league\":50},{\"rank\":7,\"rankPoint\":7690,\"nickname\":\"MegaGarchimpo\",\"league\":50},{\"rank\":8,\"rankPoint\":7188,\"nickname\":\"\u96C6\u82D1\u96C6\u67AF\",\"league\":50},{\"rank\":9,\"rankPoint\":7171,\"nickname\":\"\uC800\uCABD\",\"league\":50},{\"rank\":10,\"rankPoint\":6489,\"nickname\":\"\u5341\u516B\u5C81\u7EAF\u60C5\u7537\u9AD8\",\"league\":50},{\"rank\":11,\"rankPoint\":6114,\"nickname\":\"\u6885\u96E8\u660E\u3051\u306E\",\"league\":50},{\"rank\":12,\"rankPoint\":5773,\"nickname\":\"\u6700\u5F3A\u5B64\u72FC\",\"league\":50},{\"rank\":13,\"rankPoint\":5625,\"nickname\":\"\uBA85\uBCF5\uC744 \uC561\uC158 \uBE54\",\"league\":50},{\"rank\":14,\"rankPoint\":5466,\"nickname\":\"\u5316\u8EAB\u6076\u9B54\",\"league\":50},{\"rank\":15,\"rankPoint\":5388,\"nickname\":\"\u5973\u4EBA\u82B1\u4E36\",\"league\":50},{\"rank\":16,\"rankPoint\":5309,\"nickname\":\"Augenstern_\",\"league\":50},{\"rank\":17,\"rankPoint\":5253,\"nickname\":\"\u4E00\u9897\u6D6E\u8E81\u7684\u5FC3\",\"league\":50},{\"rank\":18,\"rankPoint\":5202,\"nickname\":\"\u3067\u3093\u3053\u3046\u305B\u3063\u304B\",\"league\":50},{\"rank\":19,\"rankPoint\":5072,\"nickname\":\"Kanata Ch\",\"league\":50},{\"rank\":20,\"rankPoint\":5013,\"nickname\":\"\uBE14\uB799\uC11C\uBC14\uC774\uBC8C\uC8FD\uB2E4\",\"league\":50},{\"rank\":21,\"rankPoint\":4965,\"nickname\":\"\uB098\uC758\uB2D8\uC740\uAC14\uC2B5\uB2C8\uB2E4\",\"league\":50},{\"rank\":22,\"rankPoint\":4892,\"nickname\":\"\u80CC \u6C34\",\"league\":50},{\"rank\":23,\"rankPoint\":4828,\"nickname\":\"\uD0A4\uB85C\uC798\uD568\",\"league\":50},{\"rank\":24,\"rankPoint\":4826,\"nickname\":\"\u7A97\u82B1\u4E0D\u53EF\u5E7D\u7981\u843D\u971E\",\"league\":50},{\"rank\":25,\"rankPoint\":4801,\"nickname\":\"\u6A0B\u53E3\u8056\u83EF\",\"league\":50},{\"rank\":26,\"rankPoint\":4788,\"nickname\":\"\uB8E8\uBBF8\uC544\uC12C\uC545\uC9C8\uCEA3\uB9D8\",\"league\":50},{\"rank\":27,\"rankPoint\":4746,\"nickname\":\"\u6F02\u6D6E\u4E36\u6CE1\u6CAB\",\"league\":50},{\"rank\":28,\"rankPoint\":4695,\"nickname\":\"\u5929\u5E55\u7EA2\u5C18\",\"league\":50},{\"rank\":29,\"rankPoint\":4661,\"nickname\":\"\uC740\uC2E0\uD22C\uCC99\uB530\uBD09\uB530\uBD09\",\"league\":50},{\"rank\":30,\"rankPoint\":4490,\"nickname\":\"\u4E5D\u9335\u7389\u9732\u4E38\",\"league\":50},{\"rank\":31,\"rankPoint\":4330,\"nickname\":\"\uB108\uB97C \uC0AC\uB791\uD574\",\"league\":50},{\"rank\":32,\"rankPoint\":4327,\"nickname\":\"\u30DE\u30B8\u72E9\u308B\u30D0\u30CA\u30CA\",\"league\":50},{\"rank\":33,\"rankPoint\":4312,\"nickname\":\"\u30A2\u30A4\u30AB\u30EF\u30AB\u30CA\u30DF\",\"league\":50},{\"rank\":34,\"rankPoint\":4261,\"nickname\":\"Gible443\",\"league\":50},{\"rank\":35,\"rankPoint\":4242,\"nickname\":\"\u3042\u307E\u306E \u3072\u306A\",\"league\":50},{\"rank\":36,\"rankPoint\":4212,\"nickname\":\"\uBD90\uBC14\uC2A4\uD2F1\uBD90\uBD90\",\"league\":50},{\"rank\":37,\"rankPoint\":4205,\"nickname\":\"bilibili\u5947\u8FF9\u4E4B\u8A00\",\"league\":50},{\"rank\":38,\"rankPoint\":4178,\"nickname\":\"\u7687\u5929\u540E\u571F\",\"league\":50},{\"rank\":39,\"rankPoint\":4169,\"nickname\":\"\u3088\u304F\u308F\u304B\u3089\u3093\",\"league\":50},{\"rank\":40,\"rankPoint\":4147,\"nickname\":\"\u4F50\u85E4\u8D85\u4EBA\",\"league\":50},{\"rank\":41,\"rankPoint\":4132,\"nickname\":\"\u4E95\u4E0A \u6C5F\u67AB\",\"league\":50},{\"rank\":42,\"rankPoint\":4122,\"nickname\":\"\u7247\u601D\u3044\u306F\u75DB\u307F\u3060\",\"league\":50},{\"rank\":43,\"rankPoint\":4078,\"nickname\":\"\uC591\uC9C0\uBC14\uB978\uB8E8\uBBF8\uC544\uC12C\",\"league\":50},{\"rank\":44,\"rankPoint\":4010,\"nickname\":\"\u4E00\u822C\u7814\u7A76\u54E1\",\"league\":50},{\"rank\":45,\"rankPoint\":3999,\"nickname\":\"\u6749 \u6D66\",\"league\":50},{\"rank\":46,\"rankPoint\":3998,\"nickname\":\"AkiLucky\",\"league\":50},{\"rank\":47,\"rankPoint\":3957,\"nickname\":\"\uAF43\uC774\uD53C\uACE0\uC9C0\uB4EF\uC774\",\"league\":50},{\"rank\":48,\"rankPoint\":3951,\"nickname\":\"\u65E5\u7968\",\"league\":50},{\"rank\":49,\"rankPoint\":3949,\"nickname\":\"\u674F\u4EC1\u306E\u5934\u53F7\u9ED1\u7C89\",\"league\":50},{\"rank\":50,\"rankPoint\":3945,\"nickname\":\"\u767D\u6DA1\",\"league\":50},{\"rank\":51,\"rankPoint\":3905,\"nickname\":\"\uC5C4\uB9C8\uAC00\uC720\uAE30\uD55C\uAC8C\uC784\",\"league\":50},{\"rank\":52,\"rankPoint\":3885,\"nickname\":\"\u5C11\u5973\u7EC8\u672B\u7963\u884C\",\"league\":50},{\"rank\":53,\"rankPoint\":3848,\"nickname\":\"\u4E5D\u689D\u55AA\u79CB\",\"league\":50},{\"rank\":54,\"rankPoint\":3847,\"nickname\":\"\u4E8E\u963F\u963F\",\"league\":50},{\"rank\":55,\"rankPoint\":3844,\"nickname\":\"\u767D\u826Fi\",\"league\":50},{\"rank\":56,\"rankPoint\":3735,\"nickname\":\"\u84DD\u8272\u9AA8\u5934_\",\"league\":50},{\"rank\":57,\"rankPoint\":3726,\"nickname\":\"\uB3C4\uCE58\uB3C4\uCE58\uACE0\uC2B4\uB3C4\uCE58\",\"league\":50},{\"rank\":58,\"rankPoint\":3712,\"nickname\":\"si794\",\"league\":50},{\"rank\":59,\"rankPoint\":3709,\"nickname\":\"\u307F\u308B\u304F\u3082\u3061\",\"league\":50},{\"rank\":60,\"rankPoint\":3673,\"nickname\":\"\u5F69\u8679\u5C71\u8854\u597D\u6708\u6765\",\"league\":50},{\"rank\":61,\"rankPoint\":3666,\"nickname\":\"\u6E8F\u6E34\u6E34\",\"league\":50},{\"rank\":62,\"rankPoint\":3627,\"nickname\":\"\u4E09\u7396\u306E\u66FF\u8EAB\",\"league\":50},{\"rank\":63,\"rankPoint\":3564,\"nickname\":\"\u5143\u6C14\u5C11\u5973\u7279\u857E\u838E\",\"league\":50},{\"rank\":64,\"rankPoint\":3545,\"nickname\":\"remyao\",\"league\":50},{\"rank\":65,\"rankPoint\":3542,\"nickname\":\"ZH_CNSymfms\",\"league\":50},{\"rank\":66,\"rankPoint\":3525,\"nickname\":\"\u534A\u591C\u4E09\u66F4\u4E48\u4E48\u54D2\",\"league\":50},{\"rank\":67,\"rankPoint\":3525,\"nickname\":\"\u5E05\u5F97\u4E36\u88AB\u4EBAkan\",\"league\":50},{\"rank\":68,\"rankPoint\":3469,\"nickname\":\"\uC624\uB298\uB0A0\uC740\",\"league\":50},{\"rank\":69,\"rankPoint\":3467,\"nickname\":\"\u91CC\u6602\u7684\u884C\u661F\",\"league\":50},{\"rank\":70,\"rankPoint\":3463,\"nickname\":\"\u3070\u3046\u3093\u3069\u3076\u3063\u304F\",\"league\":50},{\"rank\":71,\"rankPoint\":3462,\"nickname\":\"\u304C\u308A\",\"league\":50},{\"rank\":72,\"rankPoint\":3460,\"nickname\":\"\u4E24\u4EEA\u7687\u6708\",\"league\":50},{\"rank\":73,\"rankPoint\":3440,\"nickname\":\"\u6597\u9C7C\u4E36\u4E00\u9C7C\u53CC\u5B50\",\"league\":50},{\"rank\":74,\"rankPoint\":3439,\"nickname\":\"\u30D2\u30E7\u30CC\u304B\u30C0\u30A4\u30EA\u30F3\",\"league\":50},{\"rank\":75,\"rankPoint\":3437,\"nickname\":\"sangoo\",\"league\":50},{\"rank\":76,\"rankPoint\":3434,\"nickname\":\"AntiFaJp\",\"league\":50},{\"rank\":77,\"rankPoint\":3433,\"nickname\":\"AUTRAW\",\"league\":50},{\"rank\":78,\"rankPoint\":3433,\"nickname\":\"the peggies\",\"league\":50},{\"rank\":79,\"rankPoint\":3427,\"nickname\":\"\u620E\u7EF3\",\"league\":50},{\"rank\":80,\"rankPoint\":3425,\"nickname\":\"|\u828B\u5934\u5C31\u662F\u6211|\",\"league\":50},{\"rank\":81,\"rankPoint\":3424,\"nickname\":\"ILL03\",\"league\":50},{\"rank\":82,\"rankPoint\":3412,\"nickname\":\"\u6211\u64E6\u8FD8\u6709\u8FD9\u79CD\",\"league\":50},{\"rank\":83,\"rankPoint\":3399,\"nickname\":\"\u7396\u6631\",\"league\":50},{\"rank\":84,\"rankPoint\":3393,\"nickname\":\"\uC5F0\uC5B4\uD3EC\uC2DD\uC790\",\"league\":50},{\"rank\":85,\"rankPoint\":3388,\"nickname\":\"\u96F6\u9675 \u90A2\u9053\u8363\",\"league\":50},{\"rank\":86,\"rankPoint\":3378,\"nickname\":\"binhee\",\"league\":50},{\"rank\":87,\"rankPoint\":3378,\"nickname\":\"\u4E5D\u5E55OvO\",\"league\":50},{\"rank\":88,\"rankPoint\":3374,\"nickname\":\"\u88C1\u96E8\u7559\u8679\",\"league\":50},{\"rank\":89,\"rankPoint\":3363,\"nickname\":\"\u8F6C\u751F\u4E4B\u5CB8\u4E0A\u8774\u8776\u98DB\",\"league\":50},{\"rank\":90,\"rankPoint\":3362,\"nickname\":\"\u968F\u98CE\u8D70\u9E7F\",\"league\":50},{\"rank\":91,\"rankPoint\":3360,\"nickname\":\"\uC790 \uC9C0\",\"league\":50},{\"rank\":92,\"rankPoint\":3346,\"nickname\":\"\u68E0\u6E34\u6E34\",\"league\":50},{\"rank\":93,\"rankPoint\":3344,\"nickname\":\"RainyHeart\",\"league\":50},{\"rank\":94,\"rankPoint\":3343,\"nickname\":\"\u938F\u67D267\",\"league\":50},{\"rank\":95,\"rankPoint\":3342,\"nickname\":\"\u307E\u308B\u307E\u308B\u30D0\u30CA\u30CA\",\"league\":50},{\"rank\":96,\"rankPoint\":3341,\"nickname\":\"\uC288\uB77C\uCF54\",\"league\":50},{\"rank\":97,\"rankPoint\":3329,\"nickname\":\"\u661F\u7A57QAQ\",\"league\":50},{\"rank\":98,\"rankPoint\":3323,\"nickname\":\"V V\",\"league\":50},{\"rank\":99,\"rankPoint\":3321,\"nickname\":\"\u5C0F\u732A\u4E54\u6CBBi\",\"league\":50},{\"rank\":100,\"rankPoint\":3309,\"nickname\":\"\uB108\uB85C\uD53C\uC5B4\uC624\uB77C\",\"league\":50}],\"myBattleRegion\":{\"sea\":11,\"rmap\":{\"OH\":1}},\"region\":\"GO\",\"myRanking\":{\"rank\":0,\"rankPoint\":606,\"nickname\":\"Lynity\",\"league\":32}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);

        }

        //Get this seasons current rankings for SG server
        [RestRoute("Get", "/api/rankings/top/SG")]
        public static async Task getRankingsCurrentSeasonSG(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"rankings\":[{\"rank\":1,\"rankPoint\":11085,\"nickname\":\"DuongKey\",\"league\":50},{\"rank\":2,\"rankPoint\":9839,\"nickname\":\"디기비기\",\"league\":50},{\"rank\":3,\"rankPoint\":7837,\"nickname\":\"斗鱼的小川\",\"league\":50},{\"rank\":4,\"rankPoint\":5761,\"nickname\":\"Hnganxon\",\"league\":50},{\"rank\":5,\"rankPoint\":4889,\"nickname\":\"Rukkhadevata\",\"league\":50},{\"rank\":6,\"rankPoint\":4749,\"nickname\":\"Dominant Alpha\",\"league\":50},{\"rank\":7,\"rankPoint\":4556,\"nickname\":\">JUST_MONIKA<\",\"league\":50},{\"rank\":8,\"rankPoint\":4474,\"nickname\":\"LadySeiker\",\"league\":50},{\"rank\":9,\"rankPoint\":4242,\"nickname\":\"sadjhsjas\",\"league\":50},{\"rank\":10,\"rankPoint\":3818,\"nickname\":\"Jin Haiba\",\"league\":50},{\"rank\":11,\"rankPoint\":3753,\"nickname\":\"LittleSheep325\",\"league\":50},{\"rank\":12,\"rankPoint\":3701,\"nickname\":\"但凡是过去\",\"league\":50},{\"rank\":13,\"rankPoint\":3646,\"nickname\":\"TakamuraTsubasa\",\"league\":50},{\"rank\":14,\"rankPoint\":3573,\"nickname\":\"璃月丿\",\"league\":50},{\"rank\":15,\"rankPoint\":3573,\"nickname\":\"童德希 Duhie\",\"league\":50},{\"rank\":16,\"rankPoint\":3563,\"nickname\":\"~ Alice ~\",\"league\":50},{\"rank\":17,\"rankPoint\":3540,\"nickname\":\"Sharkkkkkk\",\"league\":50},{\"rank\":18,\"rankPoint\":3476,\"nickname\":\"FF15太好玩了\",\"league\":50},{\"rank\":19,\"rankPoint\":3397,\"nickname\":\"NANAR2\",\"league\":50},{\"rank\":20,\"rankPoint\":3394,\"nickname\":\"森鴎外\",\"league\":50},{\"rank\":21,\"rankPoint\":3354,\"nickname\":\"KillUByBlunt\",\"league\":50},{\"rank\":22,\"rankPoint\":3318,\"nickname\":\"SheeshSilvia\",\"league\":50},{\"rank\":23,\"rankPoint\":3316,\"nickname\":\"但凡未得到\",\"league\":50},{\"rank\":24,\"rankPoint\":3312,\"nickname\":\"GGOF\",\"league\":50},{\"rank\":25,\"rankPoint\":3274,\"nickname\":\"0613 1202\",\"league\":50},{\"rank\":26,\"rankPoint\":3246,\"nickname\":\"172836a\",\"league\":50},{\"rank\":27,\"rankPoint\":3240,\"nickname\":\"B Ear\",\"league\":50},{\"rank\":28,\"rankPoint\":3216,\"nickname\":\"Quezt02\",\"league\":50},{\"rank\":29,\"rankPoint\":3213,\"nickname\":\"俗尘渺渺\",\"league\":50},{\"rank\":30,\"rankPoint\":3167,\"nickname\":\"Synte\",\"league\":50},{\"rank\":31,\"rankPoint\":3152,\"nickname\":\"V+究极爬\",\"league\":50},{\"rank\":32,\"rankPoint\":3142,\"nickname\":\"자해살디\",\"league\":50},{\"rank\":33,\"rankPoint\":3078,\"nickname\":\"CeliaAdermas\",\"league\":50},{\"rank\":34,\"rankPoint\":3048,\"nickname\":\"YaSaRAh\",\"league\":50},{\"rank\":35,\"rankPoint\":3019,\"nickname\":\"AjiNanda\",\"league\":50},{\"rank\":36,\"rankPoint\":3008,\"nickname\":\"0OoooOoooo\",\"league\":50},{\"rank\":37,\"rankPoint\":2979,\"nickname\":\"PedobeartheFBI\",\"league\":50},{\"rank\":38,\"rankPoint\":2974,\"nickname\":\"Waiiz\",\"league\":50},{\"rank\":39,\"rankPoint\":2965,\"nickname\":\"HungBestOtto\",\"league\":50},{\"rank\":40,\"rankPoint\":2934,\"nickname\":\"Apiput\",\"league\":50},{\"rank\":41,\"rankPoint\":2933,\"nickname\":\"Chocoron\",\"league\":50},{\"rank\":42,\"rankPoint\":2912,\"nickname\":\"ichikasama\",\"league\":50},{\"rank\":43,\"rankPoint\":2912,\"nickname\":\"PonponPinpin\",\"league\":50},{\"rank\":44,\"rankPoint\":2907,\"nickname\":\"PumpkinButt\",\"league\":50},{\"rank\":45,\"rankPoint\":2882,\"nickname\":\"VinterRize\",\"league\":50},{\"rank\":46,\"rankPoint\":2840,\"nickname\":\"丨花見丨\",\"league\":50},{\"rank\":47,\"rankPoint\":2812,\"nickname\":\"绝体绝命の少女\",\"league\":50},{\"rank\":48,\"rankPoint\":2794,\"nickname\":\"孤凌君2\",\"league\":49},{\"rank\":49,\"rankPoint\":2753,\"nickname\":\"N Hue\",\"league\":49},{\"rank\":50,\"rankPoint\":2713,\"nickname\":\"Elves Ilu\",\"league\":49},{\"rank\":51,\"rankPoint\":2688,\"nickname\":\"沒有巴別塔\",\"league\":49},{\"rank\":52,\"rankPoint\":2679,\"nickname\":\"IvKael\",\"league\":49},{\"rank\":53,\"rankPoint\":2668,\"nickname\":\"Mhicaido\",\"league\":49},{\"rank\":54,\"rankPoint\":2667,\"nickname\":\"Alsklan\",\"league\":49},{\"rank\":55,\"rankPoint\":2657,\"nickname\":\"VA0699\",\"league\":49},{\"rank\":56,\"rankPoint\":2618,\"nickname\":\"noellenole\",\"league\":49},{\"rank\":57,\"rankPoint\":2617,\"nickname\":\"二禁突破两百防\",\"league\":49},{\"rank\":58,\"rankPoint\":2613,\"nickname\":\"Speed As Venom\",\"league\":49},{\"rank\":59,\"rankPoint\":2610,\"nickname\":\"msSassy\",\"league\":49},{\"rank\":60,\"rankPoint\":2603,\"nickname\":\"Master Utsuro\",\"league\":49},{\"rank\":61,\"rankPoint\":2579,\"nickname\":\"Pampiezz\",\"league\":48},{\"rank\":62,\"rankPoint\":2570,\"nickname\":\"Enolami\",\"league\":48},{\"rank\":63,\"rankPoint\":2569,\"nickname\":\"zbjnz\",\"league\":48},{\"rank\":64,\"rankPoint\":2552,\"nickname\":\"Nhai\",\"league\":48},{\"rank\":65,\"rankPoint\":2540,\"nickname\":\"Dcogest\",\"league\":48},{\"rank\":66,\"rankPoint\":2531,\"nickname\":\"Pleather\",\"league\":48},{\"rank\":67,\"rankPoint\":2518,\"nickname\":\"KillerBully\",\"league\":48},{\"rank\":68,\"rankPoint\":2503,\"nickname\":\"RinKoP\",\"league\":48},{\"rank\":69,\"rankPoint\":2494,\"nickname\":\"Ginko123\",\"league\":48},{\"rank\":70,\"rankPoint\":2494,\"nickname\":\"DENJIROUS\",\"league\":48},{\"rank\":71,\"rankPoint\":2483,\"nickname\":\"VCristie\",\"league\":48},{\"rank\":72,\"rankPoint\":2478,\"nickname\":\"狽音ウルシ\",\"league\":48},{\"rank\":73,\"rankPoint\":2472,\"nickname\":\"Ferain1773\",\"league\":48},{\"rank\":74,\"rankPoint\":2464,\"nickname\":\"LoxiMist\",\"league\":48},{\"rank\":75,\"rankPoint\":2460,\"nickname\":\"小林夕\",\"league\":48},{\"rank\":76,\"rankPoint\":2456,\"nickname\":\"雨3751\",\"league\":48},{\"rank\":77,\"rankPoint\":2417,\"nickname\":\"ManUChampUCL\",\"league\":48},{\"rank\":78,\"rankPoint\":2408,\"nickname\":\"elainemm\",\"league\":48},{\"rank\":79,\"rankPoint\":2400,\"nickname\":\"Romun\",\"league\":47},{\"rank\":80,\"rankPoint\":2399,\"nickname\":\"ballzenoss\",\"league\":47},{\"rank\":81,\"rankPoint\":2385,\"nickname\":\"crococo\",\"league\":47},{\"rank\":82,\"rankPoint\":2371,\"nickname\":\"BVAM\",\"league\":47},{\"rank\":83,\"rankPoint\":2363,\"nickname\":\"zanum\",\"league\":47},{\"rank\":84,\"rankPoint\":2360,\"nickname\":\"不知火琉花\",\"league\":47},{\"rank\":85,\"rankPoint\":2357,\"nickname\":\"Riosaur\",\"league\":47},{\"rank\":86,\"rankPoint\":2354,\"nickname\":\"MinamotoKou\",\"league\":47},{\"rank\":87,\"rankPoint\":2352,\"nickname\":\"Joshi Kosei\",\"league\":47},{\"rank\":88,\"rankPoint\":2351,\"nickname\":\"俺君\",\"league\":47},{\"rank\":89,\"rankPoint\":2342,\"nickname\":\"kawpile\",\"league\":47},{\"rank\":90,\"rankPoint\":2335,\"nickname\":\"やかしさん~\",\"league\":47},{\"rank\":91,\"rankPoint\":2325,\"nickname\":\"MrBlueMoon\",\"league\":47},{\"rank\":92,\"rankPoint\":2314,\"nickname\":\"Ridou\",\"league\":47},{\"rank\":93,\"rankPoint\":2312,\"nickname\":\"Whoops!\",\"league\":47},{\"rank\":94,\"rankPoint\":2307,\"nickname\":\"自杀ヽShirayuki\",\"league\":47},{\"rank\":95,\"rankPoint\":2303,\"nickname\":\"HaiNguyen07\",\"league\":47},{\"rank\":96,\"rankPoint\":2295,\"nickname\":\"Tomoca\",\"league\":47},{\"rank\":97,\"rankPoint\":2284,\"nickname\":\"OrdinaryM0nster\",\"league\":47},{\"rank\":98,\"rankPoint\":2282,\"nickname\":\"xxhoamixx\",\"league\":47},{\"rank\":99,\"rankPoint\":2279,\"nickname\":\"身高一米八\",\"league\":47},{\"rank\":100,\"rankPoint\":2275,\"nickname\":\"BoBoiBoySolar\",\"league\":47}],\"myBattleRegion\":{\"sea\":11,\"rmap\":{\"OH\":1}},\"region\":\"SG\",\"myRanking\":{\"rank\":0,\"rankPoint\":606,\"nickname\":\"Lynity\",\"league\":32}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);

        }

        //Get this seasons current rankings for OH server
        [RestRoute("Get", "/api/rankings/top/OH")]
        public static async Task getRankingsCurrentSeasonOH(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"rankings\":[{\"rank\":1,\"rankPoint\":8485,\"nickname\":\"Plessii\",\"league\":50},{\"rank\":2,\"rankPoint\":8445,\"nickname\":\"SusAltear\",\"league\":50},{\"rank\":3,\"rankPoint\":7422,\"nickname\":\"Bai Bai\",\"league\":50},{\"rank\":4,\"rankPoint\":6666,\"nickname\":\"BRAINWORMS\",\"league\":50},{\"rank\":5,\"rankPoint\":5144,\"nickname\":\"hands\u30C4\",\"league\":50},{\"rank\":6,\"rankPoint\":4963,\"nickname\":\"\u5361\u4F73\u73C0\",\"league\":50},{\"rank\":7,\"rankPoint\":4697,\"nickname\":\"ChristianKeiger\",\"league\":50},{\"rank\":8,\"rankPoint\":4563,\"nickname\":\"JENN1E7\",\"league\":50},{\"rank\":9,\"rankPoint\":4493,\"nickname\":\"LynnTM\",\"league\":50},{\"rank\":10,\"rankPoint\":4341,\"nickname\":\"\u30A8\u30EB\u30D5\u30A4\",\"league\":50},{\"rank\":11,\"rankPoint\":4155,\"nickname\":\"Nickys Shampoo\",\"league\":50},{\"rank\":12,\"rankPoint\":3858,\"nickname\":\"Loid Forger\",\"league\":50},{\"rank\":13,\"rankPoint\":3751,\"nickname\":\"TPCLLSR\",\"league\":50},{\"rank\":14,\"rankPoint\":3736,\"nickname\":\"Koiwersa\",\"league\":50},{\"rank\":15,\"rankPoint\":3661,\"nickname\":\"NoMeQuieroIr\",\"league\":50},{\"rank\":16,\"rankPoint\":3656,\"nickname\":\"Ari and Dante\",\"league\":50},{\"rank\":17,\"rankPoint\":3473,\"nickname\":\"tib414\",\"league\":50},{\"rank\":18,\"rankPoint\":3430,\"nickname\":\"EternalMouse\",\"league\":50},{\"rank\":19,\"rankPoint\":3403,\"nickname\":\"GameDark\",\"league\":50},{\"rank\":20,\"rankPoint\":3374,\"nickname\":\"\u9ED1\u98DE\u9F99\",\"league\":50},{\"rank\":21,\"rankPoint\":3317,\"nickname\":\"\u6C5F\u79BB\u4E0D\u60F3\u66B4\u6BD9\",\"league\":50},{\"rank\":22,\"rankPoint\":3214,\"nickname\":\"feet\u30C4\",\"league\":50},{\"rank\":23,\"rankPoint\":3209,\"nickname\":\"Spark!e\",\"league\":50},{\"rank\":24,\"rankPoint\":3196,\"nickname\":\"wabisa\",\"league\":50},{\"rank\":25,\"rankPoint\":3185,\"nickname\":\"\u9ED1\u7075\u5C0F\u5E7D\",\"league\":50},{\"rank\":26,\"rankPoint\":3112,\"nickname\":\"Elfymer\",\"league\":50},{\"rank\":27,\"rankPoint\":3089,\"nickname\":\"Elizareta\",\"league\":50},{\"rank\":28,\"rankPoint\":3053,\"nickname\":\"PG_RavenQrow\",\"league\":50},{\"rank\":29,\"rankPoint\":3029,\"nickname\":\"Meowkaiser\",\"league\":50},{\"rank\":30,\"rankPoint\":3012,\"nickname\":\"Rio Minami\",\"league\":50},{\"rank\":31,\"rankPoint\":2993,\"nickname\":\"canaver1\",\"league\":50},{\"rank\":32,\"rankPoint\":2973,\"nickname\":\"StayzenL\",\"league\":50},{\"rank\":33,\"rankPoint\":2884,\"nickname\":\"TooJokes\",\"league\":50},{\"rank\":34,\"rankPoint\":2868,\"nickname\":\"\u4ECA\u5BB5\u662F\u98D8\u9038\u666E\u901A\u82B1\",\"league\":50},{\"rank\":35,\"rankPoint\":2861,\"nickname\":\"Tnice\",\"league\":50},{\"rank\":36,\"rankPoint\":2808,\"nickname\":\"Nym_0s\",\"league\":50},{\"rank\":37,\"rankPoint\":2805,\"nickname\":\"DeIuga\",\"league\":50},{\"rank\":38,\"rankPoint\":2787,\"nickname\":\"AHumanBeingAlive\",\"league\":49},{\"rank\":39,\"rankPoint\":2776,\"nickname\":\"\uC7AC\uD0A4 \uB354 \uB9AC\uD37C\",\"league\":49},{\"rank\":40,\"rankPoint\":2756,\"nickname\":\"\u4F60\u6E38\u771F\u6CA1\u610F\u601D\",\"league\":49},{\"rank\":41,\"rankPoint\":2732,\"nickname\":\"Jfwarriors\",\"league\":49},{\"rank\":42,\"rankPoint\":2696,\"nickname\":\"Her Sun\",\"league\":49},{\"rank\":43,\"rankPoint\":2687,\"nickname\":\"\uC81C\uB85C\uD22C\uB294\",\"league\":49},{\"rank\":44,\"rankPoint\":2678,\"nickname\":\"\u94C1\u5251\u5728\u5FC5\u5F97\u7684\",\"league\":49},{\"rank\":45,\"rankPoint\":2671,\"nickname\":\"EgalLau37\",\"league\":49},{\"rank\":46,\"rankPoint\":2670,\"nickname\":\"Slynxis\",\"league\":49},{\"rank\":47,\"rankPoint\":2641,\"nickname\":\"ButteredRice\",\"league\":49},{\"rank\":48,\"rankPoint\":2640,\"nickname\":\"Tospy\",\"league\":49},{\"rank\":49,\"rankPoint\":2612,\"nickname\":\"Head_Hunter\",\"league\":49},{\"rank\":50,\"rankPoint\":2603,\"nickname\":\"King Zelos\",\"league\":49},{\"rank\":51,\"rankPoint\":2586,\"nickname\":\"Ssaca\",\"league\":48},{\"rank\":52,\"rankPoint\":2575,\"nickname\":\"His Moon\",\"league\":48},{\"rank\":53,\"rankPoint\":2546,\"nickname\":\"PA\u4E00Mk4\",\"league\":48},{\"rank\":54,\"rankPoint\":2497,\"nickname\":\"Vhyki\",\"league\":48},{\"rank\":55,\"rankPoint\":2473,\"nickname\":\"Bai Bai Bai\",\"league\":48},{\"rank\":56,\"rankPoint\":2454,\"nickname\":\"\u4E00\u5251\u6E05\",\"league\":48},{\"rank\":57,\"rankPoint\":2434,\"nickname\":\"Renarrie\",\"league\":48},{\"rank\":58,\"rankPoint\":2410,\"nickname\":\"Lucaros\",\"league\":48},{\"rank\":59,\"rankPoint\":2396,\"nickname\":\"Invictis\",\"league\":47},{\"rank\":60,\"rankPoint\":2393,\"nickname\":\"Androide501\",\"league\":47},{\"rank\":61,\"rankPoint\":2374,\"nickname\":\"SovAlter\",\"league\":47},{\"rank\":62,\"rankPoint\":2362,\"nickname\":\"nightmare2019\",\"league\":47},{\"rank\":63,\"rankPoint\":2354,\"nickname\":\"Ansur\",\"league\":47},{\"rank\":64,\"rankPoint\":2323,\"nickname\":\"\uC548\uC190\uC774\",\"league\":47},{\"rank\":65,\"rankPoint\":2320,\"nickname\":\"1\u5E742\u30F6\u670820\u65E5\",\"league\":47},{\"rank\":66,\"rankPoint\":2307,\"nickname\":\"TTVBTW\",\"league\":47},{\"rank\":67,\"rankPoint\":2276,\"nickname\":\"AzeitonaBr\",\"league\":47},{\"rank\":68,\"rankPoint\":2272,\"nickname\":\"carminemisery\",\"league\":47},{\"rank\":69,\"rankPoint\":2268,\"nickname\":\"\uB3D9\uBB3C\uC218\uC758\uC0AC\",\"league\":47},{\"rank\":70,\"rankPoint\":2259,\"nickname\":\"godfatherRyu\",\"league\":47},{\"rank\":71,\"rankPoint\":2237,\"nickname\":\"ForgottenBush\",\"league\":47},{\"rank\":72,\"rankPoint\":2208,\"nickname\":\"05 25 2000\",\"league\":47},{\"rank\":73,\"rankPoint\":2206,\"nickname\":\"EKikuchi\",\"league\":47},{\"rank\":74,\"rankPoint\":2192,\"nickname\":\"Vivi Ishigami\",\"league\":46},{\"rank\":75,\"rankPoint\":2187,\"nickname\":\"DeadlyStorm\",\"league\":46},{\"rank\":76,\"rankPoint\":2169,\"nickname\":\"Strel0k_66\",\"league\":46},{\"rank\":77,\"rankPoint\":2149,\"nickname\":\"Awerhit\",\"league\":46},{\"rank\":78,\"rankPoint\":2136,\"nickname\":\"SovAIter\",\"league\":46},{\"rank\":79,\"rankPoint\":2130,\"nickname\":\"TimofeevM\",\"league\":46},{\"rank\":80,\"rankPoint\":2112,\"nickname\":\"Hakunay\",\"league\":46},{\"rank\":81,\"rankPoint\":2111,\"nickname\":\"JakeSparrow68\",\"league\":46},{\"rank\":82,\"rankPoint\":2110,\"nickname\":\"SinTyan\",\"league\":46},{\"rank\":83,\"rankPoint\":2109,\"nickname\":\"Pufferfishy\",\"league\":46},{\"rank\":84,\"rankPoint\":2104,\"nickname\":\"Ohiane\",\"league\":46},{\"rank\":85,\"rankPoint\":2099,\"nickname\":\"Kaeiand\",\"league\":46},{\"rank\":86,\"rankPoint\":2090,\"nickname\":\"Chaacha\",\"league\":46},{\"rank\":87,\"rankPoint\":2087,\"nickname\":\"Tlieh\",\"league\":46},{\"rank\":88,\"rankPoint\":2081,\"nickname\":\"\uCC10\uBE75\uBD80\uC778\uB9CC\uB450\",\"league\":46},{\"rank\":89,\"rankPoint\":2079,\"nickname\":\"Emmas Bodywash\",\"league\":46},{\"rank\":90,\"rankPoint\":2077,\"nickname\":\"Zlotz\",\"league\":46},{\"rank\":91,\"rankPoint\":2060,\"nickname\":\"P O S O S\",\"league\":46},{\"rank\":92,\"rankPoint\":2051,\"nickname\":\"BioTCL\",\"league\":46},{\"rank\":93,\"rankPoint\":2036,\"nickname\":\"BGamer29\",\"league\":46},{\"rank\":94,\"rankPoint\":2036,\"nickname\":\"porowek\",\"league\":46},{\"rank\":95,\"rankPoint\":2030,\"nickname\":\"\u89FF\u5FA1\",\"league\":46},{\"rank\":96,\"rankPoint\":2017,\"nickname\":\"YumitoSS\",\"league\":46},{\"rank\":97,\"rankPoint\":2016,\"nickname\":\"KawaiPawsTTV\",\"league\":46},{\"rank\":98,\"rankPoint\":2016,\"nickname\":\"kirigirisam\",\"league\":46},{\"rank\":99,\"rankPoint\":2012,\"nickname\":\"Merimee\",\"league\":46},{\"rank\":100,\"rankPoint\":2012,\"nickname\":\"dokuboku\",\"league\":46}],\"myBattleRegion\":{\"sea\":11,\"rmap\":{\"OH\":1}},\"region\":\"OH\",\"myRanking\":{\"rank\":0,\"rankPoint\":606,\"nickname\":\"Lynity\",\"league\":32}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);

        }

        //Season 10 rankings for OH server
        [RestRoute("Get", "/api/rankings/top/honor/10/OH")]
        public static async Task getRankingsCurrentSeason10OH(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"honor\":[{\"num\":5893,\"ssn\":0,\"sou\":2906382,\"nic\":\"Loid Forger\",\"sop\":13753},{\"num\":5894,\"ssn\":0,\"sou\":4085138,\"nic\":\"JENN1E7\",\"sop\":13423},{\"num\":5895,\"ssn\":0,\"sou\":2937155,\"nic\":\"Plessii\",\"sop\":13407},{\"num\":5896,\"ssn\":0,\"sou\":4231832,\"nic\":\"\u30A8\u30EB\u30D5\u30A4\",\"sop\":11741},{\"num\":5897,\"ssn\":0,\"sou\":1446067,\"nic\":\"ChristianKeiger\",\"sop\":11111},{\"num\":5898,\"ssn\":0,\"sou\":4493582,\"nic\":\"TPCLLSR\",\"sop\":9889},{\"num\":5899,\"ssn\":0,\"sou\":5536156,\"nic\":\"Bai Bai\",\"sop\":9621},{\"num\":5900,\"ssn\":0,\"sou\":3197603,\"nic\":\"Meowkaiser\",\"sop\":9528},{\"num\":5901,\"ssn\":0,\"sou\":4544439,\"nic\":\"Spark!e\",\"sop\":8128},{\"num\":5902,\"ssn\":0,\"sou\":2597549,\"nic\":\"BRAINWORMS\",\"sop\":7644},{\"num\":5903,\"ssn\":0,\"sou\":2868181,\"nic\":\"Slynxis\",\"sop\":7241},{\"num\":5904,\"ssn\":0,\"sou\":4186319,\"nic\":\"SusAltear\",\"sop\":7042},{\"num\":5905,\"ssn\":0,\"sou\":2566338,\"nic\":\"EternalMouse\",\"sop\":6415},{\"num\":5906,\"ssn\":0,\"sou\":5755983,\"nic\":\"Pupsipyoon\",\"sop\":5919},{\"num\":5907,\"ssn\":0,\"sou\":1554996,\"nic\":\"StayzenL\",\"sop\":5640},{\"num\":5908,\"ssn\":0,\"sou\":1672735,\"nic\":\"Koiwersa\",\"sop\":5483},{\"num\":5909,\"ssn\":0,\"sou\":5080078,\"nic\":\"canaver1\",\"sop\":5465},{\"num\":5910,\"ssn\":0,\"sou\":1532731,\"nic\":\"Jfwarriors\",\"sop\":5239},{\"num\":5911,\"ssn\":0,\"sou\":4810170,\"nic\":\"feet\u30C4\",\"sop\":5019},{\"num\":5912,\"ssn\":0,\"sou\":2926330,\"nic\":\"Cloudia Wake\",\"sop\":5004},{\"num\":5913,\"ssn\":0,\"sou\":4933542,\"nic\":\"hands\u30C4\",\"sop\":4874},{\"num\":5914,\"ssn\":0,\"sou\":1597904,\"nic\":\"PA\u4E00Mk4\",\"sop\":4678},{\"num\":5915,\"ssn\":0,\"sou\":3318504,\"nic\":\"05 25 2000\",\"sop\":4650},{\"num\":5916,\"ssn\":0,\"sou\":2972654,\"nic\":\"Marslove\",\"sop\":4569},{\"num\":5917,\"ssn\":0,\"sou\":1475022,\"nic\":\"Renarrie\",\"sop\":4555},{\"num\":5918,\"ssn\":0,\"sou\":6002357,\"nic\":\"goodbyeBS\",\"sop\":4408},{\"num\":5919,\"ssn\":0,\"sou\":6555048,\"nic\":\"Rio Minami\",\"sop\":4366},{\"num\":5920,\"ssn\":0,\"sou\":4410525,\"nic\":\"ERBS Player\",\"sop\":4358},{\"num\":5921,\"ssn\":0,\"sou\":3226396,\"nic\":\"adri\u3067\u3059\u304B?\",\"sop\":4338},{\"num\":5922,\"ssn\":0,\"sou\":1685410,\"nic\":\"\u94C1\u5251\u5728\u5FC5\u5F97\u7684\",\"sop\":4336},{\"num\":5923,\"ssn\":0,\"sou\":6187453,\"nic\":\"cadet isol\",\"sop\":4330},{\"num\":5924,\"ssn\":0,\"sou\":4357153,\"nic\":\"\u4F60\u6E38\u771F\u6CA1\u610F\u601D\",\"sop\":4195},{\"num\":5925,\"ssn\":0,\"sou\":4187036,\"nic\":\"FOF0\",\"sop\":3999},{\"num\":5926,\"ssn\":0,\"sou\":6952989,\"nic\":\"ESOeaAoZB\",\"sop\":3941},{\"num\":5927,\"ssn\":0,\"sou\":6435737,\"nic\":\"\u9ED1\u98DE\u9F99\",\"sop\":3854},{\"num\":5928,\"ssn\":0,\"sou\":4037201,\"nic\":\"Bai Bai Bai\",\"sop\":3844},{\"num\":5929,\"ssn\":0,\"sou\":5932309,\"nic\":\"\uC81C\uB85C\uD22C\uB294\",\"sop\":3822},{\"num\":5930,\"ssn\":0,\"sou\":4689703,\"nic\":\"\u9ED1\u7075\u5C0F\u5E7D\",\"sop\":3798},{\"num\":5931,\"ssn\":0,\"sou\":3156205,\"nic\":\"NoMeQuieroIr\",\"sop\":3779},{\"num\":5932,\"ssn\":0,\"sou\":4843260,\"nic\":\"nightmare2019\",\"sop\":3764},{\"num\":5933,\"ssn\":0,\"sou\":5148946,\"nic\":\"\uC7AC\uD0A4 \uB354 \uB9AC\uD37C\",\"sop\":3751},{\"num\":5934,\"ssn\":0,\"sou\":1034466,\"nic\":\"Tnice\",\"sop\":3746},{\"num\":5935,\"ssn\":0,\"sou\":7286022,\"nic\":\"Nooit\",\"sop\":3714},{\"num\":5936,\"ssn\":0,\"sou\":820183,\"nic\":\"\u6885\u96E8\u660E\u3051\u306E\",\"sop\":3709},{\"num\":5937,\"ssn\":0,\"sou\":7269306,\"nic\":\"\uC790 \uC9C0\",\"sop\":3697},{\"num\":5938,\"ssn\":0,\"sou\":4709615,\"nic\":\"Loluser\",\"sop\":3688},{\"num\":5939,\"ssn\":0,\"sou\":3397414,\"nic\":\"\u604B\u611B\u4E2D\u5815\u5929\u4F7F\",\"sop\":3651},{\"num\":5940,\"ssn\":0,\"sou\":3045195,\"nic\":\"GameDark\",\"sop\":3649},{\"num\":5941,\"ssn\":0,\"sou\":5297721,\"nic\":\"Sinbios\",\"sop\":3642},{\"num\":5942,\"ssn\":0,\"sou\":6992628,\"nic\":\"wowSKZ\",\"sop\":3640},{\"num\":5943,\"ssn\":0,\"sou\":4362619,\"nic\":\"LynnTM\",\"sop\":3608},{\"num\":5944,\"ssn\":0,\"sou\":3232459,\"nic\":\"ButteredRice\",\"sop\":3572},{\"num\":5945,\"ssn\":0,\"sou\":2654201,\"nic\":\"porowek\",\"sop\":3534},{\"num\":5946,\"ssn\":0,\"sou\":4394352,\"nic\":\"Nickys Shampoo\",\"sop\":3512},{\"num\":5947,\"ssn\":0,\"sou\":3000989,\"nic\":\"ForgottenBush\",\"sop\":3478},{\"num\":5948,\"ssn\":0,\"sou\":3330298,\"nic\":\"TimofeevM\",\"sop\":3465},{\"num\":5949,\"ssn\":0,\"sou\":5728444,\"nic\":\"AHumanBeingAlive\",\"sop\":3446},{\"num\":5950,\"ssn\":0,\"sou\":4773163,\"nic\":\"^Baki^\",\"sop\":3443},{\"num\":5951,\"ssn\":0,\"sou\":2853421,\"nic\":\"sweetjp3\",\"sop\":3440},{\"num\":5952,\"ssn\":0,\"sou\":7286019,\"nic\":\"Yami_chan\",\"sop\":3436},{\"num\":5953,\"ssn\":0,\"sou\":4210085,\"nic\":\"AzeitonaBr\",\"sop\":3421},{\"num\":5954,\"ssn\":0,\"sou\":5926008,\"nic\":\"\u5361\u4F73\u73C0\",\"sop\":3369},{\"num\":5955,\"ssn\":0,\"sou\":5252827,\"nic\":\"Ansur\",\"sop\":3298},{\"num\":5956,\"ssn\":0,\"sou\":3593579,\"nic\":\"Nym_0s\",\"sop\":3296},{\"num\":5957,\"ssn\":0,\"sou\":3323863,\"nic\":\"statick\",\"sop\":3277},{\"num\":5958,\"ssn\":0,\"sou\":3009501,\"nic\":\"Her Sun\",\"sop\":3274},{\"num\":5959,\"ssn\":0,\"sou\":4314357,\"nic\":\"Captain Pyro\",\"sop\":3267},{\"num\":5960,\"ssn\":0,\"sou\":4607051,\"nic\":\"Tospy\",\"sop\":3259},{\"num\":5961,\"ssn\":0,\"sou\":2915200,\"nic\":\"VoreMeKirby\",\"sop\":3256},{\"num\":5962,\"ssn\":0,\"sou\":2531378,\"nic\":\"Strel0k_66\",\"sop\":3252},{\"num\":5963,\"ssn\":0,\"sou\":4127553,\"nic\":\"Ari and Dante\",\"sop\":3231},{\"num\":5964,\"ssn\":0,\"sou\":3290952,\"nic\":\"TooJokes\",\"sop\":3227},{\"num\":5965,\"ssn\":0,\"sou\":7166362,\"nic\":\"BloodySnowman\",\"sop\":3225},{\"num\":5966,\"ssn\":0,\"sou\":3275994,\"nic\":\"Elfymer\",\"sop\":3224},{\"num\":5967,\"ssn\":0,\"sou\":7069406,\"nic\":\"\uCC10\uBE75\uBD80\uC778\uB9CC\uB450\",\"sop\":3205},{\"num\":5968,\"ssn\":0,\"sou\":2984426,\"nic\":\"CaptainHaddock\",\"sop\":3202},{\"num\":5969,\"ssn\":0,\"sou\":6741351,\"nic\":\"Danielswife\",\"sop\":3181},{\"num\":5970,\"ssn\":0,\"sou\":2524901,\"nic\":\"\u559D\u9189\u9152\u7684\u5229\u6234\u7433\",\"sop\":3176},{\"num\":5971,\"ssn\":0,\"sou\":4454927,\"nic\":\"RenartTheFox\",\"sop\":3172},{\"num\":5972,\"ssn\":0,\"sou\":3337548,\"nic\":\"SonnieRoxinStan\",\"sop\":3163},{\"num\":5973,\"ssn\":0,\"sou\":7237747,\"nic\":\"Dicetress\",\"sop\":3132},{\"num\":5974,\"ssn\":0,\"sou\":2665606,\"nic\":\"Icedrago\",\"sop\":3128},{\"num\":5975,\"ssn\":0,\"sou\":2857876,\"nic\":\"\uC548\uC190\uC774\",\"sop\":3127},{\"num\":5976,\"ssn\":0,\"sou\":1319817,\"nic\":\"Hwanri\",\"sop\":3120},{\"num\":5977,\"ssn\":0,\"sou\":6860967,\"nic\":\"Kaeiand\",\"sop\":3100},{\"num\":5978,\"ssn\":0,\"sou\":1537891,\"nic\":\"kazurinn\",\"sop\":3091},{\"num\":5979,\"ssn\":0,\"sou\":6510555,\"nic\":\"lliudachicken\",\"sop\":3068},{\"num\":5980,\"ssn\":0,\"sou\":4935741,\"nic\":\"linmitless\",\"sop\":3064},{\"num\":5981,\"ssn\":0,\"sou\":2955328,\"nic\":\"Kawaiipsycho\",\"sop\":3058},{\"num\":5982,\"ssn\":0,\"sou\":3195043,\"nic\":\"Rageki\",\"sop\":3056},{\"num\":5983,\"ssn\":0,\"sou\":4044925,\"nic\":\"TrueVirtuosity\",\"sop\":3055},{\"num\":5984,\"ssn\":0,\"sou\":6178565,\"nic\":\"Boxcars\",\"sop\":3052},{\"num\":5985,\"ssn\":0,\"sou\":4545101,\"nic\":\"\u4E00\u6761\u5343\u68D8\",\"sop\":3046},{\"num\":5986,\"ssn\":0,\"sou\":4862563,\"nic\":\"Ssaca\",\"sop\":3043},{\"num\":5987,\"ssn\":0,\"sou\":6812426,\"nic\":\"moon bunny\",\"sop\":3039},{\"num\":5988,\"ssn\":0,\"sou\":7099330,\"nic\":\"tib414\",\"sop\":3037},{\"num\":5989,\"ssn\":0,\"sou\":2612007,\"nic\":\"N0R0\",\"sop\":3012},{\"num\":5990,\"ssn\":0,\"sou\":4131628,\"nic\":\"_Husk\",\"sop\":3001},{\"num\":5991,\"ssn\":0,\"sou\":4248632,\"nic\":\"SonoSenpai\",\"sop\":2982},{\"num\":5992,\"ssn\":0,\"sou\":5931929,\"nic\":\"BloodRed Night\",\"sop\":2972},{\"num\":5993,\"ssn\":0,\"sou\":1177907,\"nic\":\"Androide501\",\"sop\":2970},{\"num\":5994,\"ssn\":0,\"sou\":7166596,\"nic\":\"liudachickeno\",\"sop\":2966},{\"num\":5995,\"ssn\":0,\"sou\":4138629,\"nic\":\"Deadlife40\",\"sop\":2964},{\"num\":5996,\"ssn\":0,\"sou\":2951591,\"nic\":\"moilensis\",\"sop\":2946},{\"num\":5997,\"ssn\":0,\"sou\":3260251,\"nic\":\"chopppy\",\"sop\":2853},{\"num\":5998,\"ssn\":0,\"sou\":1107833,\"nic\":\"His Moon\",\"sop\":2830},{\"num\":5999,\"ssn\":0,\"sou\":3718600,\"nic\":\"MyBigSword\",\"sop\":2809},{\"num\":6000,\"ssn\":0,\"sou\":7097803,\"nic\":\"O U O\",\"sop\":2791},{\"num\":6001,\"ssn\":0,\"sou\":7284361,\"nic\":\"+LonerVamp+\",\"sop\":2779},{\"num\":6002,\"ssn\":0,\"sou\":5159623,\"nic\":\"YumitoSS\",\"sop\":2777},{\"num\":6003,\"ssn\":0,\"sou\":3372798,\"nic\":\"beatthemkids\",\"sop\":2770},{\"num\":6004,\"ssn\":0,\"sou\":6048481,\"nic\":\"Makise Kurisu\",\"sop\":2748},{\"num\":6005,\"ssn\":0,\"sou\":3927633,\"nic\":\"Lyzhenra\",\"sop\":2745},{\"num\":6006,\"ssn\":0,\"sou\":4440012,\"nic\":\"twtv_arcadialol\",\"sop\":2728},{\"num\":6007,\"ssn\":0,\"sou\":2790270,\"nic\":\"AriaTsuki\",\"sop\":2719},{\"num\":6008,\"ssn\":0,\"sou\":6133394,\"nic\":\"Thanatos403\",\"sop\":2718},{\"num\":6009,\"ssn\":0,\"sou\":3115729,\"nic\":\"JeyKami\",\"sop\":2713},{\"num\":6010,\"ssn\":0,\"sou\":4043435,\"nic\":\"ChrysalisLG\",\"sop\":2701},{\"num\":6011,\"ssn\":0,\"sou\":5159782,\"nic\":\"Erizo Gordito\",\"sop\":2683},{\"num\":6012,\"ssn\":0,\"sou\":6540628,\"nic\":\"I8M RFT38\",\"sop\":2664},{\"num\":6013,\"ssn\":0,\"sou\":2197627,\"nic\":\"Blitzblume\",\"sop\":2647},{\"num\":6014,\"ssn\":0,\"sou\":4919387,\"nic\":\"Lil Peep\",\"sop\":2629},{\"num\":6015,\"ssn\":0,\"sou\":978256,\"nic\":\"Kayspaz15\",\"sop\":2628},{\"num\":6016,\"ssn\":0,\"sou\":5965558,\"nic\":\"Vhyki\",\"sop\":2610},{\"num\":6017,\"ssn\":0,\"sou\":5906609,\"nic\":\"PG_RavenQrow\",\"sop\":2610},{\"num\":6018,\"ssn\":0,\"sou\":3250788,\"nic\":\"AkaDessu\",\"sop\":2609},{\"num\":6019,\"ssn\":0,\"sou\":3135738,\"nic\":\"7 star sword\",\"sop\":2606},{\"num\":6020,\"ssn\":0,\"sou\":4083062,\"nic\":\"Eberth\",\"sop\":2602},{\"num\":6021,\"ssn\":0,\"sou\":5013419,\"nic\":\"Noctsama\",\"sop\":2580},{\"num\":6022,\"ssn\":0,\"sou\":2566732,\"nic\":\"EsteIIe\",\"sop\":2574},{\"num\":6023,\"ssn\":0,\"sou\":6518793,\"nic\":\"Tutsz\",\"sop\":2569},{\"num\":6024,\"ssn\":0,\"sou\":3910069,\"nic\":\"Sayue\",\"sop\":2561},{\"num\":6025,\"ssn\":0,\"sou\":2153127,\"nic\":\"KarlHolligan\",\"sop\":2541},{\"num\":6026,\"ssn\":0,\"sou\":4137567,\"nic\":\"SinTyan\",\"sop\":2522},{\"num\":6027,\"ssn\":0,\"sou\":5899670,\"nic\":\"MOLANG FISHER\",\"sop\":2506},{\"num\":6028,\"ssn\":0,\"sou\":2830418,\"nic\":\"EgalLau37\",\"sop\":2501},{\"num\":6029,\"ssn\":0,\"sou\":5362861,\"nic\":\"1hekill\",\"sop\":2487},{\"num\":6030,\"ssn\":0,\"sou\":4727611,\"nic\":\"Kymir\",\"sop\":2485},{\"num\":6031,\"ssn\":0,\"sou\":6532942,\"nic\":\"_Lie\",\"sop\":2445},{\"num\":6032,\"ssn\":0,\"sou\":2969662,\"nic\":\"Nexxis\",\"sop\":2436},{\"num\":6033,\"ssn\":0,\"sou\":2818080,\"nic\":\"Loutsuki\",\"sop\":2431},{\"num\":6034,\"ssn\":0,\"sou\":4329711,\"nic\":\"Lyrilusc\",\"sop\":2429},{\"num\":6035,\"ssn\":0,\"sou\":6379692,\"nic\":\"ArcanaZanis\",\"sop\":2428},{\"num\":6036,\"ssn\":0,\"sou\":2974190,\"nic\":\"kuroorchid\",\"sop\":2426},{\"num\":6037,\"ssn\":0,\"sou\":4077231,\"nic\":\"MrDrSrJr\",\"sop\":2425},{\"num\":6038,\"ssn\":0,\"sou\":2827892,\"nic\":\"bobie\",\"sop\":2411},{\"num\":6039,\"ssn\":0,\"sou\":4854043,\"nic\":\"Ceresa\",\"sop\":2410},{\"num\":6040,\"ssn\":0,\"sou\":4264196,\"nic\":\"Tlieh\",\"sop\":2410},{\"num\":6041,\"ssn\":0,\"sou\":4188853,\"nic\":\"DeadlyStorm\",\"sop\":2410},{\"num\":6042,\"ssn\":0,\"sou\":5680391,\"nic\":\"ArKade47\",\"sop\":2404},{\"num\":6043,\"ssn\":0,\"sou\":5993817,\"nic\":\"albuqrr\",\"sop\":2402},{\"num\":6044,\"ssn\":0,\"sou\":4546141,\"nic\":\"ll06040\",\"sop\":2393},{\"num\":6045,\"ssn\":0,\"sou\":4507672,\"nic\":\"MrClashRoyale\",\"sop\":2387},{\"num\":6046,\"ssn\":0,\"sou\":6753989,\"nic\":\"Dalsez\",\"sop\":2373},{\"num\":6047,\"ssn\":0,\"sou\":7239685,\"nic\":\"APeruvianGuy\",\"sop\":2369},{\"num\":6048,\"ssn\":0,\"sou\":4424219,\"nic\":\"Antoniour\",\"sop\":2367},{\"num\":6049,\"ssn\":0,\"sou\":5632057,\"nic\":\"godfatherRyu\",\"sop\":2356},{\"num\":6050,\"ssn\":0,\"sou\":4478152,\"nic\":\"YBthree\",\"sop\":2353},{\"num\":6051,\"ssn\":0,\"sou\":2221028,\"nic\":\"Miari\",\"sop\":2348},{\"num\":6052,\"ssn\":0,\"sou\":6957248,\"nic\":\"StellarRain\",\"sop\":2345},{\"num\":6053,\"ssn\":0,\"sou\":6127727,\"nic\":\"Moonbug\",\"sop\":2313},{\"num\":6054,\"ssn\":0,\"sou\":5815899,\"nic\":\"Gritzz\",\"sop\":2311},{\"num\":6055,\"ssn\":0,\"sou\":3340187,\"nic\":\"QueenWeeaboo\",\"sop\":2307},{\"num\":6056,\"ssn\":0,\"sou\":1308511,\"nic\":\"Percentage\",\"sop\":2302},{\"num\":6057,\"ssn\":0,\"sou\":2800282,\"nic\":\"L1Wei\",\"sop\":2291},{\"num\":6058,\"ssn\":0,\"sou\":2568111,\"nic\":\"RoisCado\",\"sop\":2274},{\"num\":6059,\"ssn\":0,\"sou\":4153154,\"nic\":\"BGamer29\",\"sop\":2272},{\"num\":6060,\"ssn\":0,\"sou\":6357764,\"nic\":\"wabisa\",\"sop\":2271},{\"num\":6061,\"ssn\":0,\"sou\":2578584,\"nic\":\"Head_Hunter\",\"sop\":2255},{\"num\":6062,\"ssn\":0,\"sou\":4799914,\"nic\":\"Riisaa\",\"sop\":2239},{\"num\":6063,\"ssn\":0,\"sou\":3007401,\"nic\":\"\u8FE6\u52D2\u5E95\u6240\u957F\u4E0D\u66B4\u6BD9\",\"sop\":2235},{\"num\":6064,\"ssn\":0,\"sou\":4505107,\"nic\":\"Servinhuu\",\"sop\":2209},{\"num\":6065,\"ssn\":0,\"sou\":2253983,\"nic\":\"Dorokuma\",\"sop\":2191},{\"num\":6066,\"ssn\":0,\"sou\":6042974,\"nic\":\"DarkCJ\",\"sop\":2184},{\"num\":6067,\"ssn\":0,\"sou\":2914690,\"nic\":\"qhonox\",\"sop\":2180},{\"num\":6068,\"ssn\":0,\"sou\":7340147,\"nic\":\"HappyFaceBox\",\"sop\":2175},{\"num\":6069,\"ssn\":0,\"sou\":4057674,\"nic\":\"\u3069\u3063\u307D\",\"sop\":2160},{\"num\":6070,\"ssn\":0,\"sou\":5862421,\"nic\":\"!fuyuhiko\",\"sop\":2157},{\"num\":6071,\"ssn\":0,\"sou\":4076719,\"nic\":\"kiriket\",\"sop\":2152},{\"num\":6072,\"ssn\":0,\"sou\":6829736,\"nic\":\"B1adehawk\",\"sop\":2150},{\"num\":6073,\"ssn\":0,\"sou\":4716992,\"nic\":\"cornux\",\"sop\":2148},{\"num\":6074,\"ssn\":0,\"sou\":3780410,\"nic\":\"Huliozavr\",\"sop\":2143},{\"num\":6075,\"ssn\":0,\"sou\":2633587,\"nic\":\"Pea Flavor\",\"sop\":2140},{\"num\":6076,\"ssn\":0,\"sou\":2805168,\"nic\":\"MaKoBy Yuui\",\"sop\":2139},{\"num\":6077,\"ssn\":0,\"sou\":7294916,\"nic\":\"faeriesow\",\"sop\":2137},{\"num\":6078,\"ssn\":0,\"sou\":2734035,\"nic\":\"\u5343Jun\u4E00\u53D1\",\"sop\":2135},{\"num\":6079,\"ssn\":0,\"sou\":5593839,\"nic\":\"Melanie uwu\",\"sop\":2134},{\"num\":6080,\"ssn\":0,\"sou\":4793847,\"nic\":\"\u58A8\u67D3\u6210\u7891\",\"sop\":2121},{\"num\":6081,\"ssn\":0,\"sou\":5993009,\"nic\":\"ks3nichka\",\"sop\":2120},{\"num\":6082,\"ssn\":0,\"sou\":6004098,\"nic\":\"carminemisery\",\"sop\":2114},{\"num\":6083,\"ssn\":0,\"sou\":1507100,\"nic\":\"Cyine\",\"sop\":2096},{\"num\":6084,\"ssn\":0,\"sou\":7068909,\"nic\":\"MadameButterfly\",\"sop\":2093},{\"num\":6085,\"ssn\":0,\"sou\":6908674,\"nic\":\"\u795E\u30B3\u30F3\u30D7\u30EC\u30C3\u30AF\u30B9\",\"sop\":2086},{\"num\":6086,\"ssn\":0,\"sou\":2695275,\"nic\":\"Ramaha\",\"sop\":2075},{\"num\":6087,\"ssn\":0,\"sou\":2815462,\"nic\":\"maxumarhu\",\"sop\":2073},{\"num\":6088,\"ssn\":0,\"sou\":3352797,\"nic\":\"Renfar\",\"sop\":2069},{\"num\":6089,\"ssn\":0,\"sou\":7303960,\"nic\":\"hectopascal\",\"sop\":2068},{\"num\":6090,\"ssn\":0,\"sou\":5130242,\"nic\":\"\u89FF\u5FA1\",\"sop\":2046},{\"num\":6091,\"ssn\":0,\"sou\":7015484,\"nic\":\"tpcllsr fan\",\"sop\":2045},{\"num\":6092,\"ssn\":0,\"sou\":6708666,\"nic\":\"vampiresweekend\",\"sop\":2045},{\"num\":6093,\"ssn\":0,\"sou\":5938089,\"nic\":\"Zerith00\",\"sop\":2022}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);

        }
    }
}