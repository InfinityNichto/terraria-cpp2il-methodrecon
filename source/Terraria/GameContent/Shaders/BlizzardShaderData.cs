using System;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000820 RID: 2080
	public class BlizzardShaderData : ScreenShaderData
	{
		// Token: 0x060042B2 RID: 17074 RVA: 0x0024C048 File Offset: 0x0024A248
		public BlizzardShaderData(string passName)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this.windSpeed = (float)52429;
			this._texturePosition = 1;
			base..ctor(passName);
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x0024C074 File Offset: 0x0024A274
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x0024C118 File Offset: 0x0024A318
		public override void Apply()
		{
			float x = this._texturePosition.X;
			float y = this._texturePosition.Y;
			base.Apply();
		}

		// Token: 0x040080F2 RID: 33010
		private Vector2 _texturePosition;

		// Token: 0x040080F3 RID: 33011
		private float windSpeed;
	}
}
