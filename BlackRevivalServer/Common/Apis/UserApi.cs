﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackRevivalServer.Common.Model;
using BlackRevivalServer.Common.Util;

namespace BlackRevivalServer.Common.Apis
{
	public static class UserApi
	{
		public class UserLoginInfo
		{
			public UserIdentity userIdentity;

			public UserLoginInfo()
			{
				userIdentity = new UserIdentity();
			}
		}

		public class UserIdentity
		{
			public long userNum;

			public AuthProvider authProvider;

			public string id;

			public string email;
		}

		public class WholeNickname
		{
			public string nickname;

			public long userNum;

			[JsonConverter(typeof(MicrosecondEpochConverter))]
			public DateTime lastLogin;
		}

		public class IsGuestResult
		{
			public bool isGuest;

			public UserIdentity userIdentity;
		}

		public class LoginResult
		{
			public User user;

			public UserIdentity userIdentity;

			public string encryptedUserNum;

			public Session session;

			public bool serverCheck;

			[JsonConverter(typeof(MicrosecondEpochConverter))]
			public DateTime serverCheckBegin;

			[JsonConverter(typeof(MicrosecondEpochConverter))]
			public DateTime serverCheckEnd;

			public string userStatus;

			[JsonConverter(typeof(MicrosecondEpochConverter))]
			public DateTime userRestrictionEndDtm;

			public string GetTimeMsg()
			{
				bool flag = false;//LocalizationDB.language == SupportLanguage.ChineseSimplified;
				//try
				//{
				//	string[] array = string.Format(LocalizationDB.Dynamic("{0}년-{1}월-{2}일-{3:00}:{4:00}"), serverCheckBegin.Year, serverCheckBegin.Month, serverCheckBegin.Day, serverCheckBegin.Hour, serverCheckBegin.Minute).Split('-');
				//	string[] array2 = string.Format(LocalizationDB.Dynamic("{0}년-{1}월-{2}일-{3:00}:{4:00}"), serverCheckEnd.Year, serverCheckEnd.Month, serverCheckEnd.Day, serverCheckEnd.Hour, serverCheckEnd.Minute).Split('-');
				//	if (flag)
				//	{
				//		return array[0] + " ~ " + array2[0];
				//	}
				//	StringBuilder stringBuilder = new StringBuilder();
				//	StringBuilder stringBuilder2 = new StringBuilder();
				//	bool flag2 = false;
				//	if (flag2 || serverCheckBegin.Year != serverCheckEnd.Year)
				//	{
				//		stringBuilder.AppendFormat("{0} ", array[0]);
				//		stringBuilder2.AppendFormat("{0} ", array2[0]);
				//		flag2 = true;
				//	}
				//	if (flag2 || serverCheckBegin.Month != serverCheckEnd.Month || serverCheckBegin.Day != serverCheckEnd.Day)
				//	{
				//		stringBuilder.AppendFormat("{0} ", array[1]);
				//		stringBuilder2.AppendFormat("{0} ", array2[1]);
				//		stringBuilder.AppendFormat("{0} ", array[2]);
				//		stringBuilder2.AppendFormat("{0} ", array2[2]);
				//		flag2 = true;
				//	}
				//	stringBuilder.AppendFormat("{0} ", array[3]);
				//	stringBuilder2.AppendFormat("{0} ", array2[3]);
				//	return stringBuilder.ToString() + " ~ " + stringBuilder2.ToString();
				//}
				//catch
				{
					return string.Format("~ {0}-{1}-{2} {3:00}:{4:00}", serverCheckEnd.Year, serverCheckEnd.Month, serverCheckEnd.Day, serverCheckEnd.Hour, serverCheckEnd.Minute);
				}
			}

			public class WithdrawalResult
			{
			}

			public class ModifyResult
			{
				public User user;
			}

			public class ExistNickNameResult
			{
				public bool purchaseResult;
			}

			public class NicknameModifyResult
			{
				public string nickname;
			}

			public class HistoriesResult : CommunityRequsetResult
			{
				public List<BattleHistory> battleHistories;
			}

			public class RecordResult
			{
				public BattleRecord battleRecord;

				public List<Character> characters;
			}

			public class RecordCharacterResult
			{
				public BattleRecord battleRecord;
			}

			public class usehackResult
			{
			}

			public class PotentialChangeResult
			{
				public User user;
			}

			public class newPostResult
			{
				public User user;
			}

			public class AdResult
			{
				public User user;

				public Character character;
			}

			public class HonorResult
			{
				public List<Honor> honor;
			}

			public class RankBonusResult
			{
				public Goods goods;

				public User user;
			}

			public class ChangePotentialSkillResult
			{
				public int activatedPotentialSkillId;
			}

			//public class PotentialSkillListResult
			//{
			//	public List<UserPotentialSkill> list;

			//	public List<PerkApi.PerkPreset> perkList;
			//}

			//public class CharacterPlayCountResult
			//{
			//	public CharacterPlayCount characterPlayCount;
			//}

			//public class FreeBpRouletteResult
			//{
			//	public ProvideResult ProvideResult;

			//	[JsonConverter(typeof(MicrosecondEpochConverter))]
			//	public DateTime lastFreeBpRouletteDtm;
			//}

			//public class FreeBpRouletteTimeResult
			//{
			//	public int remainTime;
			//}

			//public class FirstIAPEventRewardResult
			//{
			//	public AttendanceEventRecord attendanceEventRecord;

			//	public ProvideResult provideResult;

			//	public Promotion userPromotion;
			//}

			//public class EventListResult
			//{
			//	public List<AttendanceEventRecord> attendanceEventRecords;
			//}
		}
	}
}
