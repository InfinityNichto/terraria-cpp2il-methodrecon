using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ACD RID: 2765
	public class UISlicedImage : UIElement
	{
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06005155 RID: 20821 RVA: 0x002802CC File Offset: 0x0027E4CC
		// (set) Token: 0x06005156 RID: 20822 RVA: 0x002802E4 File Offset: 0x0027E4E4
		public Color Color
		{
			get
			{
				Color color = this._color;
				Color color2;
				return color2;
			}
			set
			{
				this._color = value;
			}
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x002802F8 File Offset: 0x0027E4F8
		public UISlicedImage(Asset<Texture2D> texture)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			this._texture = texture;
			if (num == 0)
			{
			}
			int num2 = Utils.Width(texture);
			int num3 = Utils.Height(this._texture);
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00280330 File Offset: 0x0027E530
		public void SetImage(Asset<Texture2D> texture)
		{
			this._texture = texture;
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00280344 File Offset: 0x0027E544
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			Asset<Texture2D> texture = this._texture;
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float width = this._dimensions.Width;
			float height = this._dimensions.Height;
			int leftSliceDepth = this._leftSliceDepth;
			int rightSliceDepth = this._rightSliceDepth;
			int topSliceDepth = this._topSliceDepth;
			int bottomSliceDepth = this._bottomSliceDepth;
			Color color = this._color;
			if (texture == null)
			{
			}
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x002803B4 File Offset: 0x0027E5B4
		public void SetSliceDepths(int top, int bottom, int left, int right)
		{
			this._leftSliceDepth = left;
			this._rightSliceDepth = right;
			this._topSliceDepth = top;
			this._bottomSliceDepth = bottom;
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x002803E0 File Offset: 0x0027E5E0
		public void SetSliceDepths(int fluff)
		{
		}

		// Token: 0x040089E7 RID: 35303
		private Asset<Texture2D> _texture;

		// Token: 0x040089E8 RID: 35304
		private Color _color;

		// Token: 0x040089E9 RID: 35305
		private int _leftSliceDepth;

		// Token: 0x040089EA RID: 35306
		private int _rightSliceDepth;

		// Token: 0x040089EB RID: 35307
		private int _topSliceDepth;

		// Token: 0x040089EC RID: 35308
		private int _bottomSliceDepth;
	}
}
