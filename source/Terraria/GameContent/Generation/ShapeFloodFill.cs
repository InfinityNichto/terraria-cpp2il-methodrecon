using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008D9 RID: 2265
	public class ShapeFloodFill : GenShape
	{
		// Token: 0x060045AC RID: 17836 RVA: 0x002552B8 File Offset: 0x002534B8
		public ShapeFloodFill(int maximumActions = 100)
		{
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x002552CC File Offset: 0x002534CC
		public override bool Perform(Point origin, GenAction action)
		{
			if (!true)
			{
			}
			int maximumActions = this._maximumActions;
			Tile.StartNewSearch();
			Tile tile;
			ushort tileSeachUID = tile.TileSeachUID;
			Tile tile2;
			ushort tileSeachUID2 = tile2.TileSeachUID;
			Tile tile3;
			ushort tileSeachUID3 = tile3.TileSeachUID;
			if (!false)
			{
			}
			Tile tile4;
			ushort tileSeachUID4 = tile4.TileSeachUID;
			if (!false)
			{
			}
			Tile tile5;
			ushort tileSeachUID5 = tile5.TileSeachUID;
			if (!false)
			{
			}
			return false;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x0025533C File Offset: 0x0025353C
		// Note: this type is marked as 'beforefieldinit'.
		static ShapeFloodFill()
		{
		}

		// Token: 0x04008211 RID: 33297
		private int _maximumActions;

		// Token: 0x04008212 RID: 33298
		private static Queue<Point> checkQueue;
	}
}
