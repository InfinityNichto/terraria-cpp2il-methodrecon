using System;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x02000724 RID: 1828
	public class UIMouseEvent : UIEvent
	{
		// Token: 0x06003C92 RID: 15506 RVA: 0x00236BE8 File Offset: 0x00234DE8
		public UIMouseEvent(UIElement target, Vector2 mousePosition)
		{
			this.Target = target;
		}

		// Token: 0x04007BB4 RID: 31668
		public readonly Vector2 MousePosition;
	}
}
