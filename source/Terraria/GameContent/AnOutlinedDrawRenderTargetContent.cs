using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020007CA RID: 1994
	public abstract class AnOutlinedDrawRenderTargetContent : ARenderTargetContentByRequest
	{
		// Token: 0x060040A3 RID: 16547 RVA: 0x00243894 File Offset: 0x00241A94
		public void UseColor(Color color)
		{
			this._borderColor = color;
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x002438A8 File Offset: 0x00241AA8
		protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060040A5 RID: 16549
		internal abstract void DrawTheContent(SpriteBatch spriteBatch);

		// Token: 0x060040A6 RID: 16550 RVA: 0x002438B8 File Offset: 0x00241AB8
		protected AnOutlinedDrawRenderTargetContent()
		{
			if (!true)
			{
			}
			this._borderColor = 1;
			base..ctor();
		}

		// Token: 0x04007E54 RID: 32340
		protected int width;

		// Token: 0x04007E55 RID: 32341
		protected int height;

		// Token: 0x04007E56 RID: 32342
		public Color _borderColor;

		// Token: 0x04007E57 RID: 32343
		private EffectPass _coloringShader;

		// Token: 0x04007E58 RID: 32344
		private RenderTarget2D _helperTarget;
	}
}
