using System;

// Token: 0x020002A8 RID: 680
public interface IPlatformAwardNotifier
{
	// Token: 0x06000FBD RID: 4029
	void Initialize(LocalUser user);

	// Token: 0x06000FBE RID: 4030
	void NoteSlimeDefeated(eSlimeKillStatistics slimeID);

	// Token: 0x06000FBF RID: 4031
	void NoteItemCrafted(eCraftingStatistics craftingID);

	// Token: 0x06000FC0 RID: 4032
	void NoteTraveled(eDistanceStatistics distanceID);

	// Token: 0x06000FC1 RID: 4033
	void NoteMined(eMiningStatistics miningID, int amount);

	// Token: 0x06000FC2 RID: 4034
	void NoteBossKill(eBossKillStatistics bossID);

	// Token: 0x06000FC3 RID: 4035
	void NoteTrigger(eTrigger triggerType);
}
