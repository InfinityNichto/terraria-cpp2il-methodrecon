using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB9 RID: 2745
	public class UIImage : UIElement
	{
		// Token: 0x060050E3 RID: 20707 RVA: 0x0027EC14 File Offset: 0x0027CE14
		public UIImage(Asset<Texture2D> texture)
		{
			int num = 16256;
			this.ImageScale = (float)num;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			this._texture = texture;
			int num2 = Utils.Width(texture);
			int num3 = Utils.Height(this._texture);
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x0027EC58 File Offset: 0x0027CE58
		public void SetImage(Asset<Texture2D> texture)
		{
			int num = 1;
			this._texture = texture;
			if (num == 0)
			{
			}
			int num2 = Utils.Width(texture);
			int num3 = Utils.Height(this._texture);
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x0027EC84 File Offset: 0x0027CE84
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			Asset<Texture2D> texture = this._texture;
			if (this.ScaleToFit)
			{
				return;
			}
			if (texture == null)
			{
			}
			float imageScale = this.ImageScale;
			if (texture == null)
			{
			}
			float x2 = this.NormalizedOrigin.X;
			float y = this.NormalizedOrigin.Y;
			bool removeFloatingPointsFromDrawPosition = this.RemoveFloatingPointsFromDrawPosition;
			if (removeFloatingPointsFromDrawPosition)
			{
				if (!removeFloatingPointsFromDrawPosition)
				{
				}
			}
			Asset<Texture2D> texture2 = this._texture;
			float rotation = this.Rotation;
			float x3 = this.NormalizedOrigin.X;
			float y2 = this.NormalizedOrigin.Y;
			if (texture2 == null)
			{
			}
			float imageScale2 = this.ImageScale;
		}

		// Token: 0x040089A2 RID: 35234
		private Asset<Texture2D> _texture;

		// Token: 0x040089A3 RID: 35235
		public float ImageScale;

		// Token: 0x040089A4 RID: 35236
		public float Rotation;

		// Token: 0x040089A5 RID: 35237
		public bool ScaleToFit;

		// Token: 0x040089A6 RID: 35238
		public Color Color;

		// Token: 0x040089A7 RID: 35239
		public Vector2 NormalizedOrigin;

		// Token: 0x040089A8 RID: 35240
		public bool RemoveFloatingPointsFromDrawPosition;
	}
}
