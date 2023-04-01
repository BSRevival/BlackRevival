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
    public class APIdailyProduct
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/dailyProduct/all/{uid}")]
        public static async Task getDailyProduct(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"allDailyProducts\":[{\"idx\":1170178,\"un\":7562069,\"pid\":\"DCE25\",\"bgt\":\"TICKET\",\"bst\":\"CHARACTER_EXP_25\",\"bam\":5,\"pgt\":\"ASSET\",\"pst\":\"GEM\",\"pam\":20,\"rrc\":0,\"rmc\":0,\"pcs\":false,\"rdtm\":1665680581000,\"edtm\":1665759600000},{\"idx\":1170176,\"un\":7562069,\"pid\":\"DEM3\",\"bgt\":\"ASSET\",\"bst\":\"EXPERIMENT_MEMORY\",\"bam\":3,\"pgt\":\"ASSET\",\"pst\":\"GOLD\",\"pam\":0,\"rrc\":0,\"rmc\":0,\"pcs\":false,\"rdtm\":1665680581000,\"edtm\":1665759600000},{\"idx\":1170177,\"un\":7562069,\"pid\":\"DSG1000\",\"bgt\":\"ASSET\",\"bst\":\"GOLD\",\"bam\":1000,\"pgt\":\"ASSET\",\"pst\":\"GEM\",\"pam\":10,\"rrc\":0,\"rmc\":0,\"pcs\":false,\"rdtm\":1665680581000,\"edtm\":1665759600000},{\"idx\":1170179,\"un\":7562069,\"pid\":\"GFLR001\",\"bgt\":\"ASSET\",\"bst\":\"GEM\",\"bam\":100,\"pgt\":\"ASSET\",\"pst\":\"LABYRINTH_POINT\",\"pam\":600,\"rrc\":0,\"rmc\":0,\"pcs\":false,\"rdtm\":1665680581000,\"edtm\":1665759600000},{\"idx\":1170180,\"un\":7562069,\"pid\":\"GFLR002\",\"bgt\":\"ASSET\",\"bst\":\"GEM\",\"bam\":150,\"pgt\":\"ASSET\",\"pst\":\"LABYRINTH_POINT\",\"pam\":900,\"rrc\":0,\"rmc\":0,\"pcs\":false,\"rdtm\":1665680581000,\"edtm\":1665759600000},{\"idx\":1170181,\"un\":7562069,\"pid\":\"GFLR003\",\"bgt\":\"ASSET\",\"bst\":\"GEM\",\"bam\":200,\"pgt\":\"ASSET\",\"pst\":\"LABYRINTH_POINT\",\"pam\":1200,\"rrc\":0,\"rmc\":0,\"pcs\":false,\"rdtm\":1665680581000,\"edtm\":1665759600000},{\"idx\":1170182,\"un\":7562069,\"pid\":\"RDNA001\",\"bgt\":\"DNA\",\"bst\":\"JACKIE-D_GROWTH\",\"bam\":1,\"pgt\":\"ASSET\",\"pst\":\"GEM\",\"pam\":0,\"rrc\":0,\"rmc\":3,\"pcs\":false,\"rdtm\":1665680581000,\"edtm\":1665759600000}]},\"eac\":0}";             
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }
    }
}
