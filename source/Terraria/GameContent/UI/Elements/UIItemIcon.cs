using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ABD RID: 2749
	public class UIItemIcon : UIElement
	{
		// Token: 0x060050F6 RID: 20726 RVA: 0x0027EF2C File Offset: 0x0027D12C
		public UIItemIcon(Item item, bool blackedOut)
		{
			if (!true)
			{
			}
			base..ctor();
			this._item = item;
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x0027EF4C File Offset: 0x0027D14C
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			Item item = this._item;
			Item item2 = this._item;
			float scale = item2.scale;
			if (item2 == null)
			{
			}
			if (556 == 0)
			{
			}
		}

		// Token: 0x040089B0 RID: 35248
		private Item _item;

		// Token: 0x040089B1 RID: 35249
		private bool _blackedOut;
	}
}
