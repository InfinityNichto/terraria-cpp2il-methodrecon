using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A9B RID: 2715
	public class UIBestiaryFilteringOptionsGrid : UIPanel
	{
		// Token: 0x1400005E RID: 94
		// (add) Token: 0x0600501B RID: 20507 RVA: 0x0027C560 File Offset: 0x0027A760
		// (remove) Token: 0x0600501C RID: 20508 RVA: 0x0027C584 File Offset: 0x0027A784
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

		// Token: 0x0600501D RID: 20509 RVA: 0x0027C5A8 File Offset: 0x0027A7A8
		public UIBestiaryFilteringOptionsGrid(EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer)
		{
			int num = 1;
			base..ctor();
			this._filterer = filterer;
			if (num == 0)
			{
			}
			Color color;
			this.BackgroundColor = color;
			Color color2;
			this.BorderColor = color2;
			this.BuildContainer();
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x0027C5F4 File Offset: 0x0027A7F4
		private void BuildContainer()
		{
			if (!true)
			{
			}
			Color color2;
			Color color = color2 * 0f;
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x000021DB File Offset: 0x000003DB
		public void SetupAvailabilityTest(List<BestiaryEntry> allAvailableEntries)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x000021DB File Offset: 0x000003DB
		public void UpdateAvailability()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x0027C630 File Offset: 0x0027A830
		public void GetEntriesToShow([Out] int maxEntriesWidth, [Out] int maxEntriesHeight, [Out] int maxEntriesToHave)
		{
			maxEntriesWidth.m_value = 1;
			maxEntriesHeight.m_value = 1;
			int size = this._filterer.AvailableFilters._size;
			maxEntriesToHave.m_value = size;
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x0027C664 File Offset: 0x0027A864
		private void GetDisplaySettings([Out] int widthPerButton, [Out] int heightPerButton, [Out] int widthWithSpacing, [Out] int heightWithSpacing, [Out] int perRow, [Out] float offsetLeft, [Out] float offsetTop, [Out] int howManyRows)
		{
			int num = 32;
			widthPerButton.m_value = num;
			heightPerButton.m_value = num;
			int num2 = 12;
			perRow.m_value = num2;
			EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer = this._filterer;
			int num3 = 16576;
			int size = filterer.AvailableFilters._size;
			howManyRows.m_value = num3;
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x0027C6B0 File Offset: 0x0027A8B0
		private void UpdateButtonSelections()
		{
			List<GroupOptionButton<int>> filterButtons = this._filterButtons;
			bool flag = this._filterer.IsFilterActive(int.MinValue);
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x000021DB File Offset: 0x000003DB
		private bool GetIsFilterAvailableForEntries(IBestiaryEntryFilter filter, List<BestiaryEntry> entries)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x0027C6F0 File Offset: 0x0027A8F0
		private void AddOnHover(IBestiaryEntryFilter filter, UIElement button)
		{
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x0027C700 File Offset: 0x0027A900
		private void ShowButtonName(UIElement element, IBestiaryEntryFilter number)
		{
			if (element.<IsMouseHovering>k__BackingField)
			{
				return;
			}
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x0027C718 File Offset: 0x0027A918
		private void ClickOption(UIMouseEvent evt, UIElement listeningElement)
		{
			if (listeningElement != null)
			{
			}
			this._filterer.ToggleFilter(int.MinValue);
			this.UpdateButtonSelections();
			Action onClickingOption = this.OnClickingOption;
			if (onClickingOption != null)
			{
				IntPtr invoke_impl = onClickingOption.invoke_impl;
				IntPtr method_code = onClickingOption.method_code;
				IntPtr method = onClickingOption.method;
				return;
			}
		}

		// Token: 0x040088F4 RID: 35060
		private EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> _filterer;

		// Token: 0x040088F5 RID: 35061
		private List<GroupOptionButton<int>> _filterButtons;

		// Token: 0x040088F6 RID: 35062
		private List<bool> _areFiltersAvailable;

		// Token: 0x040088F7 RID: 35063
		private List<List<BestiaryEntry>> _filterAvailabilityTests;

		// Token: 0x040088F8 RID: 35064
		[CompilerGenerated]
		private Action OnClickingOption;

		// Token: 0x040088F9 RID: 35065
		private UIElement _container;

		// Token: 0x02000A9C RID: 2716
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06005028 RID: 20520 RVA: 0x0027C764 File Offset: 0x0027A964
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06005029 RID: 20521 RVA: 0x0027C778 File Offset: 0x0027A978
			internal void <AddOnHover>b__0(UIElement element)
			{
				IBestiaryEntryFilter bestiaryEntryFilter = this.filter;
			}

			// Token: 0x040088FA RID: 35066
			public UIBestiaryFilteringOptionsGrid <>4__this;

			// Token: 0x040088FB RID: 35067
			public IBestiaryEntryFilter filter;
		}
	}
}
