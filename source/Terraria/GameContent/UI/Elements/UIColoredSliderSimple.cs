using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AAD RID: 2733
	public class UIColoredSliderSimple : UIElement
	{
		// Token: 0x06005080 RID: 20608 RVA: 0x0027D780 File Offset: 0x0027B980
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			this.DrawValueBarDynamicWidth(spriteBatch);
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x0027D794 File Offset: 0x0027B994
		private void DrawValueBarDynamicWidth(SpriteBatch sb)
		{
			int num = 1;
			if (num == 0)
			{
			}
			float x = this._dimensions.X;
			if (num == 0)
			{
			}
			Color emptyColor = this.EmptyColor;
			Color filledColor = this.FilledColor;
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x0027D7DC File Offset: 0x0027B9DC
		public UIColoredSliderSimple()
		{
			if (!true)
			{
			}
			this.FilledColor = 1;
			if (!true)
			{
			}
			this.EmptyColor = 1;
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0400894A RID: 35146
		public float FillPercent;

		// Token: 0x0400894B RID: 35147
		public Color FilledColor;

		// Token: 0x0400894C RID: 35148
		public Color EmptyColor;
	}
}
