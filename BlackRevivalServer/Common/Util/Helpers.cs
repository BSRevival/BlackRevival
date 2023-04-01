using Grapevine;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Util
{
    public static class Helpers
    {
        public static string ByteArrayToStringHex(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.Append("0x");
                hex.AppendFormat("{0:X2} ", b);
            }
            return hex.ToString();
        }
        public static string ByteArrayToStringD(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0} ", b);
            }
            return hex.ToString();
        }
        public static string format_json(string json)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }

        public static string[] GetHTTPParameters(IHttpContext context, string[] ids)
        {
            if (!context.Locals.ContainsKey("PathParameters")) context.Locals.TryAdd("PathParameters", new StringBuilder());
            var sb = context.Locals.GetAs<StringBuilder>("PathParameters");
            var cnt = context.Request.PathParameters.Count;
            

            List<string> list = new List<string>();

            list.Add(cnt.ToString());
            foreach(string id in ids)
            {
                var pathParam = context.Request.PathParameters[id];
                list.Add(pathParam);
            }
            return list.ToArray();

        }

        public static string? ConvertDBRequestToJson<T>(SQLiteDataReader reader, bool IsList)
        {
            var dataTable = new DataTable();
            dataTable.Load(reader);
            if(IsList)
                return JsonConvert.SerializeObject(JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(dataTable)));
            else
                return JsonConvert.SerializeObject(dataTable);
        }

        public static T ConvertDBRequestToClass<T>(SQLiteDataReader reader, bool IsList)
        {
            var dataTable = new DataTable();
            dataTable.Load(reader);
            if (IsList)
                return (T)(object)JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(dataTable));
            else
                return (T)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(dataTable));
        }

    }
}
