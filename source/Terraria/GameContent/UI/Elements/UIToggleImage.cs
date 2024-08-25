using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AD1 RID: 2769
	public class UIToggleImage : UIElement
	{
		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x00280AC4 File Offset: 0x0027ECC4
		public bool IsOn
		{
			get
			{
				return this._isOn;
			}
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00280AD8 File Offset: 0x0027ECD8
		public UIToggleImage(Asset<Texture2D> texture, int width, int height, Point onTextureOffset, Point offTextureOffset)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			base..ctor();
			this._onTexture = texture;
			this._offTexture = texture;
			this._onTextureOffset = onTextureOffset;
			this._drawWidth = width;
			this._drawHeight = height;
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x00280B1C File Offset: 0x0027ED1C
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			bool isOn = this._isOn;
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			bool <IsMouseHovering>k__BackingField = this.<IsMouseHovering>k__BackingField;
			if (364 == 0)
			{
			}
			int drawWidth = this._drawWidth;
			int drawHeight = this._drawHeight;
			int drawWidth2 = this._drawWidth;
			int drawHeight2 = this._drawHeight;
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00280B78 File Offset: 0x0027ED78
		public override void LeftClick(UIMouseEvent evt)
		{
			bool isOn = this._isOn;
			this._isOn = isOn;
			base.LeftClick(evt);
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x00280B9C File Offset: 0x0027ED9C
		public void SetState(bool value)
		{
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x00280BAC File Offset: 0x0027EDAC
		public void Toggle()
		{
			bool isOn = this._isOn;
			this._isOn = isOn;
		}

		// Token: 0x04008A09 RID: 35337
		private Asset<Texture2D> _onTexture;

		// Token: 0x04008A0A RID: 35338
		private Asset<Texture2D> _offTexture;

		// Token: 0x04008A0B RID: 35339
		private int _drawWidth;

		// Token: 0x04008A0C RID: 35340
		private int _drawHeight;

		// Token: 0x04008A0D RID: 35341
		private Point _onTextureOffset;

		// Token: 0x04008A0E RID: 35342
		private Point _offTextureOffset;

		// Token: 0x04008A0F RID: 35343
		private bool _isOn;
	}
}
