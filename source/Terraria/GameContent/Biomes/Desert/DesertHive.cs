using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000901 RID: 2305
	public static class DesertHive
	{
		// Token: 0x0600466C RID: 18028 RVA: 0x0025946C File Offset: 0x0025766C
		public static void Place(DesertDescription description)
		{
			DesertHive.ClusterGroup clusterGroup = DesertHive.ClusterGroup.FromDescription(description);
			DesertHive.PlaceClusters(description, clusterGroup);
			DesertHive.AddTileVariance(description);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00259490 File Offset: 0x00257690
		private static void PlaceClusters(DesertDescription description, DesertHive.ClusterGroup clusters)
		{
			int x = description.<Hive>k__BackingField.X;
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x002594B8 File Offset: 0x002576B8
		private static void PlaceClustersArea(DesertDescription description, DesertHive.ClusterGroup clusters, Rectangle area, DesertHive.PostPlacementEffect[,] postEffectMap, Point postEffectMapOffset)
		{
			if (!true)
			{
			}
			int width = clusters.Width;
			Vector2D[] points = clusters.Points;
			if (width == 0)
			{
			}
			Vector2D[] points2 = clusters.Points;
			DesertHive.Cluster[] clusters2 = clusters.Clusters;
			if (points2 != null)
			{
				return;
			}
			Tile tile;
			byte liquid = tile.liquid;
			int num = 397;
			int value = num.m_value;
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x002595F8 File Offset: 0x002577F8
		private static void AddTileVariance(DesertDescription description)
		{
			int width = description.<Hive>k__BackingField.Width;
			Rectangle <Hive>k__BackingField = description.<Hive>k__BackingField;
			int width2 = description.<Hive>k__BackingField.Width;
			if (<Hive>k__BackingField == null)
			{
			}
			Tile tile;
			ushort type = tile.type;
			int width3 = description.<Hive>k__BackingField.Width;
			Rectangle <Hive>k__BackingField2 = description.<Hive>k__BackingField;
			int width4 = description.<Hive>k__BackingField.Width;
			if (<Hive>k__BackingField2 == null)
			{
			}
			Tile tile2;
			bool flag = tile2.active();
			if (<Hive>k__BackingField2 == null)
			{
			}
			Tile tile3;
			bool flag2 = tile3.active();
		}

		// Token: 0x02000902 RID: 2306
		private struct Block
		{
			// Token: 0x06004670 RID: 18032 RVA: 0x0025975C File Offset: 0x0025795C
			public Block(double x, double y)
			{
				this.Position = x;
			}

			// Token: 0x0400827F RID: 33407
			public Vector2D Position;
		}

		// Token: 0x02000903 RID: 2307
		private struct Cluster
		{
			// Token: 0x04008280 RID: 33408
			public int Offset;

			// Token: 0x04008281 RID: 33409
			public int Count;
		}

		// Token: 0x02000904 RID: 2308
		private class ClusterGroup
		{
			// Token: 0x06004671 RID: 18033 RVA: 0x00259770 File Offset: 0x00257970
			private ClusterGroup(int width, int height)
			{
				this.Width = width;
				this.Points = height;
				this.Generate();
			}

			// Token: 0x06004672 RID: 18034 RVA: 0x000021DB File Offset: 0x000003DB
			public static DesertHive.ClusterGroup FromDescription(DesertDescription description)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004673 RID: 18035 RVA: 0x000021DB File Offset: 0x000003DB
			private static void SearchForCluster(bool[,] blockMap, List<Point> pointCluster, int x, int y, int level = 2)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004674 RID: 18036 RVA: 0x00259798 File Offset: 0x00257998
			private static void AttemptClaim(int x, int y, int[,] clusterIndexMap, List<List<Point>> pointClusters, int index)
			{
				UnifiedRandom genRand = WorldGen.genRand;
				int num = 2;
				int num2 = genRand.Next(num);
			}

			// Token: 0x06004675 RID: 18037 RVA: 0x002597CC File Offset: 0x002579CC
			private void Generate()
			{
				int width = this.Width;
				int width2 = this.Width;
				if (this.Points == null)
				{
				}
				int num = Math.Min(43134976, 43134976);
				if (width2 == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 2;
				int num3 = genRand.Next(num2);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num4 = 2;
				if (genRand2.Next(num4) == 0)
				{
					return;
				}
			}

			// Token: 0x04008282 RID: 33410
			public readonly int Width;

			// Token: 0x04008283 RID: 33411
			public readonly int Height;

			// Token: 0x04008284 RID: 33412
			public Vector2D[] Points;

			// Token: 0x04008285 RID: 33413
			public DesertHive.Cluster[] Clusters;
		}

		// Token: 0x02000905 RID: 2309
		[Flags]
		private enum PostPlacementEffect : byte
		{
			// Token: 0x04008287 RID: 33415
			None = 0,
			// Token: 0x04008288 RID: 33416
			Smooth = 1
		}
	}
}
