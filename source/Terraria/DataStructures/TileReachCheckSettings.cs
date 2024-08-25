using System;
using System.Runtime.InteropServices;

namespace Terraria.DataStructures
{
	// Token: 0x02000680 RID: 1664
	public struct TileReachCheckSettings
	{
		// Token: 0x0600378D RID: 14221 RVA: 0x00221D54 File Offset: 0x0021FF54
		public void GetRanges(Player player, [Out] int x, [Out] int y)
		{
			if (!true)
			{
			}
			int tileRangeX = Player.tileRangeX;
			int tileRangeY = Player.tileRangeY;
			x.m_value = tileRangeY;
			y.m_value = tileRangeY;
			if (this.OverrideXReach != null)
			{
				x.m_value = ref this;
			}
			if (this.OverrideYReach != null)
			{
				y.m_value = ref this;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x00221DA0 File Offset: 0x0021FFA0
		public static TileReachCheckSettings Simple
		{
			get
			{
				TileReachCheckSettings tileReachCheckSettings;
				tileReachCheckSettings.TileRangeMultiplier = 1;
				return 1;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x00221DB8 File Offset: 0x0021FFB8
		public static TileReachCheckSettings Pylons
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x00221DC8 File Offset: 0x0021FFC8
		public static TileReachCheckSettings QuickStackToNearbyChests
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x04007891 RID: 30865
		public int TileRangeMultiplier;

		// Token: 0x04007892 RID: 30866
		public int? TileReachLimit;

		// Token: 0x04007893 RID: 30867
		public int? OverrideXReach;

		// Token: 0x04007894 RID: 30868
		public int? OverrideYReach;
	}
}
