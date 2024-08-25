using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000940 RID: 2368
	public class BestiaryEntry
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x0025EC04 File Offset: 0x0025CE04
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x0025EC18 File Offset: 0x0025CE18
		public List<IBestiaryInfoElement> Info
		{
			[CompilerGenerated]
			get
			{
				return this.<Info>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Info>k__BackingField = value;
			}
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x0025EC2C File Offset: 0x0025CE2C
		public BestiaryEntry()
		{
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x0025EC40 File Offset: 0x0025CE40
		public static BestiaryEntry Enemy(int npcNetId)
		{
			if (!true)
			{
			}
			string key = Lang.GetNPCName(42178960).Key;
			return int.MinValue;
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x0025ECA4 File Offset: 0x0025CEA4
		public static BestiaryEntry TownNPC(int npcNetId)
		{
			if (!true)
			{
			}
			string key = Lang.GetNPCName(42178960).Key;
			return int.MinValue;
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x0025ED00 File Offset: 0x0025CF00
		public static BestiaryEntry Critter(int npcNetId)
		{
			if (!true)
			{
			}
			string key = Lang.GetNPCName(42178960).Key;
			return int.MinValue;
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x000021DB File Offset: 0x000003DB
		public static BestiaryEntry Biome(string nameLanguageKey, string texturePath, Func<bool> unlockCondition)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x0025ED48 File Offset: 0x0025CF48
		public void AddTags(params IBestiaryInfoElement[] elements)
		{
			List<IBestiaryInfoElement> list = this.<Info>k__BackingField;
		}

		// Token: 0x04008368 RID: 33640
		public IEntryIcon Icon;

		// Token: 0x04008369 RID: 33641
		[CompilerGenerated]
		private List<IBestiaryInfoElement> <Info>k__BackingField;

		// Token: 0x0400836A RID: 33642
		public IBestiaryUICollectionInfoProvider UIInfoProvider;
	}
}
