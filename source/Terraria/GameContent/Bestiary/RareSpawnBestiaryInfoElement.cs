using System;
using System.Runtime.CompilerServices;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000954 RID: 2388
	public class RareSpawnBestiaryInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x0025F55C File Offset: 0x0025D75C
		// (set) Token: 0x060047CD RID: 18381 RVA: 0x0025F570 File Offset: 0x0025D770
		public int RarityLevel
		{
			[CompilerGenerated]
			get
			{
				return this.<RarityLevel>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<RarityLevel>k__BackingField = value;
			}
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x0025F584 File Offset: 0x0025D784
		public RareSpawnBestiaryInfoElement(int rarityLevel)
		{
			this.RarityLevel = rarityLevel;
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x0025F5A0 File Offset: 0x0025D7A0
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x0025F5B0 File Offset: 0x0025D7B0
		public string GetSearchString(BestiaryUICollectionInfo info)
		{
			if (info.UnlockState != BestiaryEntryUnlockState.NotKnownAtAll_0)
			{
				return Language.GetText("BestiaryInfo.IsRare").<Value>k__BackingField;
			}
		}

		// Token: 0x0400838C RID: 33676
		[CompilerGenerated]
		private int <RarityLevel>k__BackingField;
	}
}
