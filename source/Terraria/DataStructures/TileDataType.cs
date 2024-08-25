using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000678 RID: 1656
	[Flags]
	public enum TileDataType
	{
		// Token: 0x04007833 RID: 30771
		Tile = 1,
		// Token: 0x04007834 RID: 30772
		TilePaint = 2,
		// Token: 0x04007835 RID: 30773
		Wall = 4,
		// Token: 0x04007836 RID: 30774
		WallPaint = 8,
		// Token: 0x04007837 RID: 30775
		Liquid = 16,
		// Token: 0x04007838 RID: 30776
		Wiring = 32,
		// Token: 0x04007839 RID: 30777
		Actuator = 64,
		// Token: 0x0400783A RID: 30778
		Slope = 128,
		// Token: 0x0400783B RID: 30779
		All = 255
	}
}
