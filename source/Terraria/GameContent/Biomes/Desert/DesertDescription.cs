using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000900 RID: 2304
	public class DesertDescription
	{
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06004657 RID: 18007 RVA: 0x00259200 File Offset: 0x00257400
		// (set) Token: 0x06004658 RID: 18008 RVA: 0x00259224 File Offset: 0x00257424
		public Rectangle CombinedArea
		{
			[CompilerGenerated]
			get
			{
				Rectangle rectangle = this.<CombinedArea>k__BackingField;
				int width = this.<CombinedArea>k__BackingField.Width;
				return rectangle;
			}
			[CompilerGenerated]
			private set
			{
				this.<CombinedArea>k__BackingField = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x00259238 File Offset: 0x00257438
		// (set) Token: 0x0600465A RID: 18010 RVA: 0x0025925C File Offset: 0x0025745C
		public Rectangle Desert
		{
			[CompilerGenerated]
			get
			{
				Rectangle rectangle = this.<Desert>k__BackingField;
				int width = this.<Desert>k__BackingField.Width;
				return rectangle;
			}
			[CompilerGenerated]
			private set
			{
				this.<Desert>k__BackingField = value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600465B RID: 18011 RVA: 0x00259270 File Offset: 0x00257470
		// (set) Token: 0x0600465C RID: 18012 RVA: 0x00259294 File Offset: 0x00257494
		public Rectangle Hive
		{
			[CompilerGenerated]
			get
			{
				Rectangle rectangle = this.<Hive>k__BackingField;
				int width = this.<Hive>k__BackingField.Width;
				return rectangle;
			}
			[CompilerGenerated]
			private set
			{
				this.<Hive>k__BackingField = value;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x002592A8 File Offset: 0x002574A8
		// (set) Token: 0x0600465E RID: 18014 RVA: 0x002592C4 File Offset: 0x002574C4
		public Vector2D BlockScale
		{
			[CompilerGenerated]
			get
			{
				double x = this.<BlockScale>k__BackingField.X;
				Vector2D vector2D;
				return vector2D;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x002592D4 File Offset: 0x002574D4
		// (set) Token: 0x06004660 RID: 18016 RVA: 0x002592E8 File Offset: 0x002574E8
		public int BlockColumnCount
		{
			[CompilerGenerated]
			get
			{
				return this.<BlockColumnCount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<BlockColumnCount>k__BackingField = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06004661 RID: 18017 RVA: 0x002592FC File Offset: 0x002574FC
		// (set) Token: 0x06004662 RID: 18018 RVA: 0x00259310 File Offset: 0x00257510
		public int BlockRowCount
		{
			[CompilerGenerated]
			get
			{
				return this.<BlockRowCount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<BlockRowCount>k__BackingField = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x00259324 File Offset: 0x00257524
		// (set) Token: 0x06004664 RID: 18020 RVA: 0x00259338 File Offset: 0x00257538
		public bool IsValid
		{
			[CompilerGenerated]
			get
			{
				return this.<IsValid>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x00259348 File Offset: 0x00257548
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x0025935C File Offset: 0x0025755C
		public SurfaceMap Surface
		{
			[CompilerGenerated]
			get
			{
				return this.<Surface>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Surface>k__BackingField = value;
			}
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00259370 File Offset: 0x00257570
		private DesertDescription()
		{
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00259384 File Offset: 0x00257584
		public void UpdateSurfaceMap()
		{
			Rectangle rectangle = this.<CombinedArea>k__BackingField;
			int width = this.<CombinedArea>k__BackingField.Width;
			SurfaceMap surfaceMap;
			this.<Surface>k__BackingField = surfaceMap;
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x002593AC File Offset: 0x002575AC
		public static DesertDescription CreateFromPlacement(Point origin)
		{
			if (!true)
			{
			}
			int num = 32768;
			double num2 = WorldGen.genRand.NextDouble();
			long num3 = 32752L;
			SurfaceMap surfaceMap;
			int bottom = surfaceMap.Bottom;
			if (num3 == 0L)
			{
			}
			bool flag = DesertDescription.RowHasInvalidTiles(42170752, bottom, num);
			if (num3 == 0L)
			{
			}
			return 42170752;
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x0025943C File Offset: 0x0025763C
		private static bool RowHasInvalidTiles(int startX, int startY, int width)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				Tile tile;
				ushort type = tile.type;
				return;
			}
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x0025945C File Offset: 0x0025765C
		// Note: this type is marked as 'beforefieldinit'.
		static DesertDescription()
		{
		}

		// Token: 0x04008274 RID: 33396
		public static readonly DesertDescription Invalid;

		// Token: 0x04008275 RID: 33397
		private static readonly Vector2D DefaultBlockScale;

		// Token: 0x04008276 RID: 33398
		private const int SCAN_PADDING = 5;

		// Token: 0x04008277 RID: 33399
		[CompilerGenerated]
		private Rectangle <CombinedArea>k__BackingField;

		// Token: 0x04008278 RID: 33400
		[CompilerGenerated]
		private Rectangle <Desert>k__BackingField;

		// Token: 0x04008279 RID: 33401
		[CompilerGenerated]
		private Rectangle <Hive>k__BackingField;

		// Token: 0x0400827A RID: 33402
		[CompilerGenerated]
		private Vector2D <BlockScale>k__BackingField;

		// Token: 0x0400827B RID: 33403
		[CompilerGenerated]
		private int <BlockColumnCount>k__BackingField;

		// Token: 0x0400827C RID: 33404
		[CompilerGenerated]
		private int <BlockRowCount>k__BackingField;

		// Token: 0x0400827D RID: 33405
		[CompilerGenerated]
		private bool <IsValid>k__BackingField;

		// Token: 0x0400827E RID: 33406
		[CompilerGenerated]
		private SurfaceMap <Surface>k__BackingField;
	}
}
