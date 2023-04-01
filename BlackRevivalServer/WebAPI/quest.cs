﻿using BlackRevivalServer.Common.Util;
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
    public class APIQuest
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/quest/all")]
        public static async Task getAllQuest(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"progressList\":[{\"qpid\":42722044,\"qd\":22001,\"rt\":101,\"pg\":1,\"c\":true,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722045,\"qd\":22119,\"rt\":101,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722046,\"qd\":22212,\"rt\":101,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722047,\"qd\":22301,\"rt\":101,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722038,\"qd\":10020,\"rt\":1,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722039,\"qd\":46,\"rt\":1,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722040,\"qd\":10,\"rt\":1,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722041,\"qd\":20,\"rt\":1,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722042,\"qd\":10010,\"rt\":1,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":42722043,\"qd\":30,\"rt\":1,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665846000000},{\"qpid\":32109452,\"qd\":5340,\"rt\":13,\"pg\":100,\"c\":true,\"r\":true,\"ed\":1617721199000},{\"qpid\":32109453,\"qd\":5350,\"rt\":13,\"pg\":500,\"c\":true,\"r\":true,\"ed\":1617721199000},{\"qpid\":32109454,\"qd\":5360,\"rt\":13,\"pg\":500,\"c\":false,\"r\":false,\"ed\":1617721199000},{\"qpid\":32109455,\"qd\":5370,\"rt\":13,\"pg\":500,\"c\":false,\"r\":false,\"ed\":1617721199000},{\"qpid\":32109456,\"qd\":5380,\"rt\":13,\"pg\":500,\"c\":false,\"r\":false,\"ed\":1617721199000},{\"qpid\":32109457,\"qd\":5390,\"rt\":13,\"pg\":500,\"c\":false,\"r\":false,\"ed\":1617721199000},{\"qpid\":2548691,\"qd\":1500,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548692,\"qd\":1501,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548693,\"qd\":1502,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548694,\"qd\":1550,\"rt\":3,\"pg\":500,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548696,\"qd\":1552,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548697,\"qd\":1553,\"rt\":3,\"pg\":0,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548698,\"qd\":1554,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548699,\"qd\":1555,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548700,\"qd\":1556,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548701,\"qd\":1557,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548702,\"qd\":1510,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548703,\"qd\":1511,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548704,\"qd\":1513,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548705,\"qd\":1514,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548706,\"qd\":1515,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548707,\"qd\":1530,\"rt\":3,\"pg\":10,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548708,\"qd\":1531,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548709,\"qd\":1532,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548710,\"qd\":1539,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548711,\"qd\":1540,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548712,\"qd\":1541,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548713,\"qd\":1542,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548714,\"qd\":1600,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548715,\"qd\":1602,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548716,\"qd\":1604,\"rt\":3,\"pg\":0,\"c\":false,\"r\":false,\"ed\":4693148971000},{\"qpid\":2548717,\"qd\":1606,\"rt\":3,\"pg\":0,\"c\":false,\"r\":false,\"ed\":4693148971000},{\"qpid\":2548718,\"qd\":1608,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548719,\"qd\":1610,\"rt\":3,\"pg\":0,\"c\":false,\"r\":false,\"ed\":4693148971000},{\"qpid\":2548720,\"qd\":1612,\"rt\":3,\"pg\":0,\"c\":false,\"r\":false,\"ed\":4693148971000},{\"qpid\":2548721,\"qd\":1520,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548722,\"qd\":1521,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548723,\"qd\":1522,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548724,\"qd\":1523,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548725,\"qd\":1524,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":2548726,\"qd\":1525,\"rt\":3,\"pg\":1,\"c\":true,\"r\":true,\"ed\":4693148971000},{\"qpid\":42704907,\"qd\":320,\"rt\":2,\"pg\":1,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704908,\"qd\":131,\"rt\":2,\"pg\":8,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704909,\"qd\":10120,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704910,\"qd\":10121,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704911,\"qd\":213,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704912,\"qd\":10132,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704913,\"qd\":151,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704914,\"qd\":10200,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704915,\"qd\":10201,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704916,\"qd\":163,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704917,\"qd\":10210,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704918,\"qd\":10211,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704919,\"qd\":100,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704920,\"qd\":105,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704921,\"qd\":1001,\"rt\":2,\"pg\":1,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704922,\"qd\":25001,\"rt\":2,\"pg\":1,\"c\":true,\"r\":true,\"ed\":1665932400000},{\"qpid\":42704923,\"qd\":1002,\"rt\":2,\"pg\":1,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704924,\"qd\":171,\"rt\":2,\"pg\":1261,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704925,\"qd\":1003,\"rt\":2,\"pg\":1,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704926,\"qd\":172,\"rt\":2,\"pg\":1261,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704927,\"qd\":300,\"rt\":2,\"pg\":5,\"c\":true,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704928,\"qd\":10221,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704929,\"qd\":110,\"rt\":2,\"pg\":6,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704930,\"qd\":115,\"rt\":2,\"pg\":6,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704931,\"qd\":25011,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704932,\"qd\":116,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704933,\"qd\":187,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704934,\"qd\":10100,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704935,\"qd\":117,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704936,\"qd\":10101,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704937,\"qd\":121,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000},{\"qpid\":42704938,\"qd\":126,\"rt\":2,\"pg\":0,\"c\":false,\"r\":false,\"ed\":1665932400000}],\"aglaiaPassProgressList\":[{\"un\":2863408,\"es\":1,\"esn\":0,\"pt\":0,\"ss\":0,\"pa\":false,\"cd\":1568316539000,\"ud\":1568316539000,\"ed\":1573154939000},{\"un\":2863408,\"es\":2,\"esn\":0,\"pt\":2650,\"ss\":0,\"pa\":true,\"cd\":1573647019000,\"ud\":1577900450000,\"ed\":1578485419000},{\"un\":2863408,\"es\":7,\"esn\":0,\"pt\":6000,\"ss\":0,\"pa\":true,\"cd\":1612848490000,\"ud\":1616689940000,\"ed\":1617686890000},{\"un\":2863408,\"es\":5,\"esn\":0,\"pt\":6000,\"ss\":0,\"pa\":true,\"cd\":1616690080000,\"ud\":1620747846000,\"ed\":1621528480000},{\"un\":2863408,\"es\":10,\"esn\":0,\"pt\":6000,\"ss\":0,\"pa\":true,\"cd\":1620828304000,\"ud\":1624724746000,\"ed\":1625666704000},{\"un\":2863408,\"es\":6,\"esn\":0,\"pt\":6000,\"ss\":0,\"pa\":true,\"cd\":1624724821000,\"ud\":1628697110000,\"ed\":1629563221000},{\"un\":2863408,\"es\":12,\"esn\":0,\"pt\":50,\"ss\":1,\"pa\":false,\"cd\":1665677576000,\"ud\":1665760841000,\"ed\":1670515976000}],\"isExistExpiredReward\":false},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        [RestRoute("Get", "/api/quest/clear/check")]
        public static async Task checkQuest(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"aPassQuestClear\":true,\"weeklyQuestClear\":true,\"dailyQuestClear\":false,\"dailyEventQuestClear\":false,\"tutorialQuestClear\":false},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        [RestRoute("Get", "/api/quest/clear/{qid}")]
        public static async Task clearQuest(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"reward\":{\"c\":\"1-BEARPOINT\",\"a\":50},\"progress\":{\"qpid\":42704927,\"qd\":300,\"rt\":2,\"pg\":5,\"c\":true,\"r\":true,\"ed\":1665932400000},\"aglaiaPassProgressList\":[{\"un\":2863408,\"es\":1,\"esn\":0,\"pt\":0,\"ss\":0,\"pa\":false,\"cd\":1568316539000,\"ud\":1568316539000,\"ed\":1573154939000},{\"un\":2863408,\"es\":2,\"esn\":0,\"pt\":2650,\"ss\":0,\"pa\":true,\"cd\":1573647019000,\"ud\":1577900450000,\"ed\":1578485419000},{\"un\":2863408,\"es\":7,\"esn\":0,\"pt\":6000,\"ss\":0,\"pa\":true,\"cd\":1612848490000,\"ud\":1616689940000,\"ed\":1617686890000},{\"un\":2863408,\"es\":5,\"esn\":0,\"pt\":6000,\"ss\":0,\"pa\":true,\"cd\":1616690080000,\"ud\":1620747846000,\"ed\":1621528480000},{\"un\":2863408,\"es\":10,\"esn\":0,\"pt\":6000,\"ss\":0,\"pa\":true,\"cd\":1620828304000,\"ud\":1624724746000,\"ed\":1625666704000},{\"un\":2863408,\"es\":6,\"esn\":0,\"pt\":6000,\"ss\":0,\"pa\":true,\"cd\":1624724821000,\"ud\":1628697110000,\"ed\":1629563221000},{\"un\":2863408,\"es\":12,\"esn\":0,\"pt\":50,\"ss\":1,\"pa\":false,\"cd\":1665677576000,\"ud\":1665760841000,\"ed\":1670515976000}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        
    }
}
