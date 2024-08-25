using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.GameContent.ItemDropRules;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000960 RID: 2400
	public class ItemDropBestiaryInfoElement : IItemBestiaryInfoElement, IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x06004805 RID: 18437 RVA: 0x0025FA78 File Offset: 0x0025DC78
		public ItemDropBestiaryInfoElement(DropRateInfo info)
		{
			List<IItemDropRuleCondition> conditions = info.conditions;
			this._droprateInfo.conditions = conditions;
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x0025FAA0 File Offset: 0x0025DCA0
		public bool ShouldShowItem()
		{
			bool flag;
			return flag;
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x000021DB File Offset: 0x000003DB
		public virtual UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x0025FAB0 File Offset: 0x0025DCB0
		private static bool ShouldShowItem(DropRateInfo dropRateInfo)
		{
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x0025FAC4 File Offset: 0x0025DCC4
		public string GetSearchString(BestiaryUICollectionInfo info)
		{
			if (info.UnlockState == BestiaryEntryUnlockState.NotKnownAtAll_0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x040083A0 RID: 33696
		public DropRateInfo _droprateInfo;
	}
}
