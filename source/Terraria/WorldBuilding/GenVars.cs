using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.DataStructures;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004E3 RID: 1251
	public static class GenVars
	{
		// Token: 0x06003058 RID: 12376 RVA: 0x001F6140 File Offset: 0x001F4340
		// Note: this type is marked as 'beforefieldinit'.
		static GenVars()
		{
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x040039E9 RID: 14825
		public static WorldGenConfiguration configuration;

		// Token: 0x040039EA RID: 14826
		public static StructureMap structures;

		// Token: 0x040039EB RID: 14827
		public static int copper;

		// Token: 0x040039EC RID: 14828
		public static int iron;

		// Token: 0x040039ED RID: 14829
		public static int silver;

		// Token: 0x040039EE RID: 14830
		public static int gold;

		// Token: 0x040039EF RID: 14831
		public static int copperBar;

		// Token: 0x040039F0 RID: 14832
		public static int ironBar;

		// Token: 0x040039F1 RID: 14833
		public static int silverBar;

		// Token: 0x040039F2 RID: 14834
		public static int goldBar;

		// Token: 0x040039F3 RID: 14835
		public static ushort mossTile;

		// Token: 0x040039F4 RID: 14836
		public static ushort mossWall;

		// Token: 0x040039F5 RID: 14837
		public static int lavaLine;

		// Token: 0x040039F6 RID: 14838
		public static int waterLine;

		// Token: 0x040039F7 RID: 14839
		public static double worldSurfaceLow;

		// Token: 0x040039F8 RID: 14840
		public static double worldSurface;

		// Token: 0x040039F9 RID: 14841
		public static double worldSurfaceHigh;

		// Token: 0x040039FA RID: 14842
		public static double rockLayerLow;

		// Token: 0x040039FB RID: 14843
		public static double rockLayer;

		// Token: 0x040039FC RID: 14844
		public static double rockLayerHigh;

		// Token: 0x040039FD RID: 14845
		public static int snowTop;

		// Token: 0x040039FE RID: 14846
		public static int snowBottom;

		// Token: 0x040039FF RID: 14847
		public static int snowOriginLeft;

		// Token: 0x04003A00 RID: 14848
		public static int snowOriginRight;

		// Token: 0x04003A01 RID: 14849
		public static int[] snowMinX;

		// Token: 0x04003A02 RID: 14850
		public static int[] snowMaxX;

		// Token: 0x04003A03 RID: 14851
		public static int leftBeachEnd;

		// Token: 0x04003A04 RID: 14852
		public static int rightBeachStart;

		// Token: 0x04003A05 RID: 14853
		public static int beachBordersWidth;

		// Token: 0x04003A06 RID: 14854
		public static int beachSandRandomCenter;

		// Token: 0x04003A07 RID: 14855
		public static int beachSandRandomWidthRange;

		// Token: 0x04003A08 RID: 14856
		public static int beachSandDungeonExtraWidth;

		// Token: 0x04003A09 RID: 14857
		public static int beachSandJungleExtraWidth;

		// Token: 0x04003A0A RID: 14858
		public static int shellStartXLeft;

		// Token: 0x04003A0B RID: 14859
		public static int shellStartYLeft;

		// Token: 0x04003A0C RID: 14860
		public static int shellStartXRight;

		// Token: 0x04003A0D RID: 14861
		public static int shellStartYRight;

		// Token: 0x04003A0E RID: 14862
		public static int oceanWaterStartRandomMin;

		// Token: 0x04003A0F RID: 14863
		public static int oceanWaterStartRandomMax;

		// Token: 0x04003A10 RID: 14864
		public static int oceanWaterForcedJungleLength;

		// Token: 0x04003A11 RID: 14865
		public static int evilBiomeBeachAvoidance;

		// Token: 0x04003A12 RID: 14866
		public static int evilBiomeAvoidanceMidFixer;

		// Token: 0x04003A13 RID: 14867
		public static int lakesBeachAvoidance;

		// Token: 0x04003A14 RID: 14868
		public static int smallHolesBeachAvoidance;

		// Token: 0x04003A15 RID: 14869
		public static int surfaceCavesBeachAvoidance;

		// Token: 0x04003A16 RID: 14870
		public static int surfaceCavesBeachAvoidance2;

		// Token: 0x04003A17 RID: 14871
		public static readonly int maxOceanCaveTreasure;

		// Token: 0x04003A18 RID: 14872
		public static int numOceanCaveTreasure;

		// Token: 0x04003A19 RID: 14873
		public static Point[] oceanCaveTreasure;

		// Token: 0x04003A1A RID: 14874
		public static bool skipDesertTileCheck;

		// Token: 0x04003A1B RID: 14875
		public static Rectangle UndergroundDesertLocation;

		// Token: 0x04003A1C RID: 14876
		public static Rectangle UndergroundDesertHiveLocation;

		// Token: 0x04003A1D RID: 14877
		public static int desertHiveHigh;

		// Token: 0x04003A1E RID: 14878
		public static int desertHiveLow;

		// Token: 0x04003A1F RID: 14879
		public static int desertHiveLeft;

		// Token: 0x04003A20 RID: 14880
		public static int desertHiveRight;

		// Token: 0x04003A21 RID: 14881
		public static int numLarva;

		// Token: 0x04003A22 RID: 14882
		public static int[] larvaY;

		// Token: 0x04003A23 RID: 14883
		public static int[] larvaX;

		// Token: 0x04003A24 RID: 14884
		public static int numPyr;

		// Token: 0x04003A25 RID: 14885
		public static int[] PyrX;

		// Token: 0x04003A26 RID: 14886
		public static int[] PyrY;

		// Token: 0x04003A27 RID: 14887
		public static int extraBastStatueCount;

		// Token: 0x04003A28 RID: 14888
		public static int extraBastStatueCountMax;

		// Token: 0x04003A29 RID: 14889
		public static int jungleOriginX;

		// Token: 0x04003A2A RID: 14890
		public static int jungleMinX;

		// Token: 0x04003A2B RID: 14891
		public static int jungleMaxX;

		// Token: 0x04003A2C RID: 14892
		public static int JungleX;

		// Token: 0x04003A2D RID: 14893
		public static ushort jungleHut;

		// Token: 0x04003A2E RID: 14894
		public static bool mudWall;

		// Token: 0x04003A2F RID: 14895
		public static int JungleItemCount;

		// Token: 0x04003A30 RID: 14896
		public static int[] JChestX;

		// Token: 0x04003A31 RID: 14897
		public static int[] JChestY;

		// Token: 0x04003A32 RID: 14898
		public static int numJChests;

		// Token: 0x04003A33 RID: 14899
		public static int tLeft;

		// Token: 0x04003A34 RID: 14900
		public static int tRight;

		// Token: 0x04003A35 RID: 14901
		public static int tTop;

		// Token: 0x04003A36 RID: 14902
		public static int tBottom;

		// Token: 0x04003A37 RID: 14903
		public static int tRooms;

		// Token: 0x04003A38 RID: 14904
		public static int lAltarX;

		// Token: 0x04003A39 RID: 14905
		public static int lAltarY;

		// Token: 0x04003A3A RID: 14906
		public static int dungeonSide;

		// Token: 0x04003A3B RID: 14907
		public static int dungeonLocation;

		// Token: 0x04003A3C RID: 14908
		public static bool dungeonLake;

		// Token: 0x04003A3D RID: 14909
		public static ushort crackedType;

		// Token: 0x04003A3E RID: 14910
		public static int dungeonX;

		// Token: 0x04003A3F RID: 14911
		public static int dungeonY;

		// Token: 0x04003A40 RID: 14912
		public static Vector2D lastDungeonHall;

		// Token: 0x04003A41 RID: 14913
		public static readonly int maxDRooms;

		// Token: 0x04003A42 RID: 14914
		public static int numDRooms;

		// Token: 0x04003A43 RID: 14915
		public static int[] dRoomX;

		// Token: 0x04003A44 RID: 14916
		public static int[] dRoomY;

		// Token: 0x04003A45 RID: 14917
		public static int[] dRoomSize;

		// Token: 0x04003A46 RID: 14918
		public static bool[] dRoomTreasure;

		// Token: 0x04003A47 RID: 14919
		public static int[] dRoomL;

		// Token: 0x04003A48 RID: 14920
		public static int[] dRoomR;

		// Token: 0x04003A49 RID: 14921
		public static int[] dRoomT;

		// Token: 0x04003A4A RID: 14922
		public static int[] dRoomB;

		// Token: 0x04003A4B RID: 14923
		public static int numDDoors;

		// Token: 0x04003A4C RID: 14924
		public static int[] DDoorX;

		// Token: 0x04003A4D RID: 14925
		public static int[] DDoorY;

		// Token: 0x04003A4E RID: 14926
		public static int[] DDoorPos;

		// Token: 0x04003A4F RID: 14927
		public static int numDungeonPlatforms;

		// Token: 0x04003A50 RID: 14928
		public static int[] dungeonPlatformX;

		// Token: 0x04003A51 RID: 14929
		public static int[] dungeonPlatformY;

		// Token: 0x04003A52 RID: 14930
		public static int dEnteranceX;

		// Token: 0x04003A53 RID: 14931
		public static bool dSurface;

		// Token: 0x04003A54 RID: 14932
		public static double dxStrength1;

		// Token: 0x04003A55 RID: 14933
		public static double dyStrength1;

		// Token: 0x04003A56 RID: 14934
		public static double dxStrength2;

		// Token: 0x04003A57 RID: 14935
		public static double dyStrength2;

		// Token: 0x04003A58 RID: 14936
		public static int dMinX;

		// Token: 0x04003A59 RID: 14937
		public static int dMaxX;

		// Token: 0x04003A5A RID: 14938
		public static int dMinY;

		// Token: 0x04003A5B RID: 14939
		public static int dMaxY;

		// Token: 0x04003A5C RID: 14940
		public static int skyLakes;

		// Token: 0x04003A5D RID: 14941
		public static bool generatedShadowKey;

		// Token: 0x04003A5E RID: 14942
		public static int numIslandHouses;

		// Token: 0x04003A5F RID: 14943
		public static int skyIslandHouseCount;

		// Token: 0x04003A60 RID: 14944
		public static bool[] skyLake;

		// Token: 0x04003A61 RID: 14945
		public static int[] floatingIslandHouseX;

		// Token: 0x04003A62 RID: 14946
		public static int[] floatingIslandHouseY;

		// Token: 0x04003A63 RID: 14947
		public static int[] floatingIslandStyle;

		// Token: 0x04003A64 RID: 14948
		public static int numMCaves;

		// Token: 0x04003A65 RID: 14949
		public static int[] mCaveX;

		// Token: 0x04003A66 RID: 14950
		public static int[] mCaveY;

		// Token: 0x04003A67 RID: 14951
		public static readonly int maxTunnels;

		// Token: 0x04003A68 RID: 14952
		public static int numTunnels;

		// Token: 0x04003A69 RID: 14953
		public static int[] tunnelX;

		// Token: 0x04003A6A RID: 14954
		public static readonly int maxOrePatch;

		// Token: 0x04003A6B RID: 14955
		public static int numOrePatch;

		// Token: 0x04003A6C RID: 14956
		public static int[] orePatchX;

		// Token: 0x04003A6D RID: 14957
		public static readonly int maxMushroomBiomes;

		// Token: 0x04003A6E RID: 14958
		public static int numMushroomBiomes;

		// Token: 0x04003A6F RID: 14959
		public static Point[] mushroomBiomesPosition;

		// Token: 0x04003A70 RID: 14960
		public static int logX;

		// Token: 0x04003A71 RID: 14961
		public static int logY;

		// Token: 0x04003A72 RID: 14962
		public static readonly int maxLakes;

		// Token: 0x04003A73 RID: 14963
		public static int numLakes;

		// Token: 0x04003A74 RID: 14964
		public static int[] LakeX;

		// Token: 0x04003A75 RID: 14965
		public static readonly int maxOasis;

		// Token: 0x04003A76 RID: 14966
		public static int numOasis;

		// Token: 0x04003A77 RID: 14967
		public static Point[] oasisPosition;

		// Token: 0x04003A78 RID: 14968
		public static int[] oasisWidth;

		// Token: 0x04003A79 RID: 14969
		public static readonly int oasisHeight;

		// Token: 0x04003A7A RID: 14970
		public static int hellChest;

		// Token: 0x04003A7B RID: 14971
		public static int[] hellChestItem;

		// Token: 0x04003A7C RID: 14972
		public static Point16[] statueList;

		// Token: 0x04003A7D RID: 14973
		public static List<int> StatuesWithTraps;

		// Token: 0x04003A7E RID: 14974
		public static bool crimsonLeft;

		// Token: 0x04003A7F RID: 14975
		public static Vector2D shimmerPosition;
	}
}
