using System;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000970 RID: 2416
	public class SearchAliasInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x06004840 RID: 18496 RVA: 0x00260340 File Offset: 0x0025E540
		public SearchAliasInfoElement(string alias)
		{
			this._alias = alias;
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x0026035C File Offset: 0x0025E55C
		public string GetSearchString(BestiaryUICollectionInfo info)
		{
			if (info.UnlockState != BestiaryEntryUnlockState.NotKnownAtAll_0)
			{
				return this._alias;
			}
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x0026037C File Offset: 0x0025E57C
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
		}

		// Token: 0x040083BB RID: 33723
		private readonly string _alias;
	}
}
