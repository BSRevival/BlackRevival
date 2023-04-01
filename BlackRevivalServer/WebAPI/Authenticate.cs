using Grapevine;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Common.Apis;
using BlackRevivalServer.Common.Util;

namespace BlackRevivalServer.WebAPI
{

    [RestResource]
    public class Authenticate
    {
        public static long DiscordAppID
        {
            get
            {
                return 0; //ReplaceWithyourDiscordAppID;
            }
        }

        public static string DiscordSecret
        {
            get
            {
                return "ReplaceWithYourOwnSecret";
            }
        }

        //This is something we have to come back to in the future
        [RestRoute("Post", "/api/authenticate")]
        [Header("Content-Type", "application/json")]
        public static async Task authtenticate(IHttpContext context)
        {
            string documentContents;
            using (Stream receiveStream = context.Request.InputStream)
            {
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    documentContents = readStream.ReadToEnd();
                }
            }
            try
            {
                Log.Debug($"REQ Contains Data: \n\r{Helpers.format_json(documentContents)}");
            }
            catch (Exception ex)
            {
            }
            UserApi.LoginResult loginResult = new UserApi.LoginResult();

            loginResult.user = new Common.Model.User();
            loginResult.session = new Common.Model.Session();
            loginResult.userIdentity = new UserApi.UserIdentity();
            


            loginResult.userStatus = "NONE";
            int ResponseCode = 200; //SUCCESS
            string TextResponseCode = "SUCCESS";
            string Header = "{\"cod\":"
                + ResponseCode.ToString()+ ",\"msg\":\""
                + TextResponseCode +"\",\"rst\":";
            //Make database container for building new player. 

            string resp = Header + "{\"encryptedUserNum\":\"gpge76eFAEi7yfSPjTY1Ng==\",\"userStatus\":\"NONE\",\"session\":{\"unm\":7562069,\"snm\":12,\"bpf\":\"NIMBLE_NEURON\",\"otp\":3,\"gst\":false,\"snk\":\"20d0df97c1eaef557930b3c44e3d54afc30ec3c4\"},\"userIdentity\":{\"userNum\":7562069,\"authProvider\":8,\"id\":\"76561197991502339\",\"machineNum\":\"2fb7df94a0449fb2a649bbf14a79266f8db42ee9\",\"guest\":false},\"user\":{\"activatedPotentialSkillId\":0,\"bpt\":1000000,\"asc\":0,\"cd\":0,\"ma\":1000000,\"em\":0,\"tp\":0,\"tt\":0,\"vt\":0,\"vs\":0,\"lp\":0,\"unm\":7562069,\"rpm\":true,\"npa\":true,\"tag\":true,\"nnm\":\"ReplaceNameHere\",\"bgm\":true,\"sef\":true,\"lwd\":\"How can I die here...\",\"wwd\":\"Come at me\",\"tpg\":0,\"lrp\":0,\"re\":0,\"acn\":10136633,\"alc\":\"en\",\"rvn\":10,\"lto\":false,\"ltt\":false,\"lte\":false,\"ltf\":false,\"ltv\":false,\"ltr\":false,\"rtc\":0,\"mcc\":0,\"sigg\":0,\"sigc\":0,\"leg\":10,\"aps\":6001,\"mrn\":10,\"rtn\":\"NONE\",\"gem\":10000000,\"gld\":10000000},\"serverCheck\":false},\"eac\":0}";
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);

        }
    }
}
