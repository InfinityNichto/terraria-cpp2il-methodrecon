using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ObjectData;

namespace Terraria
{
	// Token: 0x02000461 RID: 1121
	public struct TileObject
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000021DB File Offset: 0x000003DB
		public static TileObjectPreviewData objectPreview
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x001B3364 File Offset: 0x001B1564
		public static bool Place(TileObject toBePlaced)
		{
			int num;
			TileObjectData tileObjectData;
			do
			{
				num = 1;
			}
			while (tileObjectData == null);
			PlacementHook hookPlaceOverride = tileObjectData.HookPlaceOverride;
			if (num != 0)
			{
				PlacementHook hookPlaceOverride2 = tileObjectData.HookPlaceOverride;
				Point16 origin = tileObjectData.Origin;
				Point16 origin2 = tileObjectData.Origin;
			}
			int styleWrapLimit = tileObjectData.StyleWrapLimit;
			int styleWrapLimit2 = tileObjectData.StyleWrapLimit;
			int styleLineSkip = tileObjectData.StyleLineSkip;
			int styleWrapLimit3 = tileObjectData.StyleWrapLimit;
			PlacementHook hookPlaceOverride3 = tileObjectData.HookPlaceOverride;
			PlacementHook hookPlaceOverride4 = tileObjectData.HookPlaceOverride;
			bool styleHorizontal = tileObjectData.StyleHorizontal;
			int coordinateFullWidth = tileObjectData.CoordinateFullWidth;
			int coordinateFullHeight = tileObjectData.CoordinateFullHeight;
			int width = tileObjectData.Width;
			int height = tileObjectData.Height;
			int num2;
			short sTileHeader = Framing.GetTileSafely(num2, styleHorizontal ? 1 : 0).sTileHeader;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					goto IL_00C8;
				}
			}
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.KillTile(num2, styleHorizontal ? 1 : 0, num3 != 0L, num4 != 0L, num5 != 0L);
			Tile tile;
			short sTileHeader2 = tile.sTileHeader;
			IL_00C8:
			int height2 = tileObjectData.Height;
			int width2 = tileObjectData.Width;
			int width3 = tileObjectData.Width;
			long num6 = 0L;
			int coordinateWidth = tileObjectData.CoordinateWidth;
			int coordinatePadding = tileObjectData.CoordinatePadding;
			long num7 = 0L;
			int height3 = tileObjectData.Height;
			short sTileHeader3 = Framing.GetTileSafely(coordinatePadding, (int)num7).sTileHeader;
			int[] coordinateHeights = tileObjectData.CoordinateHeights;
			int coordinatePadding2 = tileObjectData.CoordinatePadding;
			int height4 = tileObjectData.Height;
			int width4 = tileObjectData.Width;
			bool flattenAnchors = tileObjectData.FlattenAnchors;
			AnchorData anchorBottom = tileObjectData.AnchorBottom;
			if (num6 != 0L)
			{
				int value = num2.m_value;
				int height5 = tileObjectData.Height;
				int num8;
				if (num8 != 0)
				{
				}
			}
			AnchorData anchorTop = tileObjectData.AnchorTop;
			int value2;
			if (num6 != 0L)
			{
				value2 = num2.m_value;
				if (value2 == 0)
				{
				}
				int num9;
				if (num9 != 0)
				{
				}
			}
			AnchorData anchorRight = tileObjectData.AnchorRight;
			if (num6 != 0L)
			{
				int width5 = tileObjectData.Width;
				if (value2 == 0)
				{
				}
				int num10;
				if (num10 != 0)
				{
				}
			}
			AnchorData anchorLeft = tileObjectData.AnchorLeft;
			int value3 = num2.m_value;
			if (value2 == 0)
			{
			}
			int num11;
			if (num11 != 0)
			{
				return;
			}
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x001B3528 File Offset: 0x001B1728
		public static bool CanPlace(int x, int y, int type, int style, int dir, [Out] TileObject objectData, bool onlyCheck = false, [Optional] int? forcedRandom)
		{
			TileObjectData tileData;
			for (;;)
			{
				long num = 0L;
				tileData = TileObjectData.GetTileData(y, type, (int)num);
				if (tileData != null)
				{
					break;
				}
				if (-2147483648 == 0)
				{
				}
				int[] array;
				if (array != null)
				{
					int num2;
					if (num2 == 0)
					{
					}
					if (-2147483648 == 0)
					{
					}
					int[] array2;
					if (array2 != null)
					{
					}
				}
				TileObjectPreviewData objectPreview = TileObject.objectPreview;
				TileObject.objectPreview._random = 0;
				int[] array3;
				if (array3 != null)
				{
					goto Block_3;
				}
			}
			Point16 origin = tileData.Origin;
			Point16 origin2 = tileData.Origin;
			int width = tileData.Width;
			int num3;
			if (num3 != 0)
			{
			}
			TileObjectData tileData2 = TileObjectData.GetTileData(type, 1073741824, int.MinValue);
			if (tileData2.Direction != TileObjectDirection.None)
			{
				TileObjectDirection direction = tileData2.Direction;
				TileObjectDirection direction2 = tileData2.Direction;
			}
			Point16 origin3 = tileData2.Origin;
			Point16 origin4 = tileData2.Origin;
			int width2 = tileData2.Width;
			int height = tileData2.Height;
			int width3 = tileData2.Width;
			int height2 = tileData2.Height;
			AnchorData anchorTop = tileData2.AnchorTop;
			AnchorData anchorTop2 = tileData2.AnchorTop;
			AnchorData anchorTop3 = tileData2.AnchorTop;
			AnchorData anchorBottom = tileData2.AnchorBottom;
			int height3 = tileData2.Height;
			AnchorData anchorBottom2 = tileData2.AnchorBottom;
			AnchorData anchorBottom3 = tileData2.AnchorBottom;
			AnchorData anchorLeft = tileData2.AnchorLeft;
			AnchorData anchorLeft2 = tileData2.AnchorLeft;
			AnchorData anchorLeft3 = tileData2.AnchorLeft;
			AnchorData anchorLeft4 = tileData2.AnchorLeft;
			AnchorData anchorLeft5 = tileData2.AnchorLeft;
			AnchorData anchorRight = tileData2.AnchorRight;
			int width4 = tileData2.Width;
			long num4 = 0L;
			AnchorData anchorLeft6 = tileData2.AnchorLeft;
			AnchorData anchorRight2 = tileData2.AnchorRight;
			AnchorData anchorRight3 = tileData2.AnchorRight;
			AnchorData anchorRight4 = tileData2.AnchorRight;
			TileObjectPreviewData objectPreview2 = TileObject.objectPreview;
			objectPreview2.Reset();
			TileObjectPreviewData objectPreview3 = TileObject.objectPreview;
			int num5 = 1;
			objectPreview3._active = num5 != 0;
			TileObject.objectPreview._type = (ushort)type;
			TileObject.objectPreview._style = (short)num4;
			TileObject.objectPreview._alternate = int.MinValue;
			TileObjectPreviewData objectPreview4 = TileObject.objectPreview;
			TileObjectPreviewData objectPreview5 = TileObject.objectPreview;
			TileObjectPreviewData objectPreview6 = TileObject.objectPreview;
			int width5 = tileData2.Width;
			int height4 = tileData2.Height;
			int width6 = tileData2.Width;
			int height5 = tileData2.Height;
			long num6 = 0L;
			bool anchorWall = tileData2.AnchorWall;
			return tileData2.isValidWallAnchor((int)num6);
			Block_3:
			if (-2147483648 == 0)
			{
			}
			TileObjectPreviewData objectPreview7 = TileObject.objectPreview;
			return false;
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x001B3B7C File Offset: 0x001B1D7C
		public static void DrawPreview(SpriteBatch sb, TileObjectPreviewData op, Vector2 position)
		{
			if (!true)
			{
			}
			ushort num = op._type;
			int num2 = op._alternate;
			int num3 = op._alternate;
			bool active = op._active;
			TileObjectData tileObjectData;
			int drawYOffset = tileObjectData.DrawYOffset;
			int drawXOffset = tileObjectData.DrawXOffset;
			int drawStyleOffset = tileObjectData.DrawStyleOffset;
			int styleWrapLimit = tileObjectData.StyleWrapLimit;
			int styleLineSkip = tileObjectData.StyleLineSkip;
			int? styleWrapLimitVisualOverride = tileObjectData.StyleWrapLimitVisualOverride;
			int? styleWrapLimitVisualOverride2 = tileObjectData.StyleWrapLimitVisualOverride;
			int? styleLineSkipVisualOverride = tileObjectData.styleLineSkipVisualOverride;
			int? styleLineSkipVisualOverride2 = tileObjectData.styleLineSkipVisualOverride;
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x001B3CAC File Offset: 0x001B1EAC
		// Note: this type is marked as 'beforefieldinit'.
		static TileObject()
		{
		}

		// Token: 0x04003773 RID: 14195
		public int xCoord;

		// Token: 0x04003774 RID: 14196
		public int yCoord;

		// Token: 0x04003775 RID: 14197
		public int type;

		// Token: 0x04003776 RID: 14198
		public int style;

		// Token: 0x04003777 RID: 14199
		public int alternate;

		// Token: 0x04003778 RID: 14200
		public int random;

		// Token: 0x04003779 RID: 14201
		public static TileObject Empty;
	}
}
