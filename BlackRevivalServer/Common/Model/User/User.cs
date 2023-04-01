using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Common.Util;

namespace BlackRevivalServer.Common.Model
{
	public class User : UserAsset
	{
		[JsonProperty("unm")]
		public long userNum;

		[JsonProperty("rpm")]
		public bool receivePushMsg;

		[JsonProperty("npa")]
		public bool newPostArrived;

		[JsonProperty("tag")]
		public bool termsAgree;

		[JsonProperty("nnm")]
		public string nickname;

		[JsonProperty("tpg")]
		public int tutorialProgress;

		[JsonProperty("bgm")]
		public bool bgm;

		[JsonProperty("sef")]
		public bool soundEffect;

		[JsonProperty("lwd")]
		public string lastword;

		[JsonProperty("wwd")]
		public string watchword;

		[JsonProperty("leg")]
		public League league;

		[JsonProperty("acn")]
		public long activeCharacterNum;

		[JsonProperty("alc")]
		public string appLanguageCode;

		[JsonProperty("lrp")]
		public int leaguePoint;

		[JsonProperty("rvn")]
		public int adViewCount;

		[JsonProperty("mrn")]
		public int maxAdViewCount;

		[JsonProperty("let")]
		[JsonConverter(typeof(MicrosecondEpochConverter))]
		public DateTime LasteastReviveDate;

		public bool haveNewRecord;

		[JsonProperty("aps")]
		public int activatedPotentialSkillId;

		[JsonProperty("vlc")]
		public string voiceLanguageCode;

		[JsonProperty("tw")]
		public bool todayWin;

		[JsonProperty("th")]
		public bool todayHighRank;

		[JsonProperty("re")]
		public int researcherExp;

		[JsonProperty("lfb")]
		[JsonConverter(typeof(MicrosecondEpochConverter))]
		public DateTime lastFreeBpRouletteDtm;

		[JsonProperty("rtc")]
		public int researcherTitleCode;

		[JsonProperty("mcc")]
		public int matchingCardCode;

		[JsonProperty("lpvd")]
		[JsonConverter(typeof(MicrosecondEpochConverter))]
		public DateTime lastUpdatePvETicketDtm;

		//public SkillData GetActivatedPotentialSkillData()
		//{
		//	return GameDB.skill.Find(activatedPotentialSkillId);
		//}

		public string GetUserNumName()
		{
			return string.Format("{0}_{1}", userNum, nickname);
		}

		public bool IsAvailableAd()
		{
			return adViewCount > 0;
		}

		public int GetRemainAdsViewCount()
		{
			return adViewCount;
		}

		public bool IsCarnivorousLeague()
		{
			return league >= League.FOX5;
		}

		public TimeSpan AdRechargeTime()
		{
			return TimeSpan.FromHours(2.0) - (DateTime.Now - LasteastReviveDate);
		}

		public bool IsGreaterThanLegaue(int leagueNum)
		{
			return (int)league > leagueNum;
		}
	}
}
