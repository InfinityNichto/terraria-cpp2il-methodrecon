using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AA4 RID: 2724
	public class UIBestiaryInfoItemLine : UIPanel, IManuallyOrderedUIElement
	{
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06005047 RID: 20551 RVA: 0x0027CCF8 File Offset: 0x0027AEF8
		// (set) Token: 0x06005048 RID: 20552 RVA: 0x0027CD0C File Offset: 0x0027AF0C
		public int OrderInUIList
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderInUIList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderInUIList>k__BackingField = value;
			}
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x0027CD20 File Offset: 0x0027AF20
		public UIBestiaryInfoItemLine(DropRateInfo info, BestiaryUICollectionInfo uiinfo, float textScale = 1f)
		{
			List<IItemDropRuleCondition> conditions = info.conditions;
			int num = 16896;
			this.BorderColor = num;
			List<IItemDropRuleCondition> conditions2 = info.conditions;
			Item infoDisplayItem = this._infoDisplayItem;
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x0027CD84 File Offset: 0x0027AF84
		public static void GetDropInfo(DropRateInfo dropRateInfo, BestiaryUICollectionInfo uiinfo, [Out] string stackRange, [Out] string droprate)
		{
			int stackMin = dropRateInfo.stackMin;
			int stackMin2 = dropRateInfo.stackMin;
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x0027CDD0 File Offset: 0x0027AFD0
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			base.DrawSelf(spriteBatch);
			if (!this.<IsMouseHovering>k__BackingField || this._hideMouseOver)
			{
				return;
			}
			this.DrawMouseOver();
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x0027CDFC File Offset: 0x0027AFFC
		private void DrawMouseOver()
		{
			Item infoDisplayItem = this._infoDisplayItem;
			if (!true)
			{
			}
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x0027CE14 File Offset: 0x0027B014
		public override int CompareTo(object obj)
		{
			if (obj != null)
			{
				int num = this.<OrderInUIList>k__BackingField;
			}
			return base.CompareTo(obj);
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x0027CE40 File Offset: 0x0027B040
		private void SetBestiaryNotesOnItemCache(DropRateInfo info)
		{
			if (info.conditions != null)
			{
				while (info == null)
				{
				}
				return;
			}
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x0027CE8C File Offset: 0x0027B08C
		private void MouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			if (!true)
			{
			}
			this.BorderColor = 1;
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x0027CEA4 File Offset: 0x0027B0A4
		private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x04008919 RID: 35097
		[CompilerGenerated]
		private int <OrderInUIList>k__BackingField;

		// Token: 0x0400891A RID: 35098
		private Item _infoDisplayItem;

		// Token: 0x0400891B RID: 35099
		private bool _hideMouseOver;
	}
}
