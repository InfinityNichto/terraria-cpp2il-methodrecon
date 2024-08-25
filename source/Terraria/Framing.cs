using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x02000431 RID: 1073
	public class Framing
	{
		// Token: 0x06002812 RID: 10258 RVA: 0x0018F670 File Offset: 0x0018D870
		public static void Initialize()
		{
			int num = 9;
			int num2 = 3;
			int num3 = 10;
			int num4 = 3;
			int num5 = 11;
			int num6 = 3;
			Framing.Add8WayLookup(0, (short)num, (short)num2, (short)num3, (short)num4, (short)num5, (short)num6);
			int num7 = 1;
			int num8 = 6;
			int num9 = 3;
			int num10 = 7;
			int num11 = 3;
			int num12 = 8;
			int num13 = 3;
			Framing.Add8WayLookup(num7, (short)num8, (short)num9, (short)num10, (short)num11, (short)num12, (short)num13);
			int num14 = 2;
			int num15 = 12;
			int num16 = 12;
			int num17 = 1;
			int num18 = 12;
			int num19 = 2;
			long num20 = 0L;
			Framing.Add8WayLookup(num14, (short)num15, (short)num20, (short)num16, (short)num17, (short)num18, (short)num19);
			int num21 = 3;
			int num22 = 15;
			int num23 = 2;
			Framing.Add8WayLookup(num21, (short)num22, (short)num23);
			int num24 = 4;
			int num25 = 9;
			int num26 = 9;
			int num27 = 1;
			int num28 = 9;
			int num29 = 2;
			long num30 = 0L;
			Framing.Add8WayLookup(num24, (short)num25, (short)num30, (short)num26, (short)num27, (short)num28, (short)num29);
			int num31 = 5;
			int num32 = 13;
			int num33 = 2;
			Framing.Add8WayLookup(num31, (short)num32, (short)num33);
			int num34 = 6;
			int num35 = 6;
			int num36 = 4;
			int num37 = 7;
			int num38 = 4;
			int num39 = 8;
			int num40 = 4;
			Framing.Add8WayLookup(num34, (short)num35, (short)num36, (short)num37, (short)num38, (short)num39, (short)num40);
			int num41 = 7;
			int num42 = 14;
			int num43 = 2;
			Framing.Add8WayLookup(num41, (short)num42, (short)num43);
			int num44 = 8;
			int num45 = 6;
			int num46 = 7;
			int num47 = 8;
			long num48 = 0L;
			long num49 = 0L;
			long num50 = 0L;
			Framing.Add8WayLookup(num44, (short)num45, (short)num48, (short)num46, (short)num49, (short)num47, (short)num50);
			int num51 = 9;
			int num52 = 5;
			int num53 = 5;
			int num54 = 1;
			int num55 = 5;
			int num56 = 2;
			long num57 = 0L;
			Framing.Add8WayLookup(num51, (short)num52, (short)num57, (short)num53, (short)num54, (short)num55, (short)num56);
			int num58 = 10;
			int num59 = 15;
			long num60 = 0L;
			Framing.Add8WayLookup(num58, (short)num59, (short)num60);
			int num61 = 11;
			int num62 = 15;
			int num63 = 1;
			Framing.Add8WayLookup(num61, (short)num62, (short)num63);
			int num64 = 12;
			int num65 = 13;
			long num66 = 0L;
			Framing.Add8WayLookup(num64, (short)num65, (short)num66);
			int num67 = 13;
			int num68 = 13;
			int num69 = 1;
			Framing.Add8WayLookup(num67, (short)num68, (short)num69);
			int num70 = 14;
			int num71 = 14;
			long num72 = 0L;
			Framing.Add8WayLookup(num70, (short)num71, (short)num72);
			int num73 = 15;
			int num74 = 14;
			int num75 = 1;
			Framing.Add8WayLookup(num73, (short)num74, (short)num75);
			int num76 = 19;
			int num77 = 1;
			int num78 = 4;
			int num79 = 3;
			int num80 = 4;
			int num81 = 5;
			int num82 = 4;
			Framing.Add8WayLookup(num76, (short)num77, (short)num78, (short)num79, (short)num80, (short)num81, (short)num82);
			int num83 = 23;
			int num84 = 16;
			int num85 = 3;
			Framing.Add8WayLookup(num83, (short)num84, (short)num85);
			int num86 = 27;
			int num87 = 17;
			long num88 = 0L;
			Framing.Add8WayLookup(num86, (short)num87, (short)num88);
			int num89 = 31;
			int num90 = 13;
			int num91 = 4;
			Framing.Add8WayLookup(num89, (short)num90, (short)num91);
			int num92 = 37;
			int num93 = 4;
			int num94 = 2;
			int num95 = 4;
			int num96 = 4;
			int num97 = 4;
			long num98 = 0L;
			Framing.Add8WayLookup(num92, (short)num98, (short)num93, (short)num94, (short)num95, (short)num96, (short)num97);
			int num99 = 39;
			int num100 = 17;
			int num101 = 3;
			Framing.Add8WayLookup(num99, (short)num100, (short)num101);
			int num102 = 45;
			int num103 = 16;
			long num104 = 0L;
			Framing.Add8WayLookup(num102, (short)num103, (short)num104);
			int num105 = 47;
			int num106 = 12;
			int num107 = 4;
			Framing.Add8WayLookup(num105, (short)num106, (short)num107);
			int num108 = 55;
			int num109 = 1;
			int num110 = 2;
			int num111 = 2;
			int num112 = 2;
			int num113 = 3;
			int num114 = 2;
			Framing.Add8WayLookup(num108, (short)num109, (short)num110, (short)num111, (short)num112, (short)num113, (short)num114);
			int num115 = 63;
			int num116 = 6;
			int num117 = 2;
			int num118 = 7;
			int num119 = 2;
			int num120 = 8;
			int num121 = 2;
			Framing.Add8WayLookup(num115, (short)num116, (short)num117, (short)num118, (short)num119, (short)num120, (short)num121);
			int num122 = 74;
			int num123 = 1;
			int num124 = 3;
			int num125 = 3;
			int num126 = 3;
			int num127 = 5;
			int num128 = 3;
			Framing.Add8WayLookup(num122, (short)num123, (short)num124, (short)num125, (short)num126, (short)num127, (short)num128);
			int num129 = 75;
			int num130 = 17;
			int num131 = 1;
			Framing.Add8WayLookup(num129, (short)num130, (short)num131);
			int num132 = 78;
			int num133 = 16;
			int num134 = 2;
			Framing.Add8WayLookup(num132, (short)num133, (short)num134);
			int num135 = 79;
			int num136 = 13;
			int num137 = 3;
			Framing.Add8WayLookup(num135, (short)num136, (short)num137);
			int num138 = 91;
			int num139 = 4;
			int num140 = 4;
			int num141 = 1;
			int num142 = 4;
			int num143 = 2;
			long num144 = 0L;
			Framing.Add8WayLookup(num138, (short)num139, (short)num144, (short)num140, (short)num141, (short)num142, (short)num143);
			int num145 = 95;
			int num146 = 11;
			int num147 = 11;
			int num148 = 1;
			int num149 = 11;
			int num150 = 2;
			long num151 = 0L;
			Framing.Add8WayLookup(num145, (short)num146, (short)num151, (short)num147, (short)num148, (short)num149, (short)num150);
			int num152 = 111;
			int num153 = 17;
			int num154 = 4;
			Framing.Add8WayLookup(num152, (short)num153, (short)num154);
			int num155 = 127;
			int num156 = 14;
			int num157 = 3;
			Framing.Add8WayLookup(num155, (short)num156, (short)num157);
			int num158 = 140;
			int num159 = 3;
			int num160 = 2;
			int num161 = 3;
			int num162 = 4;
			int num163 = 3;
			long num164 = 0L;
			Framing.Add8WayLookup(num158, (short)num164, (short)num159, (short)num160, (short)num161, (short)num162, (short)num163);
			int num165 = 141;
			int num166 = 16;
			int num167 = 1;
			Framing.Add8WayLookup(num165, (short)num166, (short)num167);
			int num168 = 142;
			int num169 = 17;
			int num170 = 2;
			Framing.Add8WayLookup(num168, (short)num169, (short)num170);
			int num171 = 143;
			int num172 = 12;
			int num173 = 3;
			Framing.Add8WayLookup(num171, (short)num172, (short)num173);
			int num174 = 159;
			int num175 = 16;
			int num176 = 4;
			Framing.Add8WayLookup(num174, (short)num175, (short)num176);
			int num177 = 173;
			int num178 = 1;
			int num179 = 2;
			long num180 = 0L;
			long num181 = 0L;
			long num182 = 0L;
			long num183 = 0L;
			Framing.Add8WayLookup(num177, (short)num180, (short)num181, (short)num182, (short)num178, (short)num183, (short)num179);
			int num184 = 175;
			int num185 = 10;
			int num186 = 10;
			int num187 = 1;
			int num188 = 10;
			int num189 = 2;
			long num190 = 0L;
			Framing.Add8WayLookup(num184, (short)num185, (short)num190, (short)num186, (short)num187, (short)num188, (short)num189);
			int num191 = 191;
			int num192 = 15;
			int num193 = 3;
			Framing.Add8WayLookup(num191, (short)num192, (short)num193);
			int num194 = 206;
			int num195 = 1;
			int num196 = 2;
			int num197 = 3;
			long num198 = 0L;
			long num199 = 0L;
			long num200 = 0L;
			Framing.Add8WayLookup(num194, (short)num195, (short)num198, (short)num196, (short)num199, (short)num197, (short)num200);
			int num201 = 207;
			int num202 = 6;
			int num203 = 1;
			int num204 = 7;
			int num205 = 1;
			int num206 = 8;
			int num207 = 1;
			Framing.Add8WayLookup(num201, (short)num202, (short)num203, (short)num204, (short)num205, (short)num206, (short)num207);
			int num208 = 223;
			int num209 = 14;
			int num210 = 4;
			Framing.Add8WayLookup(num208, (short)num209, (short)num210);
			int num211 = 239;
			int num212 = 15;
			int num213 = 4;
			Framing.Add8WayLookup(num211, (short)num212, (short)num213);
			int num214 = 255;
			int num215 = 1;
			int num216 = 1;
			int num217 = 2;
			int num218 = 1;
			int num219 = 3;
			int num220 = 1;
			Framing.Add8WayLookup(num214, (short)num215, (short)num216, (short)num217, (short)num218, (short)num219, (short)num220);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x000021DB File Offset: 0x000003DB
		private static Framing.BlockStyle FindBlockStyle(Tile blockTile)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0018FCBC File Offset: 0x0018DEBC
		public static void Add8WayLookup(int lookup, short point1X, short point1Y, short point2X, short point2Y, short point3X, short point3Y)
		{
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0018FCD4 File Offset: 0x0018DED4
		public static void Add8WayLookup(int lookup, short x, short y)
		{
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x0018FCEC File Offset: 0x0018DEEC
		public static void AddWallFrameLookup(int lookup, short point1X, short point1Y, short point2X, short point2Y, short point3X, short point3Y, short point4X, short point4Y)
		{
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x0018FD04 File Offset: 0x0018DF04
		private static bool WillItBlend(ushort myType, ushort otherType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x0018FD20 File Offset: 0x0018DF20
		public static void SelfFrame8Way(int i, int j, Tile centerTile, bool resetFrame)
		{
			long num = 0L;
			bool flag = Framing.GetTileSafely(i, (int)num).active();
			ushort num2;
			ushort num3;
			bool flag2 = Framing.WillItBlend(num2, num3);
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0018FE10 File Offset: 0x0018E010
		public static void WallFrame(int i, int j, bool resetFrame = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool skipFramingBecauseOfGen = WorldGen.SkipFramingBecauseOfGen;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			int num3 = 1;
			bool flag = WorldGen.CacheUpdateMapTile(i, j, num3 != 0);
			if (num2 != 0L)
			{
				bool flag2 = Main.ShouldShowInvisibleWalls();
				return;
			}
			TileData.SetBHeader(int.MinValue, (byte)j);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x0018FEC0 File Offset: 0x0018E0C0
		public static Tile GetTileSafely(Vector2 position)
		{
			Tile tile;
			return tile;
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x0018FED0 File Offset: 0x0018E0D0
		public static Tile GetTileSafely(Point pt)
		{
			Tile tile;
			return tile;
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0018FEE0 File Offset: 0x0018E0E0
		public static Tile GetTileSafely(Point16 pt)
		{
			Tile tile;
			return tile;
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0018FEF0 File Offset: 0x0018E0F0
		public static Tile GetTileSafely(int i, int j)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = WorldGen.InWorld(0, i, (int)num);
			if (!true)
			{
			}
			Tile tile;
			return tile;
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x0018FF14 File Offset: 0x0018E114
		public Framing()
		{
		}

		// Token: 0x0400340C RID: 13324
		private static Point16[][] selfFrame8WayLookup;

		// Token: 0x0400340D RID: 13325
		private static Point16[][] wallFrameLookup;

		// Token: 0x0400340E RID: 13326
		private static Point16 frameSize8Way;

		// Token: 0x0400340F RID: 13327
		private static Point16 wallFrameSize;

		// Token: 0x04003410 RID: 13328
		private static Framing.BlockStyle[] blockStyleLookup;

		// Token: 0x04003411 RID: 13329
		private static int[][] phlebasTileFrameNumberLookup;

		// Token: 0x04003412 RID: 13330
		private static int[][] lazureTileFrameNumberLookup;

		// Token: 0x04003413 RID: 13331
		private static int[][] centerWallFrameLookup;

		// Token: 0x02000432 RID: 1074
		private struct BlockStyle
		{
			// Token: 0x0600281F RID: 10271 RVA: 0x0018FF28 File Offset: 0x0018E128
			public BlockStyle(bool up, bool down, bool left, bool right)
			{
			}

			// Token: 0x06002820 RID: 10272 RVA: 0x0018FF38 File Offset: 0x0018E138
			public void Clear()
			{
			}

			// Token: 0x04003414 RID: 13332
			public bool top;

			// Token: 0x04003415 RID: 13333
			public bool bottom;

			// Token: 0x04003416 RID: 13334
			public bool left;

			// Token: 0x04003417 RID: 13335
			public bool right;
		}
	}
}
