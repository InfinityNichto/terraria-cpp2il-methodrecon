using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AD2 RID: 2770
	public class UIVerticalSeparator : UIElement
	{
		// Token: 0x06005192 RID: 20882 RVA: 0x00280BC8 File Offset: 0x0027EDC8
		public UIVerticalSeparator()
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
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x00280BFC File Offset: 0x0027EDFC
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			Asset<Texture2D> texture = this._texture;
			Color color = this.Color;
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00280C24 File Offset: 0x0027EE24
		public override bool ContainsPoint(Vector2 point)
		{
		}

		// Token: 0x04008A10 RID: 35344
		private Asset<Texture2D> _texture;

		// Token: 0x04008A11 RID: 35345
		public Color Color;

		// Token: 0x04008A12 RID: 35346
		public int EdgeWidth;
	}
}
