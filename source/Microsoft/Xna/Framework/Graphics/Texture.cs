using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003A9 RID: 937
	public abstract class Texture : GraphicsResource
	{
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0006A43C File Offset: 0x0006863C
		internal int SortingKey
		{
			get
			{
				return this._sortingKey;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x0006A450 File Offset: 0x00068650
		public SurfaceFormat Format
		{
			get
			{
				return this._format;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0006A464 File Offset: 0x00068664
		public int LevelCount
		{
			get
			{
				return this._levelCount;
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0006A478 File Offset: 0x00068678
		internal static int CalculateMipLevels(int width, int height = 0, int depth = 0)
		{
			if (!true)
			{
			}
			int num = Math.Max(Math.Max(0, width), height);
			return 1;
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0006A49C File Offset: 0x0006869C
		internal static void GetSizeForLevel(int width, int height, int level, [Out] int w, [Out] int h)
		{
			w.m_value = width;
			h.m_value = height;
			h.m_value = height;
			if (height != 0)
			{
				return;
			}
			int num = 1;
			h.m_value = num;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0006A4D8 File Offset: 0x000686D8
		internal static void GetSizeForLevel(int width, int height, int depth, int level, [Out] int w, [Out] int h, [Out] int d)
		{
			w.m_value = width;
			h.m_value = height;
			d.m_value = depth;
			int num = 1;
			w.m_value = num;
			int num2 = 1;
			h.m_value = num2;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0006A51C File Offset: 0x0006871C
		internal int GetPitch(int width)
		{
			return this._format.GetSize();
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0006A538 File Offset: 0x00068738
		protected internal override void GraphicsDeviceResetting()
		{
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0006A548 File Offset: 0x00068748
		protected Texture()
		{
			int num = Interlocked.Increment(0);
			this._sortingKey = num;
			base..ctor();
		}

		// Token: 0x04002774 RID: 10100
		internal SurfaceFormat _format;

		// Token: 0x04002775 RID: 10101
		internal int _levelCount;

		// Token: 0x04002776 RID: 10102
		private readonly int _sortingKey;

		// Token: 0x04002777 RID: 10103
		private static int _lastSortingKey;
	}
}
