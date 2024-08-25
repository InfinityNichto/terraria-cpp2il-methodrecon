using System;
using System.Collections.Generic;
using Terraria;

// Token: 0x020002AD RID: 685
public class PlatformAwardNotifierUtility
{
	// Token: 0x06000FC7 RID: 4039 RVA: 0x0004EAB0 File Offset: 0x0004CCB0
	public static void NoteSlimeDefeatedForPlayer(Player player, eSlimeKillStatistics slimeID)
	{
		LocalUser localUser = UserManagement.FindLocalUserByPlayer(player);
		if (localUser != null && localUser.PlatformAwards != null)
		{
			IntHashSet slimeTypesKilled = localUser.PersistentUserData.SlimeTypesKilled;
			IPlatformAwardNotifier platformAwards = localUser.PlatformAwards;
			return;
		}
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x0004EAE4 File Offset: 0x0004CCE4
	public static void NoteItemCraftedForPlayer(Player player, eCraftingStatistics craftingID)
	{
		if (!true)
		{
		}
		LocalUser localUser = UserManagement.FindLocalUserByPlayer(player);
		if (localUser != null && localUser.PlatformAwards != null)
		{
			return;
		}
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x0004EB08 File Offset: 0x0004CD08
	public static void NoteTraveledForPlayer(Player player, eDistanceStatistics distanceID)
	{
		if (!true)
		{
		}
		LocalUser localUser = UserManagement.FindLocalUserByPlayer(player);
		if (localUser != null && localUser.PlatformAwards != null)
		{
			return;
		}
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x0004EB2C File Offset: 0x0004CD2C
	public static void NoteMinedForPlayer(Player player, eMiningStatistics miningID)
	{
		if (!true)
		{
		}
		LocalUser localUser = UserManagement.FindLocalUserByPlayer(player);
		if (localUser != null && localUser.PlatformAwards != null)
		{
			return;
		}
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x0004EBD8 File Offset: 0x0004CDD8
	public static void NoteTriggerForPlayer(Player player, eTrigger triggerType)
	{
		if (!true)
		{
		}
		LocalUser localUser = UserManagement.FindLocalUserByPlayer(player);
		if (localUser != null && localUser.PlatformAwards != null)
		{
			return;
		}
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x0004EBFC File Offset: 0x0004CDFC
	public static void NoteBossKillForAllLocalUsers(eBossKillStatistics bossID)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x0004EC24 File Offset: 0x0004CE24
	public static void NoteTriggerForAllLocalUsers(eTrigger triggerType)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x0004EC4C File Offset: 0x0004CE4C
	public static void NoteItemPickedUpForPlayer(Player player, int itemID)
	{
		if (!true)
		{
		}
		LocalUser localUser = UserManagement.FindLocalUserByPlayer(player);
		if (localUser != null && localUser.PlatformAwards != null)
		{
			return;
		}
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x0004ECBC File Offset: 0x0004CEBC
	public static bool IsArmorForAchievement(int itemID)
	{
		if (!true)
		{
		}
		return true;
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x0004ECD0 File Offset: 0x0004CED0
	public static void NoteCraftingStationUsed(Player player, int tileID)
	{
		LocalUser localUser = UserManagement.FindLocalUserByPlayer(player);
		int achievementIDFromTileID = PlatformAwardNotifierUtility.GetAchievementIDFromTileID(tileID);
		localUser.PersistentUserData.CraftingsStationsUsed.Add(achievementIDFromTileID);
		List<int> valuesInSet = localUser.PersistentUserData.CraftingsStationsUsed.ValuesInSet;
		int size = valuesInSet._size;
		int size2 = valuesInSet._size;
		if (localUser.PlatformAwards != null)
		{
			return;
		}
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x0004ED28 File Offset: 0x0004CF28
	public static int GetAchievementIDFromTileID(int tileID)
	{
		if (!true)
		{
		}
		return 133;
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x0004ED44 File Offset: 0x0004CF44
	public static eSlimeKillStatistics GetSlimeStatIDFromNetID(int netID)
	{
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x0004ED84 File Offset: 0x0004CF84
	public static eBossKillStatistics GetBossStatIDFromNetID(int netID)
	{
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x0004EDD8 File Offset: 0x0004CFD8
	public static void RegisterKillTileStatistic(Player player, int tileType)
	{
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x0004EDF4 File Offset: 0x0004CFF4
	public PlatformAwardNotifierUtility()
	{
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x0004EE08 File Offset: 0x0004D008
	// Note: this type is marked as 'beforefieldinit'.
	static PlatformAwardNotifierUtility()
	{
	}

	// Token: 0x04001D7B RID: 7547
	public static int[] AchievementArmors;

	// Token: 0x04001D7C RID: 7548
	public static int[] AchievementCraftingStationsTracking;
}
