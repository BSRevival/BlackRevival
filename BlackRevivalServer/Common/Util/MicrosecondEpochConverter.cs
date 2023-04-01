using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Util
{
	public class MicrosecondEpochConverter : DateTimeConverterBase
	{
		// Token: 0x06006602 RID: 26114 RVA: 0x001CDA48 File Offset: 0x001CBC48
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteRawValue((((DateTime)value).ToUniversalTime() - MicrosecondEpochConverter._epoch).TotalMilliseconds.ToString());
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x001CDA84 File Offset: 0x001CBC84
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.Value == null)
			{
				return null;
			}
			return MicrosecondEpochConverter._epoch.AddMilliseconds((double)((long)reader.Value)).ToLocalTime();
		}

		// Token: 0x04004CB9 RID: 19641
		private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	}
}
