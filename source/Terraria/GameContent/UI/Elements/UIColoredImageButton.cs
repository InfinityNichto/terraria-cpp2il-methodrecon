using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AA9 RID: 2729
	public class UIColoredImageButton : UIElement
	{
		// Token: 0x0600506B RID: 20587 RVA: 0x0027D314 File Offset: 0x0027B514
		public UIColoredImageButton(Asset<Texture2D> texture, bool isSmall = false)
		{
			this._texture = texture;
			if ("Images/UI/CharCreation/SmallPanel" != null)
			{
				return;
			}
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x0027D384 File Offset: 0x0027B584
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

		// Token: 0x0600506D RID: 20589 RVA: 0x0027D3B0 File Offset: 0x0027B5B0
		public void SetImageWithoutSettingSize(Asset<Texture2D> texture)
		{
			this._texture = texture;
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x0027D3C4 File Offset: 0x0027B5C4
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			int num = 1;
			float x = this._dimensions.X;
			if (num == 0)
			{
			}
			Asset<Texture2D> backPanelTexture = this._backPanelTexture;
			if (backPanelTexture == null)
			{
			}
			bool <IsMouseHovering>k__BackingField = this.<IsMouseHovering>k__BackingField;
			if (<IsMouseHovering>k__BackingField)
			{
				return;
			}
			string <Name>k__BackingField = backPanelTexture.<Name>k__BackingField;
			if (backPanelTexture == null)
			{
			}
			Asset<Texture2D> backPanelTexture2 = this._backPanelTexture;
			if (!<IsMouseHovering>k__BackingField)
			{
			}
			Vector2 vector = Utils.Size(backPanelTexture2);
			bool hovered = this._hovered;
			if (hovered)
			{
				Asset<Texture2D> backPanelBorderTexture = this._backPanelBorderTexture;
				Asset<Texture2D> backPanelBorderTexture2;
				if (!hovered)
				{
					backPanelBorderTexture2 = this._backPanelBorderTexture;
				}
				if (<Name>k__BackingField == null)
				{
				}
				Vector2 vector2 = Utils.Size(backPanelBorderTexture2);
			}
			bool selected = this._selected;
			if (selected)
			{
				Asset<Texture2D> backPanelHighlightTexture = this._backPanelHighlightTexture;
				Asset<Texture2D> backPanelHighlightTexture2;
				if (!selected)
				{
					backPanelHighlightTexture2 = this._backPanelHighlightTexture;
				}
				if (<Name>k__BackingField == null)
				{
				}
				Vector2 vector3 = Utils.Size(backPanelHighlightTexture2);
			}
			if (this._middleTexture != null)
			{
				Asset<Texture2D> middleTexture = this._middleTexture;
				if (<Name>k__BackingField == null)
				{
				}
				Vector2 vector4 = Utils.Size(middleTexture);
			}
			Asset<Texture2D> texture = this._texture;
			Color color = this._color;
			Vector2 vector5 = Utils.Size(texture);
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x0027D4C4 File Offset: 0x0027B6C4
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
			this._hovered = true;
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x0027D4E0 File Offset: 0x0027B6E0
		public void SetVisibility(float whenActive, float whenInactive)
		{
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x0027D4F4 File Offset: 0x0027B6F4
		public void SetColor(Color color)
		{
			this._color = color;
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x0027D508 File Offset: 0x0027B708
		public void SetMiddleTexture(Asset<Texture2D> texAsset)
		{
			this._middleTexture = texAsset;
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x0027D51C File Offset: 0x0027B71C
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x0027D52C File Offset: 0x0027B72C
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
		}

		// Token: 0x0400892D RID: 35117
		private Asset<Texture2D> _backPanelTexture;

		// Token: 0x0400892E RID: 35118
		private Asset<Texture2D> _texture;

		// Token: 0x0400892F RID: 35119
		private Asset<Texture2D> _middleTexture;

		// Token: 0x04008930 RID: 35120
		private Asset<Texture2D> _backPanelHighlightTexture;

		// Token: 0x04008931 RID: 35121
		private Asset<Texture2D> _backPanelBorderTexture;

		// Token: 0x04008932 RID: 35122
		private Color _color;

		// Token: 0x04008933 RID: 35123
		private float _visibilityActive;

		// Token: 0x04008934 RID: 35124
		private float _visibilityInactive;

		// Token: 0x04008935 RID: 35125
		private bool _selected;

		// Token: 0x04008936 RID: 35126
		private bool _hovered;
	}
}
