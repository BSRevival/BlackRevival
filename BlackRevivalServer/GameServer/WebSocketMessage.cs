using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.GameServer
{
	public class WebSocketMessage
	{
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00014BEC File Offset: 0x00012DEC
		public bool IsNotification
		{
			get
			{
				return !string.IsNullOrEmpty(this.method);
			}
		}

		// Token: 0x04001305 RID: 4869
		[JsonProperty("mtd")]
		public string method;

		// Token: 0x04001306 RID: 4870
		[JsonProperty("rid")]
		public long id;

		// Token: 0x04001307 RID: 4871
		[JsonProperty("tme")]
		public long time;

		// Token: 0x04001308 RID: 4872
		[JsonProperty("cod")]
		public int code;

		// Token: 0x04001309 RID: 4873
		[JsonProperty("msg")]
		public string msg;

		// Token: 0x0400130A RID: 4874
		[JsonIgnore]
		public string json = "";
	}
}
