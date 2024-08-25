using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Utilities;

namespace Terraria.DataStructures
{
	// Token: 0x02000679 RID: 1657
	public class TileDrawInfo
	{
		// Token: 0x06003741 RID: 14145 RVA: 0x00221584 File Offset: 0x0021F784
		public TileDrawInfo()
		{
		}

		// Token: 0x0400783C RID: 30780
		public SpriteBatch spriteBatch;

		// Token: 0x0400783D RID: 30781
		public SpriteBatch spriteBatch2;

		// Token: 0x0400783E RID: 30782
		public int tileIndex;

		// Token: 0x0400783F RID: 30783
		public uint tilePalIndex;

		// Token: 0x04007840 RID: 30784
		public Tile tileCache;

		// Token: 0x04007841 RID: 30785
		public ushort typeCache;

		// Token: 0x04007842 RID: 30786
		public short tileSHeader;

		// Token: 0x04007843 RID: 30787
		public short tileFrameX;

		// Token: 0x04007844 RID: 30788
		public short tileFrameY;

		// Token: 0x04007845 RID: 30789
		public unsafe uint* tileLookup;

		// Token: 0x04007846 RID: 30790
		public unsafe ushort* tileTypeData;

		// Token: 0x04007847 RID: 30791
		public unsafe short* tileTypeSHeader;

		// Token: 0x04007848 RID: 30792
		public unsafe byte* tileTypeLiquid;

		// Token: 0x04007849 RID: 30793
		public unsafe byte* tileTypeBHeader;

		// Token: 0x0400784A RID: 30794
		public unsafe byte* tileTypeBHeader3;

		// Token: 0x0400784B RID: 30795
		public unsafe ushort* tileTypeWall;

		// Token: 0x0400784C RID: 30796
		public unsafe short* tileTypeFrameX;

		// Token: 0x0400784D RID: 30797
		public unsafe short* tileTypeFrameY;

		// Token: 0x0400784E RID: 30798
		public int lightMinX;

		// Token: 0x0400784F RID: 30799
		public int lightMinY;

		// Token: 0x04007850 RID: 30800
		public int lightMaxX;

		// Token: 0x04007851 RID: 30801
		public int lightMaxY;

		// Token: 0x04007852 RID: 30802
		public unsafe Vector3* lightColors;

		// Token: 0x04007853 RID: 30803
		public int lightMapHeight;

		// Token: 0x04007854 RID: 30804
		public float lightGlobal255;

		// Token: 0x04007855 RID: 30805
		public EffectPass drawEffect;

		// Token: 0x04007856 RID: 30806
		public Texture2D drawTexture;

		// Token: 0x04007857 RID: 30807
		public Color tileLight;

		// Token: 0x04007858 RID: 30808
		public int tileTop;

		// Token: 0x04007859 RID: 30809
		public int tileWidth;

		// Token: 0x0400785A RID: 30810
		public int tileHeight;

		// Token: 0x0400785B RID: 30811
		public int halfBrickHeight;

		// Token: 0x0400785C RID: 30812
		public int addFrY;

		// Token: 0x0400785D RID: 30813
		public int addFrX;

		// Token: 0x0400785E RID: 30814
		public SpriteEffects tileSpriteEffect;

		// Token: 0x0400785F RID: 30815
		public Texture2D glowTexture;

		// Token: 0x04007860 RID: 30816
		public Rectangle glowSourceRect;

		// Token: 0x04007861 RID: 30817
		public Color glowColor;

		// Token: 0x04007862 RID: 30818
		public Vector3[] colorSlices;

		// Token: 0x04007863 RID: 30819
		public Color finalColor;

		// Token: 0x04007864 RID: 30820
		public UnifiedRandom _rand;

		// Token: 0x04007865 RID: 30821
		public Dictionary<Point, int> _displayDollTileEntityPositions;

		// Token: 0x04007866 RID: 30822
		public Dictionary<Point, int> _hatRackTileEntityPositions;

		// Token: 0x04007867 RID: 30823
		public Dictionary<Point, int> _trainingDummyTileEntityPositions;

		// Token: 0x04007868 RID: 30824
		public Dictionary<Point, int> _itemFrameTileEntityPositions;

		// Token: 0x04007869 RID: 30825
		public Dictionary<Point, int> _foodPlatterTileEntityPositions;

		// Token: 0x0400786A RID: 30826
		public Dictionary<Point, int> _weaponRackTileEntityPositions;

		// Token: 0x0400786B RID: 30827
		public Dictionary<Point, int> _chestPositions;

		// Token: 0x0400786C RID: 30828
		public VertexColors tileColors;
	}
}
