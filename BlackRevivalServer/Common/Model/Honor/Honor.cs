using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Model
{
    public class Honor
    {
		[JsonProperty("num")]
		public int honorNum;

		[JsonProperty("sou")]
		public int userNum;

		[JsonProperty("nic")]
		public string nickname;

		[JsonProperty("sop")]
		public int rankPoint;

		public int rank;
	}
}
