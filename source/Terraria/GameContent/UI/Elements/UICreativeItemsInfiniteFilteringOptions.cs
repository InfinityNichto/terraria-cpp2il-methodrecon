using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A9D RID: 2717
	public class UICreativeItemsInfiniteFilteringOptions : UIElement
	{
		// Token: 0x1400005F RID: 95
		// (add) Token: 0x0600502A RID: 20522 RVA: 0x0027C78C File Offset: 0x0027A98C
		// (remove) Token: 0x0600502B RID: 20523 RVA: 0x0027C7B0 File Offset: 0x0027A9B0
		public event Action OnClickingOption
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnClickingOption, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnClickingOption, value) != null)
				{
				}
			}
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x0027C7D4 File Offset: 0x0027A9D4
		public UICreativeItemsInfiniteFilteringOptions(EntryFilterer<Item, IItemEntryFilter> filterer, string snapPointsName)
		{
			if (!true)
			{
			}
			base..ctor();
			this._filterer = filterer;
			int size = filterer.AvailableFilters._size;
			if (16928 == 0)
			{
			}
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x0027C86C File Offset: 0x0027AA6C
		private void button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x000021DB File Offset: 0x000003DB
		private void singleFilterButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x0027C87C File Offset: 0x0027AA7C
		private void UpdateVisuals(UIImageFramed button, int indexOfFilter)
		{
			bool flag = this._filterer.IsFilterActive(indexOfFilter);
			bool <IsMouseHovering>k__BackingField = button.<IsMouseHovering>k__BackingField;
			int num = true.ToInt();
			int num2 = true.ToInt();
			int num3 = <IsMouseHovering>k__BackingField.ToInt();
			if (this._iconsByButtons != null)
			{
				return;
			}
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x0027C8C0 File Offset: 0x0027AAC0
		private void AddOnHover(IItemEntryFilter filter, UIElement button, int indexOfFilter)
		{
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x0027C8D0 File Offset: 0x0027AAD0
		private void ShowButtonName(UIElement element, IItemEntryFilter number, int indexOfFilter)
		{
			if (element.<IsMouseHovering>k__BackingField)
			{
				return;
			}
		}

		// Token: 0x040088FC RID: 35068
		private EntryFilterer<Item, IItemEntryFilter> _filterer;

		// Token: 0x040088FD RID: 35069
		private Dictionary<UIImageFramed, IItemEntryFilter> _filtersByButtons;

		// Token: 0x040088FE RID: 35070
		private Dictionary<UIImageFramed, UIElement> _iconsByButtons;

		// Token: 0x040088FF RID: 35071
		[CompilerGenerated]
		private Action OnClickingOption;

		// Token: 0x04008900 RID: 35072
		private const int barFramesX = 2;

		// Token: 0x04008901 RID: 35073
		private const int barFramesY = 4;

		// Token: 0x02000A9E RID: 2718
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06005032 RID: 20530 RVA: 0x0027C8E8 File Offset: 0x0027AAE8
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06005033 RID: 20531 RVA: 0x0027C8FC File Offset: 0x0027AAFC
			internal void <AddOnHover>b__0(UIElement element)
			{
				IItemEntryFilter itemEntryFilter = this.filter;
			}

			// Token: 0x06005034 RID: 20532 RVA: 0x0027C910 File Offset: 0x0027AB10
			internal void <AddOnHover>b__1(UIElement element)
			{
				UICreativeItemsInfiniteFilteringOptions uicreativeItemsInfiniteFilteringOptions = this.<>4__this;
				UIElement uielement = this.button;
				int num = this.indexOfFilter;
				if (uielement != null)
				{
				}
			}

			// Token: 0x04008902 RID: 35074
			public UICreativeItemsInfiniteFilteringOptions <>4__this;

			// Token: 0x04008903 RID: 35075
			public IItemEntryFilter filter;

			// Token: 0x04008904 RID: 35076
			public int indexOfFilter;

			// Token: 0x04008905 RID: 35077
			public UIElement button;
		}
	}
}
