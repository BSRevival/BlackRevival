using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Model
{
	public class UserAsset
	{
		[JsonProperty("gld")]
		public int gold;

		[JsonProperty("gem")]
		public int gem;

		[JsonProperty("bpt")]
		public int bearPoint;

		[JsonProperty("cd")]
		public int credit;

		[JsonProperty("ma")]
		public int mileage;

		[JsonProperty("em")]
		public int experimentMemory;

		[JsonProperty("tp")]
		public int tournamentPoint;

		[JsonProperty("tt")]
		public int tournamentTicket;

		[JsonProperty("vt")]
		public int voteTicket;

		[JsonProperty("vs")]
		public int voteStamp;

		[JsonProperty("lp")]
		public int labyrinthPoint;

		public void updateAsset(UserAsset userAsset)
		{
			gold = userAsset.gold;
			gem = userAsset.gem;
			bearPoint = userAsset.bearPoint;
			credit = userAsset.credit;
			mileage = userAsset.mileage;
			experimentMemory = userAsset.experimentMemory;
			tournamentPoint = userAsset.tournamentPoint;
			tournamentTicket = userAsset.tournamentTicket;
			voteTicket = userAsset.voteTicket;
			voteStamp = userAsset.voteStamp;
			labyrinthPoint = userAsset.labyrinthPoint;
		}

		public void setAssetValue(AssetType assetType, int value)
		{
			switch (assetType)
			{
				case AssetType.GOLD:
					gold = value;
					break;
				case AssetType.GEM:
					gem = value;
					break;
				case AssetType.BEARPOINT:
					bearPoint = value;
					break;
				case AssetType.CREDIT:
					credit = value;
					break;
				case AssetType.MILEAGE:
					mileage = value;
					break;
				case AssetType.EXPERIMENT_MEMORY:
					experimentMemory = value;
					break;
				case AssetType.TOURNAMENT_POINT:
					tournamentPoint = value;
					break;
				case AssetType.TOURNAMENT_TICKET:
					tournamentTicket = value;
					break;
				case AssetType.VOTE_TICKET:
					voteTicket = value;
					break;
				case AssetType.VOTE_STAMP:
					voteStamp = value;
					break;
				case AssetType.LABYRINTH_POINT:
					labyrinthPoint = value;
					break;
				case (AssetType)4:
					break;
			}
		}

		public int getAssetValue(AssetType assetType)
		{
			switch (assetType)
			{
				case AssetType.GOLD:
					return gold;
				case AssetType.GEM:
					return gem;
				case AssetType.BEARPOINT:
					return bearPoint;
				case AssetType.CREDIT:
					return credit;
				case AssetType.MILEAGE:
					return mileage;
				case AssetType.EXPERIMENT_MEMORY:
					return experimentMemory;
				case AssetType.TOURNAMENT_POINT:
					return tournamentPoint;
				case AssetType.TOURNAMENT_TICKET:
					return tournamentTicket;
				case AssetType.VOTE_TICKET:
					return voteTicket;
				case AssetType.VOTE_STAMP:
					return voteStamp;
				case AssetType.LABYRINTH_POINT:
					return labyrinthPoint;
				default:
					return 0;
			}
		}
	}
}
