using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x020009D9 RID: 2521
	public class SandstormSky : CustomSky
	{
		// Token: 0x06004A46 RID: 19014 RVA: 0x0026583C File Offset: 0x00263A3C
		public override void OnLoad()
		{
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x0026584C File Offset: 0x00263A4C
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x00265878 File Offset: 0x00263A78
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			float num = Math.Min(minDepth, maxDepth);
			float opacity = this._opacity;
			Color color2;
			Color color = color2 * num;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x002658C0 File Offset: 0x00263AC0
		public override void Activate(Vector2 position, params object[] args)
		{
			this._isActive = true;
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x002658D4 File Offset: 0x00263AD4
		public override void Deactivate(params object[] args)
		{
			this._isLeaving = true;
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x002658E8 File Offset: 0x00263AE8
		public override void Reset()
		{
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x002658F8 File Offset: 0x00263AF8
		public override bool IsActive()
		{
			return this._isActive;
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x0026590C File Offset: 0x00263B0C
		public SandstormSky()
		{
		}

		// Token: 0x040084E2 RID: 34018
		private UnifiedRandom _random;

		// Token: 0x040084E3 RID: 34019
		private bool _isActive;

		// Token: 0x040084E4 RID: 34020
		private bool _isLeaving;

		// Token: 0x040084E5 RID: 34021
		private float _opacity;
	}
}
