using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000789 RID: 1929
	public class OverlayManager : EffectManager<Overlay>
	{
		// Token: 0x06003F11 RID: 16145 RVA: 0x0023F9DC File Offset: 0x0023DBDC
		public OverlayManager()
		{
			if (!true)
			{
			}
			Type type;
			string[] names = Enum.GetNames(type);
			base..ctor();
			LinkedList<Overlay>[] activeOverlays = this._activeOverlays;
			LinkedList<Overlay>[] activeOverlays2 = this._activeOverlays;
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x0023FA14 File Offset: 0x0023DC14
		public override void OnActivate(Overlay overlay, Vector2 position)
		{
			OverlayMode mode = overlay.Mode;
			LinkedList<Overlay>[] activeOverlays = this._activeOverlays;
			int overlayCount = this._overlayCount;
			this._overlayCount = overlayCount;
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x0023FA64 File Offset: 0x0023DC64
		public void Update(GameTime gameTime)
		{
			LinkedList<Overlay>[] activeOverlays = this._activeOverlays;
			if (gameTime.elapsedGameTime == null)
			{
			}
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x0023FAB8 File Offset: 0x0023DCB8
		public void Draw(SpriteBatch spriteBatch, RenderLayers layer)
		{
			if (this._overlayCount != 0)
			{
				LinkedList<Overlay>[] activeOverlays = this._activeOverlays;
				if (this != null)
				{
					int overlayCount = this._overlayCount;
					Matrix transform = Main.Transform;
					while (this != null)
					{
					}
				}
				spriteBatch.End();
			}
		}

		// Token: 0x04007D8E RID: 32142
		private const float OPACITY_RATE = 1f;

		// Token: 0x04007D8F RID: 32143
		private LinkedList<Overlay>[] _activeOverlays;

		// Token: 0x04007D90 RID: 32144
		private int _overlayCount;
	}
}
