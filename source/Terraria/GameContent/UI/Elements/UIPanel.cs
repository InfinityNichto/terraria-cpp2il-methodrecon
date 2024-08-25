using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AC5 RID: 2757
	public class UIPanel : UIElement
	{
		// Token: 0x0600511D RID: 20765 RVA: 0x0027F664 File Offset: 0x0027D864
		public UIPanel()
		{
			Color color;
			this.BackgroundColor = color;
			base..ctor();
			Asset<Texture2D> borderTexture = this._borderTexture;
			if (borderTexture == null)
			{
				if (borderTexture == null)
				{
				}
				return;
			}
			Asset<Texture2D> backgroundTexture = this._backgroundTexture;
			if (backgroundTexture == null)
			{
				if (backgroundTexture == null)
				{
				}
				return;
			}
			base.SetPadding(0f);
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x0027F6BC File Offset: 0x0027D8BC
		public UIPanel(Asset<Texture2D> customBackground, Asset<Texture2D> customborder, int customCornerSize = 12, int customBarSize = 4)
		{
			Color color;
			this.BackgroundColor = color;
			base..ctor();
			if (this._borderTexture == null)
			{
				this._borderTexture = customborder;
			}
			Asset<Texture2D> backgroundTexture = this._backgroundTexture;
			if (backgroundTexture == null)
			{
				this._backgroundTexture = customBackground;
			}
			this._cornerSize = customCornerSize;
			this._barSize = customBarSize;
			if (backgroundTexture == null)
			{
			}
			base.SetPadding(0f);
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x0027F724 File Offset: 0x0027D924
		private void DrawPanel(SpriteBatch spriteBatch, Texture2D texture, Color color)
		{
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float width = this._dimensions.Width;
			float height = this._dimensions.Height;
			int cornerSize = this._cornerSize;
			int cornerSize2 = this._cornerSize;
			int cornerSize3 = this._cornerSize;
			int cornerSize4 = this._cornerSize;
			int cornerSize5 = this._cornerSize;
			int barSize = this._barSize;
			int cornerSize6 = this._cornerSize;
			int cornerSize7 = this._cornerSize;
			int barSize2 = this._barSize;
			int cornerSize8 = this._cornerSize;
			int cornerSize9 = this._cornerSize;
			int barSize3 = this._barSize;
			int cornerSize10 = this._cornerSize;
			int cornerSize11 = this._cornerSize;
			int barSize4 = this._barSize;
			int cornerSize12 = this._cornerSize;
			int barSize5 = this._barSize;
			int cornerSize13 = this._cornerSize;
			int cornerSize14 = this._cornerSize;
			int barSize6 = this._barSize;
			int cornerSize15 = this._cornerSize;
			int barSize7 = this._barSize;
			int cornerSize16 = this._cornerSize;
			int cornerSize17 = this._cornerSize;
			int barSize8 = this._barSize;
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x0027F83C File Offset: 0x0027DA3C
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			if (this._backgroundTexture != null)
			{
				Color backgroundColor = this.BackgroundColor;
			}
			if (this._borderTexture != null)
			{
				Color borderColor = this.BorderColor;
				return;
			}
		}

		// Token: 0x040089C3 RID: 35267
		private int _cornerSize;

		// Token: 0x040089C4 RID: 35268
		private int _barSize;

		// Token: 0x040089C5 RID: 35269
		private Asset<Texture2D> _borderTexture;

		// Token: 0x040089C6 RID: 35270
		private Asset<Texture2D> _backgroundTexture;

		// Token: 0x040089C7 RID: 35271
		public Color BorderColor;

		// Token: 0x040089C8 RID: 35272
		public Color BackgroundColor;
	}
}
