using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020002BD RID: 701
[JsonObject(MemberSerialization.Fields)]
public class PersistentUserData
{
	// Token: 0x0600103B RID: 4155 RVA: 0x0004FD30 File Offset: 0x0004DF30
	public void EnsureObjects()
	{
		if (this.ArmorCollected == null)
		{
		}
		if (this.CraftingsStationsUsed == null)
		{
		}
		if (this.SlimeTypesKilled == null)
		{
		}
		if (this.PetBuffsSpawned == null)
		{
		}
		if (this.BossesKilled == null)
		{
		}
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x0004FD68 File Offset: 0x0004DF68
	public void OnKillBoss(eBossKillStatistics bossID)
	{
		Dictionary<int, int> bossesKilled = this.BossesKilled;
		Dictionary<int, int> bossesKilled2 = this.BossesKilled;
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x0004FD84 File Offset: 0x0004DF84
	public int GetProgressNumberOfTimesKilledAllBosses()
	{
		if (!true)
		{
		}
		Type type;
		IEnumerator enumerator = Enum.GetValues(type).GetEnumerator();
		Dictionary<int, int> bossesKilled = this.BossesKilled;
		Dictionary<int, int> bossesKilled2 = this.BossesKilled;
		long num = 0L;
		if (enumerator != null)
		{
		}
		if (num == 0L)
		{
			throw new InvalidCastException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
	public int GetNormlBossCount()
	{
		if (!true)
		{
		}
		Type type;
		IEnumerator enumerator = Enum.GetValues(type).GetEnumerator();
		Dictionary<int, int> bossesKilled = this.BossesKilled;
		Dictionary<int, int> bossesKilled2 = this.BossesKilled;
		long num = 0L;
		if (enumerator != null)
		{
		}
		if (num == 0L)
		{
			throw new InvalidCastException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x0004FE34 File Offset: 0x0004E034
	public int GetHardBossCount()
	{
		if (!true)
		{
		}
		Type type;
		IEnumerator enumerator = Enum.GetValues(type).GetEnumerator();
		Dictionary<int, int> bossesKilled = this.BossesKilled;
		Dictionary<int, int> bossesKilled2 = this.BossesKilled;
		long num = 0L;
		if (enumerator != null)
		{
		}
		if (num == 0L)
		{
			throw new InvalidCastException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x0004FE88 File Offset: 0x0004E088
	public int GetNumberOfTimesKilledAllBosses()
	{
		if (!true)
		{
		}
		Type type;
		IEnumerator enumerator = Enum.GetValues(type).GetEnumerator();
		Dictionary<int, int> bossesKilled = this.BossesKilled;
		Dictionary<int, int> bossesKilled2 = this.BossesKilled;
		long num = 0L;
		if (enumerator != null)
		{
		}
		if (num == 0L)
		{
			throw new InvalidCastException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x0004FEE0 File Offset: 0x0004E0E0
	public int GetNumberOfTimesKilledPrimeBosses()
	{
		Dictionary<int, int> bossesKilled = this.BossesKilled;
		Dictionary<int, int> bossesKilled2 = this.BossesKilled;
		Dictionary<int, int> bossesKilled3 = this.BossesKilled;
		Dictionary<int, int> bossesKilled4 = this.BossesKilled;
		Dictionary<int, int> bossesKilled5 = this.BossesKilled;
		Dictionary<int, int> bossesKilled6 = this.BossesKilled;
		if (bossesKilled != null)
		{
			return;
		}
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x0004FF24 File Offset: 0x0004E124
	public int GetNumberOfRequiredSlimesKilled()
	{
		if (!true)
		{
		}
		Type type;
		IEnumerator enumerator = Enum.GetValues(type).GetEnumerator();
		IntHashSet slimeTypesKilled = this.SlimeTypesKilled;
		long num = 0L;
		if (enumerator != null)
		{
		}
		if (num == 0L)
		{
			throw new InvalidCastException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x0004FF70 File Offset: 0x0004E170
	public PersistentUserData()
	{
	}

	// Token: 0x04001F1F RID: 7967
	public uint TotalBarsCrafted;

	// Token: 0x04001F20 RID: 7968
	public uint TotalPicked;

	// Token: 0x04001F21 RID: 7969
	public uint TotalAnvilCrafting;

	// Token: 0x04001F22 RID: 7970
	public uint TotalWires;

	// Token: 0x04001F23 RID: 7971
	public uint TotalAirTime;

	// Token: 0x04001F24 RID: 7972
	public uint CurrentAirTime;

	// Token: 0x04001F25 RID: 7973
	public IntHashSet ArmorCollected;

	// Token: 0x04001F26 RID: 7974
	public IntHashSet CraftingsStationsUsed;

	// Token: 0x04001F27 RID: 7975
	public IntHashSet SlimeTypesKilled;

	// Token: 0x04001F28 RID: 7976
	public IntHashSet PetBuffsSpawned;

	// Token: 0x04001F29 RID: 7977
	public Dictionary<int, int> BossesKilled;

	// Token: 0x04001F2A RID: 7978
	public long TotalGemsMined;

	// Token: 0x04001F2B RID: 7979
	public long TotalOresMined;

	// Token: 0x04001F2C RID: 7980
	public long TotalSoilMined;

	// Token: 0x04001F2D RID: 7981
	public long TotalWoodMined;

	// Token: 0x04001F2E RID: 7982
	public long TotalResourcesMined;
}
