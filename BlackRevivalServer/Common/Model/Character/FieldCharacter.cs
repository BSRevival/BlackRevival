using BlackRevivalServer.Common.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Model
{
	// Token: 0x02001369 RID: 4969
	public class FieldCharacter : Character
	{
		// Token: 0x06006F43 RID: 28483 RVA: 0x0004D6F2 File Offset: 0x0004B8F2
		//public FieldCharacter()
		//{
		//	this.memoryFieldItem = new List<FieldItem>();
		//	this.skillStatusList = new List<SkillStatus>();
		//}

		//// Token: 0x06006F44 RID: 28484 RVA: 0x001E982C File Offset: 0x001E7A2C
		//public int GetVeteranGradeByWeaponType(AcE_WEAPON_TYPE type)
		//{
		//	if (this.weaponVeteranGrades == null)
		//	{
		//		AcLogger.LogWarning("[CharacterAbility] GetVeteranGradeOfEquipedWeapon : weaponVeteranGrades is null : type =" + type);
		//		return 0;
		//	}
		//	FamiliarityStatus familiarityStatus = this.weaponVeteranGrades.Find((FamiliarityStatus x) => x.weaponType == type);
		//	if (familiarityStatus == null)
		//	{
		//		AcLogger.LogWarning("[CharacterAbility] GetVeteranGradeOfEquipedWeapon : FamiliarityStatus is null : type =" + type);
		//		return 0;
		//	}
		//	return (int)GameDB.battle.GetMasteryRankData(familiarityStatus.masteryRank).grade;
		//}

		//// Token: 0x06006F45 RID: 28485 RVA: 0x001E98B8 File Offset: 0x001E7AB8
		//public AcE_WEAPON_TYPE GetTopFamiliarityType()
		//{
		//	AcE_WEAPON_TYPE result = AcE_WEAPON_TYPE.NONE;
		//	float num = 0f;
		//	for (int i = 0; i < this.weaponVeteranGrades.Count; i++)
		//	{
		//		if (this.weaponVeteranGrades[i].totalFamiliarity > num)
		//		{
		//			num = this.weaponVeteranGrades[i].totalFamiliarity;
		//			result = this.weaponVeteranGrades[i].weaponType;
		//		}
		//	}
		//	return result;
		//}

		//// Token: 0x06006F46 RID: 28486 RVA: 0x0004D710 File Offset: 0x0004B910
		//public AcE_WEAPON_TYPE GetEquipedWeaponType()
		//{
		//	if (this.equipments == null)
		//	{
		//		return AcE_WEAPON_TYPE.PUNCH;
		//	}
		//	return this.myWeaponType;
		//}

		//// Token: 0x06006F47 RID: 28487 RVA: 0x001E991C File Offset: 0x001E7B1C
		//public void SetFamilarityValue(AcE_WEAPON_TYPE weaponType, float value)
		//{
		//	if (weaponType == AcE_WEAPON_TYPE.NONE)
		//	{
		//		return;
		//	}
		//	if (this.weaponVeteranGrades == null || this.weaponVeteranGrades.Count <= 0)
		//	{
		//		AcLogger.LogWarning("[CharacterAbility] SetFamilarityValue : weaponVeteranGrades is null : type =" + weaponType);
		//		return;
		//	}
		//	FamiliarityStatus familiarityStatus = this.weaponVeteranGrades.Find((FamiliarityStatus x) => x.weaponType == weaponType);
		//	if (familiarityStatus == null)
		//	{
		//		AcLogger.LogWarning("[CharacterAbility] SetFamilarityValue : FamiliarityStatus is null : type =" + weaponType);
		//		return;
		//	}
		//	familiarityStatus.baseFamiliarity = value;
		//	familiarityStatus.masteryRank = GameDB.battle.GetMasteryRankDataByWeaponType(weaponType, value).masteryId;
		//}

		//// Token: 0x06006F48 RID: 28488 RVA: 0x001E99CC File Offset: 0x001E7BCC
		//private float GetPrimitiveFamilarityValue(AcE_WEAPON_TYPE familiarity)
		//{
		//	if (this.weaponVeteranGrades == null)
		//	{
		//		AcLogger.LogWarning("[FieldCharacter] GetPrimitiveFamilarityValue Failed : weaponVeteranGrades is null : type =" + familiarity);
		//		return 0f;
		//	}
		//	FamiliarityStatus familiarityStatus = this.weaponVeteranGrades.Find((FamiliarityStatus t) => t.weaponType == familiarity);
		//	if (familiarityStatus == null)
		//	{
		//		AcLogger.LogWarning("[FieldCharacter] GetPrimitiveFamilarityValue Failed");
		//		return 0f;
		//	}
		//	return familiarityStatus.totalFamiliarity;
		//}

		//// Token: 0x06006F49 RID: 28489 RVA: 0x0004D722 File Offset: 0x0004B922
		//public float GetFamiliarity(AcE_WEAPON_TYPE familiarity)
		//{
		//	if (familiarity == AcE_WEAPON_TYPE.BLADE_STAB)
		//	{
		//		return Mathf.Max(this.GetPrimitiveFamilarityValue(AcE_WEAPON_TYPE.BLADE), this.GetPrimitiveFamilarityValue(AcE_WEAPON_TYPE.STAB));
		//	}
		//	return this.GetPrimitiveFamilarityValue(familiarity);
		//}

		//// Token: 0x06006F4A RID: 28490 RVA: 0x001E9A40 File Offset: 0x001E7C40
		//public SkillStatus FindSkillStatus(int skillId, Action<SkillStatus> callback)
		//{
		//	if (this.skillStatusList == null)
		//	{
		//		return null;
		//	}
		//	SkillStatus skillStatus = this.skillStatusList.Find((SkillStatus status) => status.skillId == skillId);
		//	if (skillStatus != null && callback != null)
		//	{
		//		callback(skillStatus);
		//	}
		//	return skillStatus;
		//}

		//// Token: 0x06006F4B RID: 28491 RVA: 0x001E9A8C File Offset: 0x001E7C8C
		//public string GetAlignedFamiliarity(AcE_WEAPON_TYPE _Type)
		//{
		//	return Math.Truncate((double)this.GetFamiliarity(_Type)).ToString();
		//}

		//// Token: 0x06006F4C RID: 28492 RVA: 0x001E9AB0 File Offset: 0x001E7CB0
		//public int GetEnemySkinType(string _NickName)
		//{
		//	EnemyInfomation enemyInfomation = Ingame.inst.game.GetEnemyInfomation(_NickName);
		//	if (enemyInfomation == null)
		//	{
		//		return 0;
		//	}
		//	return enemyInfomation.activeCharacterSkinType;
		//}

		//// Token: 0x06006F4D RID: 28493 RVA: 0x001E9ADC File Offset: 0x001E7CDC
		//public int GetEnemyWeaponItem(string _NickName)
		//{
		//	EnemyInfomation enemyInfomation = Ingame.inst.game.GetEnemyInfomation(_NickName);
		//	if (enemyInfomation != null)
		//	{
		//		return enemyInfomation.GetWeaponItem();
		//	}
		//	return 0;
		//}

		//// Token: 0x06006F4E RID: 28494 RVA: 0x001E9B08 File Offset: 0x001E7D08
		//public string GetEnemyWeaponItemName(string _NickName)
		//{
		//	int enemyWeaponItem = this.GetEnemyWeaponItem(_NickName);
		//	if (enemyWeaponItem == 0)
		//	{
		//		return "주먹";
		//	}
		//	return GameDB.item.Find(enemyWeaponItem).GetItemName();
		//}

		//// Token: 0x06006F4F RID: 28495 RVA: 0x0004D743 File Offset: 0x0004B943
		//public bool IsMyNickName(string nickName)
		//{
		//	return this.userNickname == nickName;
		//}

		//// Token: 0x04005D49 RID: 23881
		//[JsonProperty("cha")]
		//public CharacterAbility characterAbility;

		//// Token: 0x04005D4A RID: 23882
		//[JsonProperty("ivn")]
		//public Inventory inventory;

		//// Token: 0x04005D4B RID: 23883
		//[JsonProperty("eqp")]
		//public Equipments equipments;

		//// Token: 0x04005D4C RID: 23884
		//[JsonProperty("wdt")]
		//public List<WoundType> woundTypes;

		//// Token: 0x04005D4D RID: 23885
		//[JsonProperty("cto")]
		//public float CharacterOffence;

		//// Token: 0x04005D4E RID: 23886
		//[JsonProperty("ctd")]
		//public float CharacterDefence;

		//// Token: 0x04005D4F RID: 23887
		//[JsonProperty("ckc")]
		//public int characterKillCount;

		//// Token: 0x04005D50 RID: 23888
		//[JsonProperty("mkc")]
		//public int monsterKillCount;

		//// Token: 0x04005D51 RID: 23889
		//[JsonProperty("chs")]
		//public CharacterStance characterStance;

		//// Token: 0x04005D52 RID: 23890
		//[JsonProperty("lfu")]
		//public string lastFightUserNickName;

		//// Token: 0x04005D53 RID: 23891
		//[JsonProperty("cft")]
		//public int currentFieldType;

		//// Token: 0x04005D54 RID: 23892
		//[JsonProperty("cht")]
		//public HealthStatus characterHealthStatus;

		//// Token: 0x04005D55 RID: 23893
		//[JsonProperty("mfi")]
		//public List<FieldItem> memoryFieldItem;

		//// Token: 0x04005D56 RID: 23894
		//[JsonProperty("sbl")]
		//public List<SkillStatus> skillStatusList;

		//// Token: 0x04005D57 RID: 23895
		//[JsonProperty("sdl")]
		//public List<SkillStatus> debuffStatusList;

		//// Token: 0x04005D58 RID: 23896
		//[JsonProperty("wvg")]
		//public List<FamiliarityStatus> weaponVeteranGrades;

		//// Token: 0x04005D59 RID: 23897
		//[JsonProperty("wtp")]
		//public AcE_WEAPON_TYPE myWeaponType;

		//// Token: 0x04005D5A RID: 23898
		//[JsonProperty("ded")]
		//public bool isDead;

		//// Token: 0x04005D5B RID: 23899
		//[JsonProperty("ddc")]
		//public int deadCount;

		//// Token: 0x04005D5C RID: 23900
		//[JsonProperty("drr")]
		//public DeadReasonResult deadReasonResult;

		//// Token: 0x04005D5D RID: 23901
		//[JsonProperty("isl")]
		//public bool isSlayer;

		//// Token: 0x04005D5E RID: 23902
		//[JsonProperty("aep")]
		//public readonly List<ItemBaseStat> properties;

		//// Token: 0x04005D5F RID: 23903
		//[JsonProperty("ant")]
		//public readonly string announceSubtype;

		//// Token: 0x04005D60 RID: 23904
		//[JsonProperty("aot")]
		//public readonly string monologueSubType;

		//// Token: 0x04005D61 RID: 23905
		//[JsonProperty("ltt")]
		//public readonly string lanternSubtype;

		//// Token: 0x04005D62 RID: 23906
		//[JsonProperty("cvt")]
		//public readonly string voiceName;

		//// Token: 0x04005D63 RID: 23907
		//[JsonProperty("emj")]
		//public readonly string activeEmoticon;

		//// Token: 0x04005D64 RID: 23908
		//[JsonProperty("rcc")]
		//public readonly int reconCount;

		//// Token: 0x04005D65 RID: 23909
		//[JsonProperty("asc")]
		//public int assistKillCount;

		//// Token: 0x04005D66 RID: 23910
		//[JsonProperty("sil")]
		//public List<SilenceSet> muteList;

		//// Token: 0x04005D67 RID: 23911
		//[JsonProperty("pkl")]
		//public List<int> perkIdList;

		//// Token: 0x04005D68 RID: 23912
		//[JsonProperty("tis")]
		//public List<int> takeSupplyList;
	}
}
