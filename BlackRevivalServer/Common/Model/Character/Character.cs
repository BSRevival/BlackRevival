using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Common.Util;

namespace BlackRevivalServer.Common.Model
{
    public class Character
    {
		[JsonProperty("cnm")]
		public long characterNum;

		[JsonProperty("unm")]
		public long userNum;

		[JsonProperty("cls")]
		public int characterClass;

		[JsonProperty("crd")]
		public CharacterGrade characterGrade;

		[JsonProperty("ast")]
		public int activeCharacterSkinType;

		[JsonProperty("ehx")]
		public int enhanceExp;

		[JsonProperty("cpt")]
		public CharacterPurchaseType characterPurchaseType;

		[JsonProperty("unn")]
		public string userNickname;

		[JsonProperty("lwd")]
		public string userLastword;

		[JsonProperty("wwd")]
		public string userWatchword;

		[JsonProperty("ddm")]
		[JsonConverter(typeof(MicrosecondEpochConverter))]
		public DateTime deadTime;

		[JsonProperty("ctt")]
		public CharacterStatus characterStatus;

		[JsonProperty("leg")]
		public League league;

		[JsonProperty("nrs")]
		public long toNormalRemainSeconds;

		[JsonProperty("rpc")]
		public int rankPlayCount;

		[JsonProperty("rwc")]
		public int rankWinCount;

		[JsonProperty("npc")]
		public int normalPlayCount;

		[JsonProperty("nwc")]
		public int normalWinCount;

		[JsonProperty("gbd")]
		public int leagueBorder;

		[JsonProperty("psi")]
		public int potentialSkillId;

		[JsonProperty("tnm")]
		public int teamNumber;

		[JsonProperty("l2d")]
		public bool activeLive2D;

		[JsonProperty("hst")]
		public bool host;

		[JsonProperty("rtc")]
		public int researcherTitleCode;

		[JsonProperty("mcc")]
		public int matchingCardCode;

		[JsonIgnore]
		private Dictionary<AcE_WEAPON_TYPE, float> _defaultMasteryDic = new Dictionary<AcE_WEAPON_TYPE, float>();

		[JsonIgnore]
		private float _defaultTopMastery;
	}
}
