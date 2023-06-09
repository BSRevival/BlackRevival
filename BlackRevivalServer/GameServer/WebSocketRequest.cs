﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Common.Util;

namespace BlackRevivalServer.GameServer
{
	public class WebSocketRequest
	{
		// Token: 0x06001B54 RID: 6996 RVA: 0x00014C0F File Offset: 0x00012E0F
		public WebSocketRequest(string method, long id, long time, Hashtable param)
		{
			this.method = method;
			this.id = id;
			this.time = time;
			this.param = param;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00014C34 File Offset: 0x00012E34
		public WebSocketRequest(string method, long id, long time, params object[] param)
		{
			this.method = method;
			this.id = id;
			this.time = time;
			this.param = new KeyValueList(param).ToHashtable();
		}

		// Token: 0x0400130D RID: 4877
		[JsonProperty("mtd")]
		public string method;

		// Token: 0x0400130E RID: 4878
		[JsonProperty("rid")]
		public long id;

		// Token: 0x0400130F RID: 4879
		[JsonProperty("tme")]
		public long time;

		// Token: 0x04001310 RID: 4880
		[JsonProperty("prm")]
		public Hashtable param;
	}

}
