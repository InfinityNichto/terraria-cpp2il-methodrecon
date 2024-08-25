using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB8 RID: 2744
	public class UIIconTextButton : UIElement
	{
		// Token: 0x060050DB RID: 20699 RVA: 0x0027E9BC File Offset: 0x0027CBBC
		public UIIconTextButton(LocalizedText title, Color textColor, string iconTexturePath, float textSize = 1f, float titleAlignmentX = 0.5f, float titleWidthReduction = 10f)
		{
			int num = 13107;
			this._opacity = (float)num;
			this.FadeFromBlack = 0f;
			if (num == 0)
			{
			}
			base..ctor();
			if (num == 0)
			{
			}
			StyleDimension styleDimension = StyleDimension.FromPixels(0f);
			int num2 = 16904;
			StyleDimension styleDimension2 = StyleDimension.FromPixels(0f);
			if (num2 == 0)
			{
			}
			this._hoverColor = num2;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x0027EA4C File Offset: 0x0027CC4C
		public void SetText(LocalizedText text, float textSize, Color color)
		{
			UIText title = this._title;
			if (title != null)
			{
				title.Remove();
			}
			StyleDimension styleDimension = StyleDimension.FromPixels(0f);
			Asset<Texture2D> iconTexture = this._iconTexture;
			if (iconTexture != null)
			{
				int num = Utils.Width(iconTexture);
				UIText title2 = this._title;
				Asset<Texture2D> iconTexture2 = this._iconTexture;
				float height = title2._dimensions.Height;
				int num2 = Utils.Height(iconTexture2);
				return;
			}
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x0027EABC File Offset: 0x0027CCBC
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			if (!this._hovered)
			{
				return;
			}
			if (this._soundedHover)
			{
				return;
			}
			float y = this._dimensions.Y;
			float x = this._dimensions.X;
			float height = this._dimensions.Height;
			float width = this._dimensions.Width;
			this._soundedHover = true;
			Asset<Texture2D> basePanelTexture = this._BasePanelTexture;
			Color color = this._color;
			float opacity = this._opacity;
			float fadeFromBlack = this.FadeFromBlack;
			Asset<Texture2D> iconTexture = this._iconTexture;
			if (iconTexture != null)
			{
				if (iconTexture == null)
				{
				}
				float whiteLerp = this._whiteLerp;
				Asset<Texture2D> iconTexture2 = this._iconTexture;
				if (32640 == 0)
				{
				}
				int num = Utils.Width(iconTexture2);
				int num2 = Utils.Height(this._iconTexture);
			}
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x0027EB70 File Offset: 0x0027CD70
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			base.LeftMouseDown(evt);
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x0027EB84 File Offset: 0x0027CD84
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
			if (!true)
			{
			}
			float whiteLerp = this._whiteLerp;
			Color color;
			this._color = color;
			this._opacity = (float)13107;
			this._hovered = true;
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x0027EBBC File Offset: 0x0027CDBC
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
			if (!true)
			{
			}
			float fadeFromBlack = this.FadeFromBlack;
			Color color;
			this._color = color;
			this._opacity = (float)16256;
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x0027EBEC File Offset: 0x0027CDEC
		public void SetColor(Color color, float opacity)
		{
			this._color = color;
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x0027EC00 File Offset: 0x0027CE00
		public void SetHoverColor(Color color)
		{
			this._hoverColor = color;
		}

		// Token: 0x04008997 RID: 35223
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x04008998 RID: 35224
		private readonly Asset<Texture2D> _hoveredTexture;

		// Token: 0x04008999 RID: 35225
		private readonly Asset<Texture2D> _iconTexture;

		// Token: 0x0400899A RID: 35226
		private Color _color;

		// Token: 0x0400899B RID: 35227
		private Color _hoverColor;

		// Token: 0x0400899C RID: 35228
		public float FadeFromBlack;

		// Token: 0x0400899D RID: 35229
		private float _whiteLerp;

		// Token: 0x0400899E RID: 35230
		private float _opacity;

		// Token: 0x0400899F RID: 35231
		private bool _hovered;

		// Token: 0x040089A0 RID: 35232
		private bool _soundedHover;

		// Token: 0x040089A1 RID: 35233
		private UIText _title;
	}
}
