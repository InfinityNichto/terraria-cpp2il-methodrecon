using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB7 RID: 2743
	public class UIHorizontalSeparator : UIElement
	{
		// Token: 0x060050D8 RID: 20696 RVA: 0x0027E934 File Offset: 0x0027CB34
		public UIHorizontalSeparator(int EdgeWidth = 2, bool highlightSideUp = true)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			if (num == 0)
			{
			}
			this.Color = num;
			if (num == 0)
			{
			}
			if ("Images/UI/CharCreation/Separator1" != null)
			{
				return;
			}
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x0027E978 File Offset: 0x0027CB78
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			Asset<Texture2D> texture = this._texture;
			int edgeWidth = this.EdgeWidth;
			Color color = this.Color;
			if (texture == null)
			{
			}
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x0027E9AC File Offset: 0x0027CBAC
		public override bool ContainsPoint(Vector2 point)
		{
		}

		// Token: 0x04008994 RID: 35220
		private Asset<Texture2D> _texture;

		// Token: 0x04008995 RID: 35221
		public Color Color;

		// Token: 0x04008996 RID: 35222
		public int EdgeWidth;
	}
}
