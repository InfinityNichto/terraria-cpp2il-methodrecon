using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000908 RID: 2312
	public static class SandMound
	{
		// Token: 0x0600467C RID: 18044 RVA: 0x00259BC0 File Offset: 0x00257DC0
		public static void Place(DesertDescription description)
		{
			if (!true)
			{
			}
			Rectangle <Desert>k__BackingField = description.<Desert>k__BackingField;
			int width = description.<Desert>k__BackingField.Width;
			int height = description.<Hive>k__BackingField.Height;
			if (<Desert>k__BackingField == null)
			{
			}
			int x = description.<Desert>k__BackingField.X;
			int x2 = description.<Desert>k__BackingField.X;
			long num = 0L;
			int num2 = Math.Max(0, (int)num);
			SurfaceMap <Surface>k__BackingField = description.<Surface>k__BackingField;
			UnifiedRandom genRand = WorldGen.genRand;
			int num3 = 2;
			int num4 = genRand.Next((int)num, num3);
			if (<Desert>k__BackingField == null)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 2;
			int num6 = genRand2.Next((int)num, num5);
			if (<Desert>k__BackingField == null)
			{
			}
			if (<Desert>k__BackingField == null)
			{
			}
			double num7 = Utils.UnclampedSmoothStep((double)x2, 0.8, (double)x2);
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x00259C80 File Offset: 0x00257E80
		[CompilerGenerated]
		internal unsafe static void <Place>g__PlaceSandColumn|0_0(int startX, int startY, int height, SandMound.<>c__DisplayClass0_0 cpp2il__autoParamName__idx_3)
		{
			int num;
			do
			{
				num = 1;
				if (num == 0)
				{
				}
			}
			while (num != 0);
			if (cpp2il__autoParamName__idx_3.TileData_TileLiquid == null)
			{
			}
			uint* tileData_TileLookup = cpp2il__autoParamName__idx_3.TileData_TileLookup;
			short* tileData_TileSHeader = cpp2il__autoParamName__idx_3.TileData_TileSHeader;
			if (tileData_TileLookup == null)
			{
			}
			int num2 = 1;
			WorldGen.SquareWallFrame(startX, height, num2 != 0);
		}

		// Token: 0x02000909 RID: 2313
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <>c__DisplayClass0_0
		{
			// Token: 0x04008289 RID: 33417
			public int Main_maxTilesX;

			// Token: 0x0400828A RID: 33418
			public unsafe byte* TileData_TileLiquid;

			// Token: 0x0400828B RID: 33419
			public unsafe uint* TileData_TileLookup;

			// Token: 0x0400828C RID: 33420
			public unsafe short* TileData_TileSHeader;
		}
	}
}
