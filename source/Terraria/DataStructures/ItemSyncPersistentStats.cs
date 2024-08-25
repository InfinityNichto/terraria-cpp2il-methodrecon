using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000634 RID: 1588
	public struct ItemSyncPersistentStats
	{
		// Token: 0x0600362A RID: 13866 RVA: 0x0021240C File Offset: 0x0021060C
		public void CopyFrom(Item item)
		{
			int num = item.type;
			this.type = num;
			Color color = item.color;
			this.color = color;
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00212438 File Offset: 0x00210638
		public void PasteInto(Item item)
		{
			int num = this.type;
			int num2 = item.type;
		}

		// Token: 0x040076EA RID: 30442
		private Color color;

		// Token: 0x040076EB RID: 30443
		private int type;
	}
}
