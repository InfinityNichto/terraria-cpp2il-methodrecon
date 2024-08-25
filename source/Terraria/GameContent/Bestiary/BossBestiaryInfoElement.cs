using System;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000955 RID: 2389
	public class BossBestiaryInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x060047D1 RID: 18385 RVA: 0x0025F5D8 File Offset: 0x0025D7D8
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x0025F5E8 File Offset: 0x0025D7E8
		public string GetSearchString(BestiaryUICollectionInfo info)
		{
			BestiaryEntryUnlockState unlockState = info.UnlockState;
			return Language.GetText("BestiaryInfo.IsBoss").<Value>k__BackingField;
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x0025F610 File Offset: 0x0025D810
		public BossBestiaryInfoElement()
		{
		}
	}
}
