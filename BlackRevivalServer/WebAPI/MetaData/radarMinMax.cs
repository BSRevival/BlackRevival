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
    public class APIradarMinMax
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/radarMinMax")]
        public static async Task radarMinMax(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"radarMinMax\":[{\"nm\":\"Level\",\"leg\":0,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":0,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":0,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":0,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":0,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":26,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":26,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":26,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":26,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":26,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":27,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":27,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":27,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":27,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":27,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":28,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":28,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":28,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":28,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":28,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":29,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":29,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":29,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":29,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":29,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":30,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":30,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":30,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":30,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":30,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":31,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":31,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":31,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":31,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":31,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":32,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":32,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":32,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":32,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":32,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":33,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":33,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":33,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":33,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":33,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":34,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":34,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":34,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":34,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":34,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":35,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":35,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":35,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":35,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":35,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":36,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":36,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":36,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":36,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":36,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":37,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":37,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":37,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":37,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":37,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":38,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":38,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":38,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":38,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":38,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":39,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":39,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":39,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":39,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":39,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":40,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":40,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":40,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":40,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":40,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":41,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":41,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":41,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":41,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":41,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":42,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":42,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":42,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":42,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":42,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":43,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":43,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":43,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":43,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":43,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":44,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":44,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":44,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":44,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":44,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":45,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":45,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":45,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":45,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":45,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":46,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":46,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":46,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":46,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":46,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":47,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":47,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":47,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":47,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":47,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":48,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":48,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":48,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":48,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":48,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":49,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":49,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":49,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":49,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":49,\"rdt\":5,\"mn\":70,\"mx\":151},{\"nm\":\"Level\",\"leg\":50,\"rdt\":1,\"mn\":2,\"mx\":15},{\"nm\":\"Damage\",\"leg\":50,\"rdt\":2,\"mn\":100,\"mx\":2000},{\"nm\":\"AliveTime\",\"leg\":50,\"rdt\":3,\"mn\":180,\"mx\":960},{\"nm\":\"KillMob\",\"leg\":50,\"rdt\":4,\"mn\":8,\"mx\":8},{\"nm\":\"Mastery\",\"leg\":50,\"rdt\":5,\"mn\":70,\"mx\":151}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}