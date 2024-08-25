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
	// Token: 0x02000A9A RID: 2714
	public class UIBestiarySortingOptionsGrid : UIPanel
	{
		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06005015 RID: 20501 RVA: 0x0027C3EC File Offset: 0x0027A5EC
		// (remove) Token: 0x06005016 RID: 20502 RVA: 0x0027C410 File Offset: 0x0027A610
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

		// Token: 0x06005017 RID: 20503 RVA: 0x0027C434 File Offset: 0x0027A634
		public UIBestiarySortingOptionsGrid(EntrySorter<BestiaryEntry, IBestiarySortStep> sorter)
		{
			int num = 1;
			this._currentSelected = num;
			base..ctor();
			this._sorter = sorter;
			if (num == 0)
			{
			}
			Color color;
			this.BackgroundColor = color;
			Color color2;
			this.BorderColor = color2;
			this.BuildGrid();
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x000021DB File Offset: 0x000003DB
		private void BuildGrid()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x0027C488 File Offset: 0x0027A688
		private void ClickOption(UIMouseEvent evt, UIElement listeningElement)
		{
			if (listeningElement != null)
			{
			}
			int currentSelected = this._currentSelected;
			int defaultStepIndex = this._defaultStepIndex;
			List<GroupOptionButton<int>> buttonsBySorting = this._buttonsBySorting;
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x0027C528 File Offset: 0x0027A728
		public void GetEntriesToShow([Out] int maxEntriesWidth, [Out] int maxEntriesHeight, [Out] int maxEntriesToHave)
		{
			maxEntriesWidth.m_value = 1;
			List<GroupOptionButton<int>> buttonsBySorting = this._buttonsBySorting;
			int size = buttonsBySorting._size;
			maxEntriesHeight.m_value = size;
			int size2 = buttonsBySorting._size;
			maxEntriesToHave.m_value = size2;
		}

		// Token: 0x040088EF RID: 35055
		private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

		// Token: 0x040088F0 RID: 35056
		private List<GroupOptionButton<int>> _buttonsBySorting;

		// Token: 0x040088F1 RID: 35057
		private int _currentSelected;

		// Token: 0x040088F2 RID: 35058
		private int _defaultStepIndex;

		// Token: 0x040088F3 RID: 35059
		[CompilerGenerated]
		private Action OnClickingOption;
	}
}
