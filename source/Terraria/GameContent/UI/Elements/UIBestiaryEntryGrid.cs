using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A98 RID: 2712
	public class UIBestiaryEntryGrid : UIElement
	{
		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06005007 RID: 20487 RVA: 0x0027C15C File Offset: 0x0027A35C
		// (remove) Token: 0x06005008 RID: 20488 RVA: 0x0027C180 File Offset: 0x0027A380
		public event Action OnGridContentsChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnGridContentsChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnGridContentsChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x0027C1A4 File Offset: 0x0027A3A4
		public UIBestiaryEntryGrid(List<BestiaryEntry> workingSet, UIElement.MouseEvent clickOnEntryEvent)
		{
			if (!true)
			{
			}
			base..ctor();
			this._workingSetEntries = workingSet;
			this._clickOnEntryEvent = clickOnEntryEvent;
			int size = this._workingSetEntries._size;
			this._lastEntry = size;
			this.FillBestiarySpaceWithEntries();
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x0027C1E4 File Offset: 0x0027A3E4
		public void UpdateEntries()
		{
			int size = this._workingSetEntries._size;
			this._lastEntry = size;
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x0027C204 File Offset: 0x0027A404
		public void FillBestiarySpaceWithEntries()
		{
			base.RemoveAllChildren();
			List<BestiaryEntry> workingSetEntries = this._workingSetEntries;
			float x = this._dimensions.X;
			int size = workingSetEntries._size;
			this._lastEntry = size;
			int num = 36409;
			long num2 = 0L;
			int atEntryIndex = this._atEntryIndex;
			int lastEntry = this._lastEntry;
			if (num == 0)
			{
			}
			int num3 = Math.Min(lastEntry, (int)num2);
			List<BestiaryEntry> workingSetEntries2 = this._workingSetEntries;
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x0027C27C File Offset: 0x0027A47C
		public override void Recalculate()
		{
			base.Recalculate();
			this.FillBestiarySpaceWithEntries();
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x0027C298 File Offset: 0x0027A498
		public void GetEntriesToShow([Out] int maxEntriesWidth, [Out] int maxEntriesHeight, [Out] int maxEntriesToHave)
		{
			float x = this._dimensions.X;
			int num = 36409;
			maxEntriesHeight.m_value = num;
			maxEntriesToHave.m_value = num;
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x0027C2C8 File Offset: 0x0027A4C8
		public string GetRangeText()
		{
			float x = this._dimensions.X;
			long num = 0L;
			int atEntryIndex = this._atEntryIndex;
			int num2 = Math.Min(this._lastEntry, (int)num);
			int num3 = Math.Min(num2, num2);
			int lastEntry = this._lastEntry;
			string text;
			return text;
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x0027C310 File Offset: 0x0027A510
		public void MakeButtonGoByOffset(UIElement element, int howManyPages)
		{
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x0027C320 File Offset: 0x0027A520
		public void OffsetLibraryByPages(int howManyPages)
		{
			float x = this._dimensions.X;
			long num = 0L;
			this.OffsetLibrary((int)num);
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x0027C344 File Offset: 0x0027A544
		public void OffsetLibrary(int offset)
		{
			float x = this._dimensions.X;
			this.FillBestiarySpaceWithEntries();
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x0027C364 File Offset: 0x0027A564
		private void FixBestiaryRange(int offset, int maxEntriesToHave)
		{
			int num = 1;
			int atEntryIndex = this._atEntryIndex;
			int lastEntry = this._lastEntry;
			if (num == 0)
			{
			}
			int num2 = Math.Max(0, offset);
			Action onGridContentsChanged = this.OnGridContentsChanged;
			if (onGridContentsChanged != null)
			{
				IntPtr invoke_impl = onGridContentsChanged.invoke_impl;
				IntPtr method_code = onGridContentsChanged.method_code;
				IntPtr method = onGridContentsChanged.method;
				return;
			}
		}

		// Token: 0x040088E8 RID: 35048
		private List<BestiaryEntry> _workingSetEntries;

		// Token: 0x040088E9 RID: 35049
		private UIElement.MouseEvent _clickOnEntryEvent;

		// Token: 0x040088EA RID: 35050
		private int _atEntryIndex;

		// Token: 0x040088EB RID: 35051
		private int _lastEntry;

		// Token: 0x040088EC RID: 35052
		[CompilerGenerated]
		private Action OnGridContentsChanged;

		// Token: 0x02000A99 RID: 2713
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06005013 RID: 20499 RVA: 0x0027C3B4 File Offset: 0x0027A5B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06005014 RID: 20500 RVA: 0x0027C3C8 File Offset: 0x0027A5C8
			internal void <MakeButtonGoByOffset>b__0(UIMouseEvent e, UIElement v)
			{
				UIBestiaryEntryGrid uibestiaryEntryGrid = this.<>4__this;
				int num = this.howManyPages;
				uibestiaryEntryGrid.OffsetLibraryByPages(num);
			}

			// Token: 0x040088ED RID: 35053
			public UIBestiaryEntryGrid <>4__this;

			// Token: 0x040088EE RID: 35054
			public int howManyPages;
		}
	}
}
