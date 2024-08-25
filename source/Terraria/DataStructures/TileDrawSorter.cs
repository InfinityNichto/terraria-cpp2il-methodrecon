using System;
using System.Collections.Generic;

namespace Terraria.DataStructures
{
	// Token: 0x0200067A RID: 1658
	public class TileDrawSorter
	{
		// Token: 0x06003742 RID: 14146 RVA: 0x00221598 File Offset: 0x0021F798
		public TileDrawSorter()
		{
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x002215AC File Offset: 0x0021F7AC
		public void reset()
		{
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x002215BC File Offset: 0x0021F7BC
		public void Cache(int x, int y, int type)
		{
			TileDrawSorter.TileTexPoint[] array = this.tilesToDraw;
			int holderLength = this._holderLength;
			this.IncreaseArraySize();
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x002215E0 File Offset: 0x0021F7E0
		private void IncreaseArraySize()
		{
			int holderLength = this._holderLength;
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x002215F4 File Offset: 0x0021F7F4
		public void Sort()
		{
			TileDrawSorter.TileTexPoint[] array = this.tilesToDraw;
			int currentCacheIndex = this._currentCacheIndex;
			TileDrawSorter.CustomComparer tileComparer = this._tileComparer;
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00221618 File Offset: 0x0021F818
		public int GetAmountToDraw()
		{
			return this._currentCacheIndex;
		}

		// Token: 0x0400786D RID: 30829
		public TileDrawSorter.TileTexPoint[] tilesToDraw;

		// Token: 0x0400786E RID: 30830
		private int _holderLength;

		// Token: 0x0400786F RID: 30831
		private int _currentCacheIndex;

		// Token: 0x04007870 RID: 30832
		private TileDrawSorter.CustomComparer _tileComparer;

		// Token: 0x0200067B RID: 1659
		public struct TileTexPoint
		{
			// Token: 0x06003748 RID: 14152 RVA: 0x0022162C File Offset: 0x0021F82C
			public override string ToString()
			{
				int y = this.Y;
				int tileType = this.TileType;
				string text;
				return text;
			}

			// Token: 0x04007871 RID: 30833
			public int X;

			// Token: 0x04007872 RID: 30834
			public int Y;

			// Token: 0x04007873 RID: 30835
			public int TileType;
		}

		// Token: 0x0200067C RID: 1660
		public class CustomComparer : Comparer<TileDrawSorter.TileTexPoint>
		{
			// Token: 0x06003749 RID: 14153 RVA: 0x00221648 File Offset: 0x0021F848
			public override int Compare(TileDrawSorter.TileTexPoint x, TileDrawSorter.TileTexPoint y)
			{
				int num;
				return num;
			}

			// Token: 0x0600374A RID: 14154 RVA: 0x00221658 File Offset: 0x0021F858
			public CustomComparer()
			{
			}
		}
	}
}
