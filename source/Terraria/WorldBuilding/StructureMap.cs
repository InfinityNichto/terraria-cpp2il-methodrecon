using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004E7 RID: 1255
	public class StructureMap
	{
		// Token: 0x0600306D RID: 12397 RVA: 0x001F6464 File Offset: 0x001F4664
		public bool CanPlace(Rectangle area, int padding = 0)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x001F6478 File Offset: 0x001F4678
		public bool CanPlace(Rectangle area, bool[] validTiles, int padding = 0)
		{
			int num = 1;
			object @lock = this._lock;
			if (num == 0)
			{
			}
			int size = this._protectedStructures._size;
			int size2 = this._protectedStructures._size;
			if (size2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (size2 == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			if (size2 != 0)
			{
			}
			long num2 = 0L;
			if (size2 != 0)
			{
				Monitor.Exit(@lock);
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x001F6500 File Offset: 0x001F4700
		public Rectangle GetBoundingBox()
		{
			object @lock = this._lock;
			if (this._structures._size != 0)
			{
				List<Rectangle> structures = this._structures;
				List<Rectangle> structures2 = this._structures;
				if (structures == null)
				{
				}
				List<Rectangle> structures3 = this._structures;
			}
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			int value = num.m_value;
			if (num != 0)
			{
				Monitor.Exit(@lock);
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddStructure(Rectangle area, int padding = 0)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddProtectedStructure(Rectangle area, int padding = 0)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x001F6578 File Offset: 0x001F4778
		public void Reset()
		{
			object @lock = this._lock;
			List<Rectangle> protectedStructures = this._protectedStructures;
			long num = 0L;
			int version = protectedStructures._version;
			protectedStructures._syncRoot = version;
			if (protectedStructures != null)
			{
				Monitor.Exit(@lock);
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x001F65D8 File Offset: 0x001F47D8
		public StructureMap()
		{
		}

		// Token: 0x04003A87 RID: 14983
		private readonly List<Rectangle> _structures;

		// Token: 0x04003A88 RID: 14984
		private readonly List<Rectangle> _protectedStructures;

		// Token: 0x04003A89 RID: 14985
		private readonly object _lock;

		// Token: 0x020004E8 RID: 1256
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003074 RID: 12404 RVA: 0x001F65EC File Offset: 0x001F47EC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003075 RID: 12405 RVA: 0x001F65FC File Offset: 0x001F47FC
			public <>c()
			{
			}

			// Token: 0x06003076 RID: 12406 RVA: 0x000021DB File Offset: 0x000003DB
			internal int <GetBoundingBox>b__5_0(Rectangle rect)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003077 RID: 12407 RVA: 0x000021DB File Offset: 0x000003DB
			internal int <GetBoundingBox>b__5_1(Rectangle rect)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003078 RID: 12408 RVA: 0x001F6610 File Offset: 0x001F4810
			internal int <GetBoundingBox>b__5_2(Rectangle rect)
			{
				int num;
				return num;
			}

			// Token: 0x06003079 RID: 12409 RVA: 0x001F6620 File Offset: 0x001F4820
			internal int <GetBoundingBox>b__5_3(Rectangle rect)
			{
				int num;
				return num;
			}

			// Token: 0x04003A8A RID: 14986
			public static readonly StructureMap.<>c <>9;

			// Token: 0x04003A8B RID: 14987
			public static Func<Rectangle, int> <>9__5_0;

			// Token: 0x04003A8C RID: 14988
			public static Func<Rectangle, int> <>9__5_1;

			// Token: 0x04003A8D RID: 14989
			public static Func<Rectangle, int> <>9__5_2;

			// Token: 0x04003A8E RID: 14990
			public static Func<Rectangle, int> <>9__5_3;
		}
	}
}
