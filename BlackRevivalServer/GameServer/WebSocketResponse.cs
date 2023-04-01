using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.GameServer
{
	public class WebSocketResponse
	{
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00014BEC File Offset: 0x00012DEC
		
		[JsonProperty("rid")]
		public long id;

		// Token: 0x04001307 RID: 4871
		[JsonProperty("tme")]
		public long time;

		// Token: 0x04001308 RID: 4872
		[JsonProperty("cod")]
		public int code;

	}
}
