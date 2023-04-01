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
    public class APIVote
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/vote")]
        public static async Task vote(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"voteReward\":[{\"ssn\":10,\"phs\":101,\"rnk\":300,\"gst\":\"FURNITURE\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_FURNITURE\"},{\"ssn\":10,\"phs\":101,\"rnk\":400,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":300,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":101,\"rnk\":500,\"gst\":\"ASSET\",\"stp\":\"EXPERIMENT_MEMORY\",\"amt\":100,\"tky\":\"VOTE_PRIVILEGE_ASSET_EXPERIMENT_MEMORY\"},{\"ssn\":10,\"phs\":102,\"rnk\":200,\"gst\":\"EMOTICON\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_EMOTICON\"},{\"ssn\":10,\"phs\":102,\"rnk\":400,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":300,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":102,\"rnk\":500,\"gst\":\"ASSET\",\"stp\":\"EXPERIMENT_MEMORY\",\"amt\":100,\"tky\":\"VOTE_PRIVILEGE_ASSET_EXPERIMENT_MEMORY\"},{\"ssn\":10,\"phs\":103,\"rnk\":150,\"gst\":\"LANTERN\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_LANTERN\"},{\"ssn\":10,\"phs\":103,\"rnk\":400,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":300,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":103,\"rnk\":500,\"gst\":\"ASSET\",\"stp\":\"EXPERIMENT_MEMORY\",\"amt\":100,\"tky\":\"VOTE_PRIVILEGE_ASSET_EXPERIMENT_MEMORY\"},{\"ssn\":10,\"phs\":104,\"rnk\":100,\"gst\":\"CHARACTER_VOICE\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_CHARACTER_VOICE\"},{\"ssn\":10,\"phs\":104,\"rnk\":150,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":400,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":104,\"rnk\":200,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":350,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":104,\"rnk\":400,\"gst\":\"ASSET\",\"stp\":\"EXPERIMENT_MEMORY\",\"amt\":130,\"tky\":\"VOTE_PRIVILEGE_ASSET_EXPERIMENT_MEMORY\"},{\"ssn\":10,\"phs\":105,\"rnk\":80,\"gst\":\"AVATAR\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_AVATAR\"},{\"ssn\":10,\"phs\":105,\"rnk\":150,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":400,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":105,\"rnk\":200,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":350,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":105,\"rnk\":400,\"gst\":\"ASSET\",\"stp\":\"EXPERIMENT_MEMORY\",\"amt\":130,\"tky\":\"VOTE_PRIVILEGE_ASSET_EXPERIMENT_MEMORY\"},{\"ssn\":10,\"phs\":106,\"rnk\":30,\"gst\":\"AVATAR\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_VARIANT_AVATAR\"},{\"ssn\":10,\"phs\":106,\"rnk\":100,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":600,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":106,\"rnk\":200,\"gst\":\"ASSET\",\"stp\":\"GEM\",\"amt\":350,\"tky\":\"VOTE_PRIVILEGE_ASSET_GEM\"},{\"ssn\":10,\"phs\":106,\"rnk\":400,\"gst\":\"ASSET\",\"stp\":\"EXPERIMENT_MEMORY\",\"amt\":130,\"tky\":\"VOTE_PRIVILEGE_ASSET_EXPERIMENT_MEMORY\"},{\"ssn\":10,\"phs\":200,\"rnk\":30,\"gst\":\"FURNITURE\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_FURNITURE\"},{\"ssn\":10,\"phs\":200,\"rnk\":30,\"gst\":\"EMOTICON\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_EMOTICON\"},{\"ssn\":10,\"phs\":200,\"rnk\":30,\"gst\":\"LANTERN\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_LANTERN\"},{\"ssn\":10,\"phs\":200,\"rnk\":30,\"gst\":\"CHARACTER_VOICE\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_CHARACTER_VOICE\"},{\"ssn\":10,\"phs\":200,\"rnk\":30,\"gst\":\"AVATAR\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_AVATAR\"},{\"ssn\":10,\"phs\":200,\"rnk\":30,\"gst\":\"AVATAR\",\"stp\":\"\",\"amt\":1,\"tky\":\"VOTE_PRIVILEGE_PHASE_VARIANT_AVATAR\"}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}