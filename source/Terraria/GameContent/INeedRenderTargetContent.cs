using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020007C8 RID: 1992
	public interface INeedRenderTargetContent
	{
		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06004095 RID: 16533
		bool IsReady { get; }

		// Token: 0x06004096 RID: 16534
		void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch);

		// Token: 0x06004097 RID: 16535
		void Reset();
	}
}
