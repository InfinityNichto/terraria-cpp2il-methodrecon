using System;

namespace Terraria.UI
{
	// Token: 0x02000723 RID: 1827
	public class UIEvent
	{
		// Token: 0x06003C91 RID: 15505 RVA: 0x00236BCC File Offset: 0x00234DCC
		public UIEvent(UIElement target)
		{
			this.Target = target;
		}

		// Token: 0x04007BB3 RID: 31667
		public readonly UIElement Target;
	}
}
