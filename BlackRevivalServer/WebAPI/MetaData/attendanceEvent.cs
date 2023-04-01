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
    public class APIattendanceEvent
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/attendanceEvent")]
        public static async Task attendanceEvent(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"attendanceEvent\":[{\"active\":true,\"eid\":1,\"get\":1,\"exp\":25,\"rwd\":{\"1\":{\"c\":\"1-GOLD\",\"a\":1000},\"2\":{\"c\":\"2-2\",\"a\":1},\"3\":{\"c\":\"12-CHARACTER_EXP_25\",\"a\":1},\"4\":{\"c\":\"1-GEM\",\"a\":60},\"5\":{\"c\":\"8-CHARACTER_EXP\",\"a\":5},\"6\":{\"c\":\"1-BEARPOINT\",\"a\":100},\"7\":{\"c\":\"8-CHARACTER_EXP\",\"a\":10},\"8\":{\"c\":\"1-GOLD\",\"a\":1500},\"9\":{\"c\":\"12-CHARACTER_EXP_25\",\"a\":2},\"10\":{\"c\":\"1-BEARPOINT\",\"a\":150},\"11\":{\"c\":\"8-CHARACTER_EXP\",\"a\":15},\"12\":{\"c\":\"12-CHARACTER_EXP_25\",\"a\":3},\"13\":{\"c\":\"1-BEARPOINT\",\"a\":200},\"14\":{\"c\":\"1-GEM\",\"a\":100},\"15\":{\"c\":\"1-GOLD\",\"a\":2000},\"16\":{\"c\":\"1-BEARPOINT\",\"a\":250},\"17\":{\"c\":\"1-GEM\",\"a\":140},\"18\":{\"c\":\"8-CHARACTER_EXP\",\"a\":20},\"19\":{\"c\":\"1-GOLD\",\"a\":2500},\"20\":{\"c\":\"12-CHARACTER_EXP_25\",\"a\":4},\"21\":{\"c\":\"4-203\",\"a\":1}},\"evex\":7289103600000,\"mxs\":21},{\"active\":false,\"eid\":2,\"get\":1,\"exp\":8,\"rwd\":{\"1\":{\"c\":\"10-OFFENSIVE_BOX\",\"a\":10},\"2\":{\"c\":\"10-DEFENSIVE_BOX\",\"a\":20},\"3\":{\"c\":\"10-ICE_BOX\",\"a\":30},\"4\":{\"c\":\"8-GOLD\",\"a\":20},\"5\":{\"c\":\"8-BEARPOINT\",\"a\":30},\"6\":{\"c\":\"1-GOLD\",\"a\":5000},\"7\":{\"c\":\"19-CHRISTMAS_01\",\"a\":1}},\"evex\":1545750000000,\"mxs\":7},{\"active\":true,\"eid\":3,\"get\":2,\"exp\":7,\"rwd\":{\"1\":{\"c\":\"2-33\",\"a\":1},\"2\":{\"c\":\"2-34\",\"a\":1},\"3\":{\"c\":\"2-31\",\"a\":1}},\"evex\":7262492400000,\"mxs\":1},{\"active\":false,\"eid\":4,\"get\":3,\"exp\":1,\"rwd\":{\"1\":{\"c\":\"1-VOTE_TICKET\",\"a\":1}},\"evex\":1597831200000,\"mxs\":1},{\"active\":true,\"eid\":5,\"get\":4,\"exp\":25,\"rwd\":{\"1\":{\"c\":\"1-GOLD\",\"a\":500},\"2\":{\"c\":\"1-BEARPOINT\",\"a\":100},\"3\":{\"c\":\"1-TOURNAMENT_TICKET\",\"a\":1},\"4\":{\"c\":\"1-EXPERIMENT_MEMORY\",\"a\":10},\"5\":{\"c\":\"1-GEM\",\"a\":50},\"6\":{\"c\":\"1-GOLD\",\"a\":1000},\"7\":{\"c\":\"1-BEARPOINT\",\"a\":200},\"8\":{\"c\":\"1-TOURNAMENT_TICKET\",\"a\":1},\"9\":{\"c\":\"1-EXPERIMENT_MEMORY\",\"a\":20},\"10\":{\"c\":\"1-GEM\",\"a\":100},\"11\":{\"c\":\"1-GOLD\",\"a\":1500},\"12\":{\"c\":\"1-BEARPOINT\",\"a\":300},\"13\":{\"c\":\"1-TOURNAMENT_TICKET\",\"a\":2},\"14\":{\"c\":\"1-EXPERIMENT_MEMORY\",\"a\":30},\"15\":{\"c\":\"1-GEM\",\"a\":150},\"16\":{\"c\":\"1-GOLD\",\"a\":2000},\"17\":{\"c\":\"1-BEARPOINT\",\"a\":400},\"18\":{\"c\":\"1-TOURNAMENT_TICKET\",\"a\":2},\"19\":{\"c\":\"1-EXPERIMENT_MEMORY\",\"a\":40},\"20\":{\"c\":\"1-GEM\",\"a\":200}},\"evex\":7289103600000,\"mxs\":20},{\"active\":false,\"eid\":101,\"get\":1,\"exp\":10,\"rwd\":{\"1\":{\"c\":\"4-3309\",\"a\":1},\"2\":{\"c\":\"1-GEM\",\"a\":100},\"3\":{\"c\":\"1-BEARPOINT\",\"a\":2500},\"4\":{\"c\":\"1-GOLD\",\"a\":20000},\"5\":{\"c\":\"1-CREDIT\",\"a\":200},\"6\":{\"c\":\"1-GEM\",\"a\":300},\"7\":{\"c\":\"1-CREDIT\",\"a\":300}},\"evex\":1646060399000,\"mxs\":7}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
