using System;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000337 RID: 823
	public class GraphicsDeviceManager
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0005F3F4 File Offset: 0x0005D5F4
		public GraphicsDevice GraphicsDevice
		{
			get
			{
				return this.game.GraphicsDevice;
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0005F40C File Offset: 0x0005D60C
		public GraphicsDeviceManager(Game game)
		{
			this.game = game;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0005F428 File Offset: 0x0005D628
		public bool IsFullScreen
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0005F438 File Offset: 0x0005D638
		public void ApplyChanges()
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0005F448 File Offset: 0x0005D648
		public void ToggleFullScreen()
		{
		}

		// Token: 0x040022B7 RID: 8887
		private Game game;

		// Token: 0x040022B8 RID: 8888
		public bool SynchronizeWithVerticalRetrace;

		// Token: 0x040022B9 RID: 8889
		public int PreferredBackBufferWidth;

		// Token: 0x040022BA RID: 8890
		public int PreferredBackBufferHeight;

		// Token: 0x040022BB RID: 8891
		public static int DefaultBackBufferWidth;

		// Token: 0x040022BC RID: 8892
		public static int DefaultBackBufferHeight;
	}
}
