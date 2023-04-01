using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Common.Util;

namespace BlackRevivalServer.Common.Model
{
	public class BattleHistory
	{
		[JsonProperty("knn")]
		public string killerNickname;

		[JsonProperty("rcn")]
		public long retainedCharacterNum;

		[JsonProperty("skn")]
		public int characterSkinType;

		[JsonProperty("pkc")]
		public int playerKill;

		[JsonProperty("tdtc")]
		public float playerHitDamage;

		[JsonProperty("rak")]
		public int rank;

		[JsonProperty("pts")]
		public long playTimeSeconds;

		[JsonProperty("bdt")]
		[JsonConverter(typeof(MicrosecondEpochConverter))]
		public DateTime battleDtm;

		[JsonProperty("cht")]
		public int chest;

		[JsonProperty("leg")]
		public int leg;

		[JsonProperty("hed")]
		public int head;

		[JsonProperty("wep")]
		public int weapon;

		[JsonProperty("trk")]
		public int trinket;

		[JsonProperty("arm")]
		public int arm;

		[JsonProperty("pla")]
		public int players;

		[JsonProperty("mkc")]
		public int monsterKill;

		[JsonProperty("tdtm")]
		public float monsterHitDamage;

		[JsonProperty("hea")]
		public float health;

		[JsonProperty("sta")]
		public float stamina;

		[JsonProperty("off")]
		public float offence;

		[JsonProperty("def")]
		public float defence;

		[JsonProperty("gfa")]
		public float gunFamiliarity;

		[JsonProperty("bfa")]
		public float bladeFamiliarity;

		[JsonProperty("tfa")]
		public float throwFamiliarity;

		[JsonProperty("pfa")]
		public float punchFamiliarity;

		[JsonProperty("wfa")]
		public float bowFamiliarity;

		[JsonProperty("lfa")]
		public float bluntFamiliarity;

		[JsonProperty("sfa")]
		public float stabFamiliarity;

		[JsonProperty("clv")]
		public int characterLevel;

		public int[] inventoryItems;

		[JsonProperty("gmd")]
		public int gameMode;

		[JsonProperty("psid")]
		public int potentialSkill;

		[JsonProperty("kut")]
		public UnitType killerUnitType;

		[JsonProperty("asc")]
		public int assistCount;

		[JsonProperty("ddc")]
		public int deadCount;

		[JsonProperty("rts")]
		public int redTeamScore;

		[JsonProperty("bts")]
		public int blueTeamScore;

		[JsonProperty("tnm")]
		public int teamNumber;

		[JsonProperty("mpk")]
		public int mainPerk;

		[JsonProperty("fpk")]
		public int firstPerk;

		[JsonProperty("spk")]
		public int secondPerk;

		[JsonProperty("upg")]
		public bool upgrade;

		[JsonProperty("ts")]
		public int tournamentStage;

		[JsonIgnore]
		public bool isWin
		{
			get
			{
				return rank == 1;
			}
		}

		public bool IsTeamMode()
		{
			if (gameMode != 40)
			{
				return gameMode == 41;
			}
			return true;
		}

		public List<int> GetEquipmentList()
		{
			return new List<int> { weapon, head, arm, chest, leg, trinket };
		}

		//public PerkData GetPerkData()
		//{
		//	return GameDB.perk.GetPerkData(mainPerk);
		//}

		//public PerkData GetFirstAchievementPerkData()
		//{
		//	return GameDB.perk.GetPerkData(firstPerk);
		//}

		//public PerkData GetSecondAchievementPerkData()
		//{
		//	return GameDB.perk.GetPerkData(secondPerk);
		//}

		public void GetTopFamiliarity(out AcE_WEAPON_TYPE _Type, out float _Familiarity)
		{
			_Familiarity = 0f;
			_Type = AcE_WEAPON_TYPE.NONE;
			if (_Familiarity < gunFamiliarity)
			{
				_Type = AcE_WEAPON_TYPE.GUN;
				_Familiarity = gunFamiliarity;
			}
			if (_Familiarity < bladeFamiliarity)
			{
				_Type = AcE_WEAPON_TYPE.BLADE;
				_Familiarity = bladeFamiliarity;
			}
			if (_Familiarity < throwFamiliarity)
			{
				_Type = AcE_WEAPON_TYPE.THROW;
				_Familiarity = throwFamiliarity;
			}
			if (_Familiarity < punchFamiliarity)
			{
				_Type = AcE_WEAPON_TYPE.PUNCH;
				_Familiarity = punchFamiliarity;
			}
			if (_Familiarity < bowFamiliarity)
			{
				_Type = AcE_WEAPON_TYPE.BOW;
				_Familiarity = bowFamiliarity;
			}
			if (_Familiarity < bluntFamiliarity)
			{
				_Type = AcE_WEAPON_TYPE.BLUNT;
				_Familiarity = bluntFamiliarity;
			}
			if (_Familiarity < stabFamiliarity)
			{
				_Type = AcE_WEAPON_TYPE.STAB;
				_Familiarity = stabFamiliarity;
			}
		}
	}
}
