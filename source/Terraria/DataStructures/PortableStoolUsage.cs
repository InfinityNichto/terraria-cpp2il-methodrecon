using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200064A RID: 1610
	public struct PortableStoolUsage
	{
		// Token: 0x060036E8 RID: 14056 RVA: 0x00220C24 File Offset: 0x0021EE24
		public void Reset()
		{
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00220C34 File Offset: 0x0021EE34
		public void SetStats(int heightBoost, int visualYOffset, int mapYOffset)
		{
			this.HeightBoost = heightBoost;
			this.MapYOffset = visualYOffset;
			this.HasAStool = true;
			this.MapYOffset = mapYOffset;
		}

		// Token: 0x040077F2 RID: 30706
		public bool HasAStool;

		// Token: 0x040077F3 RID: 30707
		public bool IsInUse;

		// Token: 0x040077F4 RID: 30708
		public int HeightBoost;

		// Token: 0x040077F5 RID: 30709
		public int VisualYOffset;

		// Token: 0x040077F6 RID: 30710
		public int MapYOffset;
	}
}
