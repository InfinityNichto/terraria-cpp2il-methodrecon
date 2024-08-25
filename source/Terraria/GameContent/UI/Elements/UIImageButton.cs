using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ABA RID: 2746
	public class UIImageButton : UIElement
	{
		// Token: 0x060050E6 RID: 20710 RVA: 0x0027ED30 File Offset: 0x0027CF30
		public UIImageButton(Asset<Texture2D> texture)
		{
			this._texture = texture;
			int num = Utils.Width(texture);
			int num2 = Utils.Height(this._texture);
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x0027ED68 File Offset: 0x0027CF68
		public void SetHoverImage(Asset<Texture2D> texture)
		{
			this._borderTexture = texture;
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x0027ED7C File Offset: 0x0027CF7C
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

		// Token: 0x060050E9 RID: 20713 RVA: 0x0027EDA8 File Offset: 0x0027CFA8
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			Asset<Texture2D> texture = this._texture;
			if (texture == null)
			{
			}
			bool <IsMouseHovering>k__BackingField = this.<IsMouseHovering>k__BackingField;
			if (texture == null)
			{
			}
			Asset<Texture2D> borderTexture = this._borderTexture;
			if (borderTexture == null || !this.<IsMouseHovering>k__BackingField || borderTexture == null)
			{
			}
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x0027EDF0 File Offset: 0x0027CFF0
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x0027EE04 File Offset: 0x0027D004
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x0027EE18 File Offset: 0x0027D018
		public void SetVisibility(float whenActive, float whenInactive)
		{
		}

		// Token: 0x040089A9 RID: 35241
		private Asset<Texture2D> _texture;

		// Token: 0x040089AA RID: 35242
		private float _visibilityActive = 0f;

		// Token: 0x040089AB RID: 35243
		private float _visibilityInactive;

		// Token: 0x040089AC RID: 35244
		private Asset<Texture2D> _borderTexture;
	}
}
