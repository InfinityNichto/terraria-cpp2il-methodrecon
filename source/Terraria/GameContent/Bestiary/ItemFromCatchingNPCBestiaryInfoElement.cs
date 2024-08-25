using System;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000961 RID: 2401
	public class ItemFromCatchingNPCBestiaryInfoElement : IItemBestiaryInfoElement, IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x0600480A RID: 18442 RVA: 0x0025FADC File Offset: 0x0025DCDC
		public ItemFromCatchingNPCBestiaryInfoElement(int itemId)
		{
			this._itemType = itemId;
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x0025FAF8 File Offset: 0x0025DCF8
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return "catch item #";
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x0025FB18 File Offset: 0x0025DD18
		public string GetSearchString(BestiaryUICollectionInfo info)
		{
			if (info.UnlockState == BestiaryEntryUnlockState.NotKnownAtAll_0)
			{
			}
			int itemType = this._itemType;
			string text;
			return text;
		}

		// Token: 0x040083A1 RID: 33697
		private int _itemType;
	}
}
