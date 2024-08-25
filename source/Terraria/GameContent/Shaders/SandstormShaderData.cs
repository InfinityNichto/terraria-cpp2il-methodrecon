using System;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000823 RID: 2083
	public class SandstormShaderData : ScreenShaderData
	{
		// Token: 0x060042BA RID: 17082 RVA: 0x0024C234 File Offset: 0x0024A434
		public SandstormShaderData(string passName)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._texturePosition = 1;
			base..ctor(passName);
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x0024C258 File Offset: 0x0024A458
		public override void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
			Vector2 vector;
			vector.Normalize();
			TimeSpan elapsedGameTime = gameTime.elapsedGameTime;
			float x = this._texturePosition.X;
			float y = this._texturePosition.Y;
			if (elapsedGameTime == null)
			{
			}
			float x2 = this._texturePosition.X;
			float y2 = this._texturePosition.Y;
			this._texturePosition.X = x2;
			this._texturePosition.Y = x2;
			base.Update(gameTime);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x0024C2DC File Offset: 0x0024A4DC
		public override void Apply()
		{
			float x = this._texturePosition.X;
			float y = this._texturePosition.Y;
			ScreenShaderData screenShaderData;
			screenShaderData.Apply();
		}

		// Token: 0x040080F6 RID: 33014
		private Vector2 _texturePosition;
	}
}
