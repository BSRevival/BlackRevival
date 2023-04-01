using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Model
{
	public enum BuildPlatform
	{
		NIMBLE_NEURON = 0,
		ESOUL = 1,
		NETEASE = 2,
		Mobtech = 3
	}
	public enum OsType
	{
		NONE = 0,
		ANDROID = 1,
		IOS = 2,
		WINDOWS64 = 3,
		WINDOWS_DMM = 4,
		ETC = 99
	}

	public class Session
	{
		[JsonProperty("snm")]
		public int shardNum;

		[JsonProperty("atp")]
		public AuthProvider authProvider;

		[JsonProperty("bpf")]
		public BuildPlatform buildPlatform;

		[JsonProperty("otp")]
		public OsType osType;

		[JsonProperty("ovs")]
		public string osVersion;

		[JsonProperty("avs")]
		public string appVersion;

		[JsonProperty("gst")]
		public bool guest;

		[JsonProperty("snk")]
		public string sessionKey;

		[JsonProperty("dlc")]
		public string deviceLanguageCode;

		[JsonProperty("alc")]
		public string appLanguageCode;

		[JsonProperty("mkt")]
		public Market market;

		[JsonProperty("atb")]
		public string attribution;

		[JsonProperty("dloc")]
		private string deviceLocationCode;

		public static Session Create(int shardNum = 0, string sessionKey = null)
		{
			Session session = new Session();
			session.shardNum = shardNum;
			session.sessionKey = sessionKey;
			//session.appVersion = ApiConstants.AppClientVersion;
			//session.appLanguageCode = LocalizationDB.language.FromAppLanguage();
			//session.deviceLocationCode = ApiConstants.locationCode;
			//AcLogger.DebugHighlight("[Session] Create : deviceLocationCode = {0}", session.deviceLocationCode);
			session.guest = false;
			session.osVersion = "1.0.0";
			//session.buildPlatform = AcBuildPlatformExtension.GetBuildPlatform();
			session.market = Market.NONE;
			session.attribution = "DISCORD";
			session.osType = OsType.WINDOWS64;//OsTypeHelper.GetOsType();
			session.osVersion = "Windows11";//SystemInfo.operatingSystem;
			session.deviceLanguageCode = "EN";//LanguageHelper.Get2LetterISOCodeFromSystemLanguage();
			return session;
		}

		public void setAuthProvider(AuthProvider authProvider)
		{
			this.authProvider = authProvider;
			if (authProvider.Equals(AuthProvider.QQ) || authProvider.Equals(AuthProvider.WECHAT))
			{
				market = Market.XSOLLA;
			}
		}
	}

}
