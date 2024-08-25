using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AA8 RID: 2728
	public class UICharacterNameButton : UIElement
	{
		// Token: 0x06005064 RID: 20580 RVA: 0x0027D02C File Offset: 0x0027B22C
		public UICharacterNameButton(LocalizedText titleText, LocalizedText emptyContentText, [Optional] LocalizedText description)
		{
			int num = 16800;
			this.DistanceFromTitleToOption = (float)num;
			if (num == 0)
			{
			}
			base..ctor();
			if (num == 0)
			{
			}
			int num2 = 16928;
			this.Description = description;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x0027D09C File Offset: 0x0027B29C
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
			this._soundedHover = true;
			Asset<Texture2D> basePanelTexture = this._BasePanelTexture;
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float width = this._dimensions.Width;
			float height = this._dimensions.Height;
			if (this._hovered)
			{
				Asset<Texture2D> hoveredBorderTexture = this._hoveredBorderTexture;
				if (32640 == 0)
				{
				}
				if (32768 == 0)
				{
				}
			}
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x0027D11C File Offset: 0x0027B31C
		public void SetContents(string name)
		{
			this.actualContents = name;
			bool flag = string.IsNullOrEmpty(name);
			UIText text = this._text;
			UIText text2 = this._text;
			LocalizedText textToShowWhenEmpty = this._textToShowWhenEmpty;
			text2.SetText(textToShowWhenEmpty);
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x0027D198 File Offset: 0x0027B398
		public void TrimDisplayIfOverElementDimensions(int padding)
		{
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float width = this._dimensions.Width;
			float height = this._dimensions.Height;
			UIText text = this._text;
			float x2 = text._dimensions.X;
			float y2 = text._dimensions.Y;
			float width2 = text._dimensions.Width;
			float height2 = text._dimensions.Height;
			UIText text2 = this._text;
			string text3 = text2.Text;
			int stringLength = this._text.Text._stringLength;
			long num = 0L;
			string text4;
			text2.SetText(text4);
			UIText text5 = this._text;
			float x3 = text5._dimensions.X;
			float y3 = text5._dimensions.Y;
			float width3 = text5._dimensions.Width;
			float height3 = text5._dimensions.Height;
			UIText text6 = this._text;
			string text7 = text6.Text;
			int stringLength2 = this._text.Text._stringLength;
			long num2 = 0L;
			string text8 = text7.Substring((int)num2, (int)num) + "…";
			text6.SetText(text8);
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x0027D2D0 File Offset: 0x0027B4D0
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			base.LeftMouseDown(evt);
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x0027D2E4 File Offset: 0x0027B4E4
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
			this._hovered = true;
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x0027D300 File Offset: 0x0027B500
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
		}

		// Token: 0x04008922 RID: 35106
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x04008923 RID: 35107
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x04008924 RID: 35108
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x04008925 RID: 35109
		private bool _hovered;

		// Token: 0x04008926 RID: 35110
		private bool _soundedHover;

		// Token: 0x04008927 RID: 35111
		private readonly LocalizedText _textToShowWhenEmpty;

		// Token: 0x04008928 RID: 35112
		private string actualContents;

		// Token: 0x04008929 RID: 35113
		private UIText _text;

		// Token: 0x0400892A RID: 35114
		private UIText _title;

		// Token: 0x0400892B RID: 35115
		public readonly LocalizedText Description;

		// Token: 0x0400892C RID: 35116
		public float DistanceFromTitleToOption;
	}
}
