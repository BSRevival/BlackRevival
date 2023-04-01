using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using BlackRevivalServer.WebAPI;
namespace BlackRevivalServer
{
    class HTTPParser
    {
        public static async Task ProcessRequest(HttpListenerContext context)
        {
            HttpListenerRequest request = context.Request;
            Thread.CurrentThread.Name = "HTTP";

            string documentContents;
            using (Stream receiveStream = request.InputStream)
            {
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    documentContents = readStream.ReadToEnd();
                }
            }
            
            Log.Debug("REQ URL: {request}", request.RawUrl);
            
            try
            {
                Log.Debug("HEADERS:");
                Dictionary<string, object> headers = (Dictionary<string, object>)request.Headers.AsDictionary();
                foreach (KeyValuePair<string, object> pair in headers)
                {

                    Log.Debug("KEY:{key} VALUE:{val}", pair.Key, pair.Value);
                }
            }
            catch (Exception ex) { }
            //Console.WriteLine(documentContents);
            if (request.HttpMethod == "POST" || request.HttpMethod == "PUT")
            {
                try
                {
                    Log.Debug($"REQ Contains Data: \n\r{format_json(documentContents)}");
                }
                catch (Exception ex)
                {
                    Log.Debug("REQ Contains Data: {request}", documentContents);
                }
            }
            HttpListenerResponse response = context.Response;
            if (request.RawUrl.Contains("favicon.ico"))
            {
                response.StatusCode = 200;
                response.ContentType = "image/x-icon";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes("");
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
                await Task.CompletedTask;
            }
            string typename = request.RawUrl.Split('?')[0].Substring(1);
            if (typename.EndsWith('/'))
                typename = typename.TrimEnd('/');
            
            var result = typename.Substring(typename.LastIndexOf('/') + 1);
            
            bool startsWithNum = char.IsDigit(result[0]);
            if (startsWithNum)
            {
                var indexToReplace = typename.LastIndexOf('/') + 1;
                string theRes = "_" + typename.Substring(indexToReplace);
                typename = typename.Substring(0, indexToReplace);
                typename += theRes;
            }

            string typeTodot = typename.Replace('/', '.');

            string charCheck = typeTodot.Substring(typeTodot.LastIndexOf('.') + 1);
            if (charCheck == "characters")
            {
                var indexToReplace = typeTodot.LastIndexOf('.') + 1;
                typeTodot = typeTodot.Substring(0, indexToReplace);
                typeTodot += "Characters";
            }
            if (charCheck == "mails")
            {
                var indexToReplace = typeTodot.LastIndexOf('.') + 1;
                typeTodot = typeTodot.Substring(0, indexToReplace);
                typeTodot += "Mails";
            }
            if (charCheck == "event")
            {
                var indexToReplace = typeTodot.LastIndexOf('.') + 1;
                typeTodot = typeTodot.Substring(0, indexToReplace);
                typeTodot += "Event";
            }

            string[] subs = typeTodot.Split('.');



            StringBuilder stringBuilder = new StringBuilder();
            string lastString = "";
            for (int i = 0; i < subs.Length; i++)
            {
                if (char.IsDigit(subs[i][0]))
                {
                    subs[i] = "_" + subs[i];
                }
            }
            bool hitBreakpoint = false;
            if (subs.Length > 2)
            {
                if (subs[2].Contains("7562069"))
                    hitBreakpoint = true;
            }
            for (int i = 0; i < subs.Length; i++)
            {
                if (lastString == "users" && subs[i].StartsWith("_") && i == subs.Length-1)
                {
                    stringBuilder.Append("u");
                    subs[i] = subs[i].Substring(1, subs[i].Length-1);
                }

                lastString = subs[i];
                
                stringBuilder.Append(subs[i]);
                stringBuilder.Append('.');
            }
            typeTodot = stringBuilder.ToString();
            typeTodot = typeTodot.TrimEnd('.');
            


            Type t = Type.GetType("BlackRevivalServer.WebAPI." + typeTodot);
            if (t != null)
            {
                ConstructorInfo PacketConstructor = t.GetConstructor(Type.EmptyTypes);
                object packetObject = PacketConstructor.Invoke(new object[] { });

                MethodInfo method = t.GetMethod("execute");
                if (method != null)
                {
                    string resp = (string)method.Invoke(packetObject, null);
                    if (resp.StartsWith("{"))
                    {
                        Log.Debug(format_json(resp));
                    }

                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(resp);
                    // Get a response stream and write the response to it.
                    response.ContentLength64 = buffer.Length;
                    response.ContentType = "application/json";
                    System.IO.Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                    // You must close the output stream.
                    output.Close();
                    Log.Debug($"REQ Handled: {typename}");
                    await Task.CompletedTask;
                }
                else
                {
                    Log.Error("Unable to find Method \"execute\" for Request:{type}", typename);
                }
            }
            else if (request.RawUrl.EndsWith(".txt") || request.RawUrl.EndsWith(".unity3d"))
            {

                WriteFile((HttpListenerContext)context, typename);
                Log.Debug("Raw File Export: {type}", typename);
                await Task.CompletedTask;
            }
            else
            {
                response.StatusCode = 200;
                response.ContentType = "text/html";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes("{\"code\":0}");
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();

                Log.Debug("Unknown HTTP Request: {type}", typename);
                await Task.CompletedTask;
            }
        }
        static void WriteFile(HttpListenerContext ctx, string path)
        {
            var response = ctx.Response;
            using (FileStream fs = File.OpenRead(path))
            {
                string filename = Path.GetFileName(path);
                //response is HttpListenerContext.Response...
                response.ContentLength64 = fs.Length;
                response.SendChunked = false;
                response.ContentType = System.Net.Mime.MediaTypeNames.Application.Octet;
                response.AddHeader("Content-disposition", "attachment; filename=" + filename);

                byte[] buffer = new byte[64 * 1024];
                int read;
                using (BinaryWriter bw = new BinaryWriter(response.OutputStream))
                {
                    while ((read = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bw.Write(buffer, 0, read);
                        bw.Flush(); //seems to have no effect
                    }

                    bw.Close();
                }

                response.StatusCode = (int)HttpStatusCode.OK;
                response.StatusDescription = "OK";
                response.OutputStream.Close();
            }
        }
        private static string format_json(string json)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }

    }
}
