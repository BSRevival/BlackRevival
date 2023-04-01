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
    public class APIusers
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/users/{uid}/potentialSkillList")]
        public static async Task getPotentialSkillList(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"perkList\":[{\"default\":true,\"pnm\":2712807,\"unm\":7562069,\"pnn\":\"DEFAULT\",\"cat\":10001,\"fst\":10101,\"snd\":10201,\"act\":true}],\"list\":[{\"rt\":0,\"fi\":true,\"bmd\":100,\"si\":6001}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        //This is something we have to come back to in the future
        [RestRoute("Post", "/api/users/{uid}")]
        public static async Task getUser(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"user\":{\"activatedPotentialSkillId\":0,\"bpt\":0,\"asc\":0,\"cd\":0,\"ma\":100000,\"em\":0,\"tp\":0,\"tt\":0,\"vt\":0,\"vs\":0,\"lp\":0,\"unm\":7562069,\"rpm\":true,\"npa\":true,\"tag\":true,\"nnm\":\"ReplaceNameHere\",\"bgm\":true,\"sef\":true,\"lwd\":\"How can I die here...\",\"wwd\":\"Come at me\",\"tpg\":0,\"lrp\":0,\"re\":0,\"acn\":10136633,\"alc\":\"en\",\"rvn\":10,\"lto\":false,\"ltt\":false,\"lte\":false,\"ltf\":false,\"ltv\":false,\"ltr\":false,\"rtc\":100000,\"mcc\":100000,\"sigg\":0,\"sigc\":0,\"leg\":1,\"aps\":6001,\"mrn\":10,\"rtn\":\"NONE\",\"gem\":1000000,\"gld\":1000000}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/users/remainFreeBpRouletteTime")]
        public static async Task getNextBpRouletteTime(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"remainTime\":0},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/users/freeBpRoulette")]
        public static async Task getFreeBpRoulette(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"lastFreeBpRouletteDtm\":1665761110873,\"provideResult\":{\"duplication\":false,\"prt\":[{\"duplication\":false,\"rgs\":{\"c\":\"7-ACCELATE\",\"a\":5,\"rgg\":{\"grd\":\"C\",\"crd\":10},\"slm\":false,\"rfb\":0},\"igs\":{\"c\":\"7-ACCELATE\",\"a\":1,\"n\":352323,\"un\":2863408,\"ia\":false,\"ed\":1666193110870,\"activated\":false},\"rdp\":false,\"cbr\":1.0}],\"rrt\":[{\"duplication\":false,\"gs\":{\"c\":\"1-MILEAGE\",\"a\":0},\"rdp\":false,\"cbr\":0.0},{\"duplication\":false,\"gs\":{\"c\":\"1-CREDIT\",\"a\":0},\"rdp\":false,\"cbr\":0.0},{\"duplication\":false,\"gs\":{\"c\":\"1-BEARPOINT\",\"a\":0},\"rdp\":false,\"cbr\":0.0}],\"rdp\":false,\"cbr\":0.0}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/users/{uid}/histories")]
        public static async Task getUserHistory(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"newRequestArrived\":true,\"battleHistories\":[{\"rcn\":3603224,\"skn\":713,\"gmd\":12,\"bdt\":1665824639000,\"pla\":10,\"pts\":948,\"rak\":1,\"knn\":\"\",\"kut\":0,\"clv\":15,\"psid\":6001,\"pkc\":4,\"tdtc\":992.0,\"mkc\":9,\"tdtm\":1508.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":14014,\"hed\":21022,\"arm\":23013,\"cht\":22030,\"leg\":24101,\"trk\":25020,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":190.0,\"sta\":99.0,\"off\":173.0,\"def\":222.0,\"gfa\":70.0,\"bfa\":57.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":135.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[31017,31036,14017,31004,51007,31028]},{\"rcn\":3603224,\"skn\":713,\"gmd\":12,\"bdt\":1665767039000,\"pla\":10,\"pts\":798,\"rak\":1,\"knn\":\"\",\"kut\":0,\"clv\":15,\"psid\":6001,\"pkc\":3,\"tdtc\":1161.0,\"mkc\":8,\"tdtm\":1125.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":14017,\"hed\":21028,\"arm\":23010,\"cht\":22030,\"leg\":24017,\"trk\":25010,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":190.0,\"sta\":161.0,\"off\":148.0,\"def\":232.0,\"gfa\":70.0,\"bfa\":57.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":123.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[31028,31036,31054,31113,51006,0]},{\"rcn\":9924773,\"skn\":4903,\"gmd\":30,\"bdt\":1665759457000,\"pla\":10,\"pts\":1214,\"rak\":3,\"knn\":\"feet\u30C4\",\"kut\":1,\"clv\":15,\"psid\":6001,\"pkc\":2,\"tdtc\":1276.0,\"mkc\":6,\"tdtm\":895.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":16055,\"hed\":21027,\"arm\":23105,\"cht\":22036,\"leg\":24101,\"trk\":25015,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":29.0,\"off\":187.0,\"def\":235.0,\"gfa\":55.0,\"bfa\":55.0,\"tfa\":136.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":70.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[21022,16045,51013,31013,31002,0]},{\"rcn\":9924773,\"skn\":4903,\"gmd\":12,\"bdt\":1665758407000,\"pla\":10,\"pts\":273,\"rak\":10,\"knn\":\"VerySweet JENNY\",\"kut\":1,\"clv\":2,\"psid\":6001,\"pkc\":0,\"tdtc\":37.0,\"mkc\":0,\"tdtm\":0.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":16045,\"hed\":21008,\"arm\":0,\"cht\":22007,\"leg\":0,\"trk\":0,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":126.0,\"off\":27.0,\"def\":37.0,\"gfa\":55.0,\"bfa\":55.0,\"tfa\":74.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":70.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[32004,31007,31105,0,0,0]},{\"rcn\":5412531,\"skn\":3910,\"gmd\":12,\"bdt\":1665678190000,\"pla\":10,\"pts\":1005,\"rak\":1,\"knn\":\"\",\"kut\":0,\"clv\":16,\"psid\":6001,\"pkc\":6,\"tdtc\":2123.0,\"mkc\":12,\"tdtm\":1720.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":12056,\"hed\":21008,\"arm\":23107,\"cht\":22030,\"leg\":24017,\"trk\":25013,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":264.0,\"sta\":81.0,\"off\":214.0,\"def\":191.0,\"gfa\":55.0,\"bfa\":56.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":156.0,\"sfa\":57.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[31107,31051,31046,31003,31054,31022]},{\"rcn\":3595279,\"skn\":2811,\"gmd\":12,\"bdt\":1665677208000,\"pla\":10,\"pts\":62,\"rak\":10,\"knn\":\"FairlyNew MAI\",\"kut\":1,\"clv\":2,\"psid\":6001,\"pkc\":0,\"tdtc\":157.0,\"mkc\":0,\"tdtm\":0.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":12036,\"hed\":21011,\"arm\":0,\"cht\":22003,\"leg\":0,\"trk\":0,\"mpk\":50001,\"fpk\":50102,\"spk\":50202,\"hea\":0.0,\"sta\":36.0,\"off\":29.0,\"def\":36.0,\"gfa\":65.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":79.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[32004,0,0,0,0,0]},{\"rcn\":9924773,\"skn\":4903,\"gmd\":30,\"bdt\":1651336126000,\"pla\":10,\"pts\":433,\"rak\":7,\"knn\":\"\",\"kut\":1,\"clv\":7,\"psid\":6001,\"pkc\":0,\"tdtc\":242.0,\"mkc\":0,\"tdtm\":0.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":16045,\"hed\":0,\"arm\":23014,\"cht\":22020,\"leg\":24007,\"trk\":0,\"mpk\":50001,\"fpk\":50102,\"spk\":50202,\"hea\":0.0,\"sta\":108.0,\"off\":56.0,\"def\":109.0,\"gfa\":55.0,\"bfa\":55.0,\"tfa\":91.0,\"pfa\":56.0,\"wfa\":55.0,\"lfa\":70.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[51004,12004,12004,31046,51017,51014]},{\"rcn\":9924773,\"skn\":4903,\"gmd\":20,\"bdt\":1651333654000,\"pla\":10,\"pts\":1235,\"rak\":1,\"knn\":\"\",\"kut\":0,\"clv\":18,\"psid\":6001,\"pkc\":3,\"tdtc\":3005.0,\"mkc\":12,\"tdtm\":2305.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":16055,\"hed\":21022,\"arm\":23014,\"cht\":22041,\"leg\":24101,\"trk\":25024,\"mpk\":50001,\"fpk\":50102,\"spk\":50202,\"hea\":14.0,\"sta\":17.0,\"off\":282.0,\"def\":253.0,\"gfa\":55.0,\"bfa\":55.0,\"tfa\":175.0,\"pfa\":56.0,\"wfa\":55.0,\"lfa\":70.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[16045,16047,31101,31004,0,0]},{\"rcn\":9924773,\"skn\":4903,\"gmd\":30,\"bdt\":1651332386000,\"pla\":10,\"pts\":262,\"rak\":9,\"knn\":\"Croward\",\"kut\":1,\"clv\":5,\"psid\":6001,\"pkc\":0,\"tdtc\":240.0,\"mkc\":1,\"tdtm\":60.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":16055,\"hed\":21006,\"arm\":23003,\"cht\":22008,\"leg\":24008,\"trk\":25006,\"mpk\":50001,\"fpk\":50102,\"spk\":50202,\"hea\":0.0,\"sta\":10.0,\"off\":89.0,\"def\":76.0,\"gfa\":55.0,\"bfa\":55.0,\"tfa\":88.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":70.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[51014,51017,0,0,0,0]},{\"rcn\":9924773,\"skn\":4901,\"gmd\":30,\"bdt\":1651331587000,\"pla\":10,\"pts\":575,\"rak\":5,\"knn\":\"Riisaa\",\"kut\":1,\"clv\":12,\"psid\":6001,\"pkc\":3,\"tdtc\":1400.0,\"mkc\":4,\"tdtm\":697.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":16055,\"hed\":21004,\"arm\":23013,\"cht\":22030,\"leg\":24006,\"trk\":0,\"mpk\":50001,\"fpk\":50102,\"spk\":50202,\"hea\":0.0,\"sta\":129.0,\"off\":156.0,\"def\":131.0,\"gfa\":55.0,\"bfa\":55.0,\"tfa\":124.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":70.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[31104,31025,32033,51017,0,0]},{\"rcn\":9088685,\"skn\":4803,\"gmd\":30,\"bdt\":1651329156000,\"pla\":10,\"pts\":1122,\"rak\":3,\"knn\":\"SovAlter\",\"kut\":1,\"clv\":14,\"psid\":6006,\"pkc\":0,\"tdtc\":1629.0,\"mkc\":4,\"tdtm\":446.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":18029,\"hed\":21022,\"arm\":23016,\"cht\":22036,\"leg\":24101,\"trk\":25104,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":59.0,\"off\":22.0,\"def\":229.0,\"gfa\":142.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[16022,51006,51018,0,0,0]},{\"rcn\":9088685,\"skn\":4803,\"gmd\":30,\"bdt\":1651163924000,\"pla\":10,\"pts\":1159,\"rak\":3,\"knn\":\"Russia777\",\"kut\":1,\"clv\":16,\"psid\":6006,\"pkc\":0,\"tdtc\":2073.0,\"mkc\":13,\"tdtm\":2229.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":18029,\"hed\":21008,\"arm\":23017,\"cht\":22020,\"leg\":24012,\"trk\":25009,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":44.0,\"off\":249.0,\"def\":148.0,\"gfa\":167.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[16022,51007,51018,0,0,0]},{\"rcn\":9088685,\"skn\":4803,\"gmd\":30,\"bdt\":1651163684000,\"pla\":10,\"pts\":79,\"rak\":10,\"knn\":\"Metrdotel\",\"kut\":1,\"clv\":2,\"psid\":6006,\"pkc\":0,\"tdtc\":75.0,\"mkc\":0,\"tdtm\":0.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":18002,\"hed\":21011,\"arm\":0,\"cht\":22003,\"leg\":0,\"trk\":0,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":56.0,\"off\":20.0,\"def\":31.0,\"gfa\":82.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[31105,32013,31006,51016,32004,0]},{\"rcn\":9088685,\"skn\":4803,\"gmd\":30,\"bdt\":1651082066000,\"pla\":10,\"pts\":675,\"rak\":6,\"knn\":\"novlimaaaa\",\"kut\":1,\"clv\":11,\"psid\":6004,\"pkc\":0,\"tdtc\":1183.0,\"mkc\":3,\"tdtm\":366.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":18027,\"hed\":21027,\"arm\":23014,\"cht\":22028,\"leg\":24015,\"trk\":25102,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":77.0,\"off\":134.0,\"def\":222.0,\"gfa\":123.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":56.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[51022,31002,0,0,0,0]},{\"rcn\":3595279,\"skn\":2807,\"gmd\":30,\"bdt\":1651081754000,\"pla\":10,\"pts\":205,\"rak\":8,\"knn\":\"YuiYal\",\"kut\":1,\"clv\":5,\"psid\":6004,\"pkc\":0,\"tdtc\":554.0,\"mkc\":0,\"tdtm\":0.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":12051,\"hed\":21014,\"arm\":0,\"cht\":22028,\"leg\":24003,\"trk\":0,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":15.0,\"off\":77.0,\"def\":114.0,\"gfa\":65.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":92.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[32008,31014,31007,16017,0,0]},{\"rcn\":9784034,\"skn\":306,\"gmd\":20,\"bdt\":1643388076000,\"pla\":10,\"pts\":907,\"rak\":5,\"knn\":\"\u4E05\u5342\u957F\u5342\u4E02\u5344\u5DE5\",\"kut\":1,\"clv\":12,\"psid\":6002,\"pkc\":1,\"tdtc\":1103.0,\"mkc\":5,\"tdtm\":795.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":16045,\"hed\":21027,\"arm\":23016,\"cht\":22038,\"leg\":24012,\"trk\":25003,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":3.0,\"off\":134.0,\"def\":197.0,\"gfa\":55.0,\"bfa\":65.0,\"tfa\":129.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[51017,23012,12005,16101,51032,51008]},{\"rcn\":9088685,\"skn\":4803,\"gmd\":20,\"bdt\":1639258915000,\"pla\":10,\"pts\":955,\"rak\":1,\"knn\":\"\",\"kut\":0,\"clv\":15,\"psid\":6006,\"pkc\":7,\"tdtc\":1504.0,\"mkc\":10,\"tdtm\":1667.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":18027,\"hed\":21014,\"arm\":23106,\"cht\":22028,\"leg\":24015,\"trk\":25024,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":183.0,\"sta\":109.0,\"off\":170.0,\"def\":216.0,\"gfa\":133.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":56.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[31047,32010,31028,31052,31056,31108]},{\"rcn\":9088685,\"skn\":4803,\"gmd\":30,\"bdt\":1632669621000,\"pla\":10,\"pts\":1181,\"rak\":1,\"knn\":\"\",\"kut\":0,\"clv\":17,\"psid\":6006,\"pkc\":4,\"tdtc\":2931.0,\"mkc\":8,\"tdtm\":1385.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":18027,\"hed\":21028,\"arm\":23014,\"cht\":22038,\"leg\":24017,\"trk\":25026,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":40.0,\"sta\":7.0,\"off\":254.0,\"def\":255.0,\"gfa\":168.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":56.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[31023,31001,32033,0,0,0]},{\"rcn\":9088685,\"skn\":4803,\"gmd\":30,\"bdt\":1632573160000,\"pla\":10,\"pts\":549,\"rak\":8,\"knn\":\"Jennie Sinclair\",\"kut\":1,\"clv\":11,\"psid\":6006,\"pkc\":2,\"tdtc\":1319.0,\"mkc\":1,\"tdtm\":90.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":18027,\"hed\":21014,\"arm\":23104,\"cht\":22028,\"leg\":24103,\"trk\":25018,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":97.0,\"off\":138.0,\"def\":196.0,\"gfa\":121.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[16022,32033,31001,31107,51035,0]},{\"rcn\":9088685,\"skn\":4803,\"gmd\":30,\"bdt\":1632500451000,\"pla\":10,\"pts\":1243,\"rak\":2,\"knn\":\"Operafurry\",\"kut\":1,\"clv\":16,\"psid\":6006,\"pkc\":2,\"tdtc\":1810.0,\"mkc\":7,\"tdtm\":859.0,\"asc\":0,\"ddc\":0,\"tnm\":0,\"rts\":0,\"bts\":0,\"wep\":18027,\"hed\":21028,\"arm\":23014,\"cht\":22036,\"leg\":24014,\"trk\":25105,\"mpk\":40001,\"fpk\":40102,\"spk\":40202,\"hea\":0.0,\"sta\":37.0,\"off\":221.0,\"def\":250.0,\"gfa\":151.0,\"bfa\":55.0,\"tfa\":55.0,\"pfa\":55.0,\"wfa\":55.0,\"lfa\":55.0,\"sfa\":55.0,\"upg\":false,\"ts\":0,\"inventoryItems\":[31106,31041,31056,31031,0,0]}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/users/playCount")]
        public static async Task getPlayCount(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"characterPlayCount\":{\"t\":1748,\"m\":393,\"c\":34,\"w\":360}},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/users/{uid}/changePotentialSkill/{sid}")]
        public static async Task changePotentialSkill(IHttpContext context)
        {
            List<string> parameterList = new List<string>();
            parameterList.Add("uid");
            parameterList.Add("sid");
            string[] parameters = Helpers.GetHTTPParameters(context, parameterList.ToArray());

            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"activatedPotentialSkillId\":"+parameters[2]+"},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;

            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        [RestRoute("Post", "/api/user/latency")]
        public static async Task postLatency(IHttpContext context)
        {
            

            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Post", "/api/users/{uid}/nickname/duplicationCheck")]
        public static async Task postCheckUsernameDuplicate(IHttpContext context)
        {
            string resp = "Username";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/users/{uid}/nickname/duplicationCheck")]
        public static async Task getCheckUsernameDuplicate(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"purchaseResult\":true},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Post", "/api/users/{uid}/initNickname")]
        public static async Task postInitNickname(IHttpContext context)
        {
            string resp = "Username";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

        [RestRoute("Get", "/api/users/{uid}/initNickname")]
        public static async Task getInitNickname(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"nickname\":\"Username\"},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
