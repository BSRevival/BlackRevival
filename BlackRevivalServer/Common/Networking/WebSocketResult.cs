using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Networking
{
	public class WebSocketResult<T>
	{
		// Token: 0x0400130C RID: 4876
		[JsonProperty("rst")]
		public T result;
	}
}
