using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200078C RID: 1932
	public class SkyManager : EffectManager<CustomSky>
	{
		// Token: 0x06003F1D RID: 16157 RVA: 0x0023FC30 File Offset: 0x0023DE30
		public void Reset()
		{
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x000021DB File Offset: 0x000003DB
		public void Update(GameTime gameTime)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0023FC58 File Offset: 0x0023DE58
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x0023FC68 File Offset: 0x0023DE68
		public void DrawToDepth(SpriteBatch spriteBatch, float minDepth)
		{
			float lastDepth = this._lastDepth;
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x0023FC7C File Offset: 0x0023DE7C
		public void DrawDepthRange(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			spriteBatch.End();
			if (!true)
			{
			}
			LinkedList<CustomSky> activeSkies = this._activeSkies;
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x0023FCB0 File Offset: 0x0023DEB0
		public void DrawRemainingDepth(SpriteBatch spriteBatch)
		{
			float lastDepth = this._lastDepth;
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0023FCC4 File Offset: 0x0023DEC4
		public void ResetDepthTracker()
		{
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x0023FCD4 File Offset: 0x0023DED4
		public void SetStartingDepth(float depth)
		{
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0023FCE4 File Offset: 0x0023DEE4
		public override void OnActivate(CustomSky effect, Vector2 position)
		{
			LinkedList<CustomSky> activeSkies = this._activeSkies;
			LinkedList<CustomSky> activeSkies2 = this._activeSkies;
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x0023FD00 File Offset: 0x0023DF00
		public Color ProcessTileColor(Color color)
		{
			LinkedList<CustomSky> activeSkies = this._activeSkies;
			throw new OutOfMemoryException();
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x0023FD24 File Offset: 0x0023DF24
		public float ProcessCloudAlpha()
		{
			LinkedList<CustomSky> activeSkies = this._activeSkies;
			throw new OutOfMemoryException();
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0023FD48 File Offset: 0x0023DF48
		public SkyManager()
		{
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x0023FD5C File Offset: 0x0023DF5C
		// Note: this type is marked as 'beforefieldinit'.
		static SkyManager()
		{
		}

		// Token: 0x04007D9F RID: 32159
		public static SkyManager Instance;

		// Token: 0x04007DA0 RID: 32160
		private float _lastDepth;

		// Token: 0x04007DA1 RID: 32161
		private LinkedList<CustomSky> _activeSkies;
	}
}
