using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000788 RID: 1928
	public abstract class Overlay : GameEffect
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x0023F9A4 File Offset: 0x0023DBA4
		public RenderLayers Layer
		{
			get
			{
				return this._layer;
			}
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x0023F9B8 File Offset: 0x0023DBB8
		public Overlay(EffectPriority priority, RenderLayers layer)
		{
			this._priority = priority;
			this._layer = layer;
		}

		// Token: 0x06003F0F RID: 16143
		public abstract void Draw(SpriteBatch spriteBatch);

		// Token: 0x06003F10 RID: 16144
		public abstract void Update(GameTime gameTime);

		// Token: 0x04007D8C RID: 32140
		public OverlayMode Mode;

		// Token: 0x04007D8D RID: 32141
		private RenderLayers _layer;
	}
}
