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
    public class APInotices
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/notices/PROMOTION/locale/English/{id}")]
        public static async Task getPromotions(IHttpContext context)
        {
            List<string> parameterList = new List<string>();
            //Add the parameters to the list from the route
            parameterList.Add("id");
            string[] parameters = Helpers.GetHTTPParameters(context, parameterList.ToArray());
            string resp = "";
            if (parameters[0]== "1" && parameters[1] == "0")
            {
                resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"notices\":[{\"typ\":3,\"styp\":\"\",\"loc\":\"en\",\"tit\":\"Service Revival notice\",\"ctt\":\"Service Revival notice\",\"bsi\":\"ServiceRevival.jpg\",\"bvl\":1,\"lif\":\"http:\\/\\/127.0.0.1\\/en\\/news\\/4455\",\"fbt\":\"Click here\",\"wfp\":0,\"hfp\":0,\"wsp\":0,\"hwp\":0,\"pxp\":100,\"pyf\":-215,\"pxs\":0,\"pys\":0,\"cdt\":1665631385000,\"ihs\":\"642b1124de502fd1bca7fbe8ccf2673245f687c8\",\"odr\":0},{\"typ\":3,\"styp\":\"\",\"loc\":\"en\",\"tit\":\"Notice\",\"ctt\":\"Notice\",\"bsi\":\"Promotion_2_new.png\",\"bvl\":2,\"lif\":\"http:\\/\\/127.0.0.1\\/en\\/news\\/4392\",\"lis\":\"GoToFAQ\",\"fbt\":\"Patch Notes\",\"sbt\":\"FAQ\",\"wfp\":0,\"hfp\":0,\"wsp\":0,\"hwp\":0,\"pxp\":-170,\"pyf\":-187,\"pxs\":70,\"pys\":-187,\"cdt\":1614734969000,\"ihs\":\"9307dec9aa0146d7674abdbd40e0e82848f89275\",\"odr\":50},{\"typ\":3,\"styp\":\"\",\"loc\":\"en\",\"tit\":\"Herbivore League Event\",\"ctt\":\"Herbivore League Event\",\"bsi\":\"Promotion_4_new.png\",\"bvl\":0,\"lif\":\"NULL\",\"lis\":\"NULL\",\"fbt\":\"NULL\",\"sbt\":\"NULL\",\"wfp\":0,\"hfp\":0,\"wsp\":0,\"hwp\":0,\"pxp\":0,\"pyf\":0,\"pxs\":0,\"pys\":0,\"cdt\":1504680836000,\"ihs\":\"f0d7ea41d2b332c71e942d89fe5df1a008c45e64\",\"odr\":100}]},\"eac\":0}";
            }
            
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
        [RestRoute("Get", "/api/notices/GACHA/locale/English/{id}")]
        public static async Task getGacha(IHttpContext context)
        {
            List<string> parameterList = new List<string>();
            parameterList.Add("id");
            string[] parameters = Helpers.GetHTTPParameters(context, parameterList.ToArray());
            string resp = "";
            if (parameters[0] == "1" && parameters[1] == "0")
            {
                resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"notices\":[{\"typ\":4,\"styp\":\"SEASON_ROULETTE\",\"loc\":\"en\",\"tit\":\"Mystery PC\",\"ctt\":\"\",\"bsi\":\"Gacha_MysteryPC.png\",\"bvl\":0,\"lif\":\"NULL\",\"lis\":\"NULL\",\"fbt\":\"NULL\",\"sbt\":\"NULL\",\"wfp\":0,\"hfp\":0,\"wsp\":0,\"hwp\":0,\"pxp\":0,\"pyf\":0,\"pxs\":0,\"pys\":0,\"cdt\":1585703325000,\"ihs\":\"94ec265cf351db6d0fa5659cdf8f068486f28099\",\"odr\":0},{\"typ\":4,\"styp\":\"BEARPOINT_ROULETTE\",\"loc\":\"en\",\"tit\":\"Bears Roulette\",\"ctt\":\"Bears Roulette\",\"bsi\":\"Gacha_BearsRoulette_00.png\",\"bvl\":0,\"wfp\":0,\"hfp\":0,\"wsp\":0,\"hwp\":0,\"pxp\":0,\"pyf\":0,\"pxs\":0,\"pys\":0,\"cdt\":1605663199000,\"ihs\":\"8433a52fe7407eba0261cd6bb7a31a9a45053866\",\"odr\":0},{\"typ\":4,\"styp\":\"EVENT_ROULETTE\",\"loc\":\"en\",\"tit\":\"The Last Event\",\"ctt\":\"\",\"bsi\":\"Gacha_Final.png\",\"bvl\":0,\"wfp\":0,\"hfp\":0,\"wsp\":0,\"hwp\":0,\"pxp\":0,\"pyf\":0,\"pxs\":0,\"pys\":0,\"cdt\":1665626241000,\"ihs\":\"11ff86a0d35eae10c838c5143da8eba97bc595ee\",\"odr\":0}]},\"eac\":0}";

            }
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

    }
}
