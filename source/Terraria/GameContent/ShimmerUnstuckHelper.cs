using System;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020007E9 RID: 2025
	public struct ShimmerUnstuckHelper
	{
		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x00244AF0 File Offset: 0x00242CF0
		public bool ShouldUnstuck
		{
			get
			{
				return !this.IndefiniteProtectionActive || true;
			}
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00244B08 File Offset: 0x00242D08
		public void Update(Player player)
		{
			if (player.shimmering || player.shimmerWet)
			{
				this.IndefiniteProtectionActive = true;
				this.TimeLeftUnstuck = 120;
				return;
			}
			Vector2 bottom = player.Bottom;
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00244B48 File Offset: 0x00242D48
		public void StartUnstuck()
		{
			this.IndefiniteProtectionActive = true;
			this.TimeLeftUnstuck = 120;
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00244B64 File Offset: 0x00242D64
		public void Clear()
		{
		}

		// Token: 0x04007ED8 RID: 32472
		public int TimeLeftUnstuck;

		// Token: 0x04007ED9 RID: 32473
		public bool IndefiniteProtectionActive;
	}
}
