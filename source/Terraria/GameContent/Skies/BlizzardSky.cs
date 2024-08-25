using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009CC RID: 2508
	public class BlizzardSky : CustomSky
	{
		// Token: 0x060049F0 RID: 18928 RVA: 0x002647FC File Offset: 0x002629FC
		public override void OnLoad()
		{
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x0026480C File Offset: 0x00262A0C
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x00264838 File Offset: 0x00262A38
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			if (!true)
			{
			}
			float num = Math.Min(minDepth, maxDepth);
			float opacity = this._opacity;
			Color color2;
			Color color = color2 * minDepth * num;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x00264888 File Offset: 0x00262A88
		public override void Activate(Vector2 position, params object[] args)
		{
			this._isActive = true;
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x0026489C File Offset: 0x00262A9C
		public override void Deactivate(params object[] args)
		{
			this._isLeaving = true;
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x002648B0 File Offset: 0x00262AB0
		public override void Reset()
		{
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x002648C0 File Offset: 0x00262AC0
		public override bool IsActive()
		{
			return this._isActive;
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x002648D4 File Offset: 0x00262AD4
		public BlizzardSky()
		{
		}

		// Token: 0x04008497 RID: 33943
		private UnifiedRandom _random;

		// Token: 0x04008498 RID: 33944
		private bool _isActive;

		// Token: 0x04008499 RID: 33945
		private bool _isLeaving;

		// Token: 0x0400849A RID: 33946
		private float _opacity;
	}
}
