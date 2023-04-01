using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Model
{
	public class BattleRecord
	{
		[JsonProperty("hbt")]
		public int herbivBattle;

		[JsonProperty("cbt")]
		public int carnivBattle;

		[JsonProperty("hrb")]
		public int highRankBattle;

		[JsonProperty("avg")]
		public float averageRank;

		[JsonProperty("rw")]
		public int rankWin;

		[JsonProperty("nw")]
		public int normalWin;

		[JsonProperty("hss")]
		public int hackingSuccess;

		[JsonProperty("ckl")]
		public int characterKill;

		[JsonProperty("dea")]
		public int death;

		[JsonProperty("fst")]
		public long fieldShift;

		[JsonProperty("cps")]
		public int characterPurchase;

		[JsonProperty("bct")]
		public int totalBattle;

		[JsonProperty("blp")]
		public int bestLeaguePoint;

		[JsonProperty("mpc")]
		public AcE_CharacterClass mostPlayedCharacter;

		[JsonProperty("mpcnt")]
		public int mostPlayedCount;
	}

}
