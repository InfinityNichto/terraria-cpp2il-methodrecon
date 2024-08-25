using System;
using Terraria;
using Terraria.Achievements;

// Token: 0x0200029F RID: 671
public class PlatformAwardNotifier_Stub : IPlatformAwardNotifier
{
	// Token: 0x06000FB5 RID: 4021 RVA: 0x0004E9D4 File Offset: 0x0004CBD4
	public void Initialize(LocalUser user)
	{
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0004E9E4 File Offset: 0x0004CBE4
	public void NoteSlimeDefeated(eSlimeKillStatistics slimeID)
	{
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x0004E9F4 File Offset: 0x0004CBF4
	public void NoteItemCrafted(eCraftingStatistics craftingID)
	{
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x0004EA04 File Offset: 0x0004CC04
	public void NoteTraveled(eDistanceStatistics distanceID)
	{
		AchievementCondition condition = Main.Achievements.GetCondition("MARATHON_MEDALIST", "Move");
		int num = 17096;
		int num2 = this.lastTraveledPercent;
		this.lastTraveledPercent = num;
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x0004EA44 File Offset: 0x0004CC44
	public void NoteMined(eMiningStatistics miningID, int amount)
	{
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x0004EA54 File Offset: 0x0004CC54
	public void NoteBossKill(eBossKillStatistics bossID)
	{
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x0004EA64 File Offset: 0x0004CC64
	public void NoteTrigger(eTrigger triggerType)
	{
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x0004EA74 File Offset: 0x0004CC74
	public PlatformAwardNotifier_Stub()
	{
	}

	// Token: 0x04001C80 RID: 7296
	private int lastTraveledPercent;
}
