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
    public class APImails
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/mails")]
        public static async Task mails(IHttpContext context)
        {
            string resp = "{\r\n  \"cod\": 200,\r\n  \"msg\": \"SUCCESS\",\r\n  \"rst\": {\r\n    \"mails\": [\r\n      {\r\n        \"attachement\": {\r\n          \"reason\": \"MAIL_ASSET\",\r\n          \"man\": 9238664,\r\n          \"mnm\": 10138961,\r\n          \"gs\": {\r\n            \"c\": \"1-GEM\",\r\n            \"a\": 50\r\n          }\r\n        },\r\n        \"mnm\": 10138961,\r\n        \"typ\": 1,\r\n        \"tit\": \"With Love -San\",\r\n        \"ctt\": \"With Love. - San\",\r\n        \"sts\": 1,\r\n        \"snm\": 0,\r\n        \"snk\": \"\uAD00\uB9AC\uC790\",\r\n        \"enm\": 0,\r\n        \"cdt\": 1665680824000,\r\n        \"epd\": 1666285624000,\r\n        \"lnk\": \"\",\r\n        \"wlnk\": \"\",\r\n        \"atm\": {\r\n          \"reason\": \"MAIL_ASSET\",\r\n          \"man\": 9238664,\r\n          \"mnm\": 10138961,\r\n          \"gs\": {\r\n            \"c\": \"1-GEM\",\r\n            \"a\": 50\r\n          }\r\n        }\r\n      },\r\n      {\r\n        \"attachement\": {\r\n          \"reason\": \"MAIL_ASSET\",\r\n          \"man\": 9238665,\r\n          \"mnm\": 10138962,\r\n          \"gs\": {\r\n            \"c\": \"1-GOLD\",\r\n            \"a\": 3000\r\n          }\r\n        },\r\n        \"mnm\": 10138962,\r\n        \"typ\": 1,\r\n        \"tit\": \"For CorpseKitten\",\r\n        \"ctt\": \"More Love.\",\r\n        \"sts\": 1,\r\n        \"snm\": 0,\r\n        \"snk\": \"\uAD00\uB9AC\uC790\",\r\n        \"enm\": 0,\r\n        \"cdt\": 1665680824000,\r\n        \"epd\": 1666285624000,\r\n        \"lnk\": \"\",\r\n        \"wlnk\": \"\",\r\n        \"atm\": {\r\n          \"reason\": \"MAIL_ASSET\",\r\n          \"man\": 9238665,\r\n          \"mnm\": 10138962,\r\n          \"gs\": {\r\n            \"c\": \"1-GOLD\",\r\n            \"a\": 3000\r\n          }\r\n        }\r\n      },\r\n      {\r\n        \"attachement\": {\r\n          \"reason\": \"MAIL_CHARACTER_SKIN\",\r\n          \"man\": 9238666,\r\n          \"mnm\": 10138963,\r\n          \"gs\": {\r\n            \"c\": \"4-114\",\r\n            \"a\": 1\r\n          }\r\n        },\r\n        \"mnm\": 10138963,\r\n        \"typ\": 1,\r\n        \"tit\": \"Luima Island's Cafe\",\r\n        \"ctt\": \"Guys Don't worry its coming :).\",\r\n        \"sts\": 1,\r\n        \"snm\": 0,\r\n        \"snk\": \"\uAD00\uB9AC\uC790\",\r\n        \"enm\": 0,\r\n        \"cdt\": 1665680825000,\r\n        \"epd\": 1670549820000,\r\n        \"lnk\": \"\",\r\n        \"atm\": {\r\n          \"reason\": \"MAIL_CHARACTER_SKIN\",\r\n          \"man\": 9238666,\r\n          \"mnm\": 10138963,\r\n          \"gs\": {\r\n            \"c\": \"4-114\",\r\n            \"a\": 1\r\n          }\r\n        }\r\n      }\r\n    ],\r\n    \"newRequestArrived\": false\r\n  },\r\n  \"eac\": 0\r\n}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
