using System;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x02000725 RID: 1829
	public class UIScrollWheelEvent : UIMouseEvent
	{
		// Token: 0x06003C93 RID: 15507 RVA: 0x00236C04 File Offset: 0x00234E04
		public UIScrollWheelEvent(UIElement target, Vector2 mousePosition, int scrollWheelValue)
		{
			this.Target = target;
			this.ScrollWheelValue = mousePosition;
		}

		// Token: 0x04007BB5 RID: 31669
		public readonly int ScrollWheelValue;
	}
}
