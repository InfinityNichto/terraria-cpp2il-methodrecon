using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ABB RID: 2747
	public class UIImageFramed : UIElement, IColorable
	{
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060050ED RID: 20717 RVA: 0x0027EE2C File Offset: 0x0027D02C
		// (set) Token: 0x060050EE RID: 20718 RVA: 0x0027EE44 File Offset: 0x0027D044
		public Color Color
		{
			[CompilerGenerated]
			get
			{
				Color color = this.<Color>k__BackingField;
				Color color2;
				return color2;
			}
			[CompilerGenerated]
			set
			{
				this.<Color>k__BackingField = value;
			}
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x0027EE58 File Offset: 0x0027D058
		public UIImageFramed(Asset<Texture2D> texture, Rectangle frame)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			this._texture = texture;
			this._frame = frame;
			if (num == 0)
			{
			}
			this.<Color>k__BackingField = num;
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x0027EE88 File Offset: 0x0027D088
		public void SetImage(Asset<Texture2D> texture, Rectangle frame)
		{
			this._texture = texture;
			this._frame = frame;
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x0027EEA4 File Offset: 0x0027D0A4
		public void SetFrame(Rectangle frame)
		{
			this._frame = frame;
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x0027EEB8 File Offset: 0x0027D0B8
		public void SetFrame(int frameCountHorizontal, int frameCountVertical, int frameX, int frameY, int sizeOffsetX, int sizeOffsetY)
		{
			Asset<Texture2D> texture = this._texture;
			if (!true)
			{
			}
			long num = 0L;
			Rectangle rectangle = Utils.Frame(texture, frameCountHorizontal, frameCountVertical, frameX, frameY, sizeOffsetX, (int)num).OffsetSize(frameCountHorizontal, sizeOffsetX);
			this.SetFrame(rectangle);
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x0027EEF0 File Offset: 0x0027D0F0
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			Asset<Texture2D> texture = this._texture;
			Rectangle frame = this._frame;
			int width = this._frame.Width;
			Color color = this.<Color>k__BackingField;
		}

		// Token: 0x040089AD RID: 35245
		private Asset<Texture2D> _texture;

		// Token: 0x040089AE RID: 35246
		private Rectangle _frame;

		// Token: 0x040089AF RID: 35247
		[CompilerGenerated]
		private Color <Color>k__BackingField;
	}
}
