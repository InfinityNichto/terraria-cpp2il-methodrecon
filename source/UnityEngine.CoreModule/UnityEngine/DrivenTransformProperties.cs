using System;

namespace UnityEngine
{
	// Token: 0x020000E2 RID: 226
	[Flags]
	public enum DrivenTransformProperties
	{
		// Token: 0x040003DF RID: 991
		None = 0,
		// Token: 0x040003E0 RID: 992
		All = -1,
		// Token: 0x040003E1 RID: 993
		AnchoredPositionX = 2,
		// Token: 0x040003E2 RID: 994
		AnchoredPositionY = 4,
		// Token: 0x040003E3 RID: 995
		AnchoredPositionZ = 8,
		// Token: 0x040003E4 RID: 996
		Rotation = 16,
		// Token: 0x040003E5 RID: 997
		ScaleX = 32,
		// Token: 0x040003E6 RID: 998
		ScaleY = 64,
		// Token: 0x040003E7 RID: 999
		ScaleZ = 128,
		// Token: 0x040003E8 RID: 1000
		AnchorMinX = 256,
		// Token: 0x040003E9 RID: 1001
		AnchorMinY = 512,
		// Token: 0x040003EA RID: 1002
		AnchorMaxX = 1024,
		// Token: 0x040003EB RID: 1003
		AnchorMaxY = 2048,
		// Token: 0x040003EC RID: 1004
		SizeDeltaX = 4096,
		// Token: 0x040003ED RID: 1005
		SizeDeltaY = 8192,
		// Token: 0x040003EE RID: 1006
		PivotX = 16384,
		// Token: 0x040003EF RID: 1007
		PivotY = 32768,
		// Token: 0x040003F0 RID: 1008
		AnchoredPosition = 6,
		// Token: 0x040003F1 RID: 1009
		AnchoredPosition3D = 14,
		// Token: 0x040003F2 RID: 1010
		Scale = 224,
		// Token: 0x040003F3 RID: 1011
		AnchorMin = 768,
		// Token: 0x040003F4 RID: 1012
		AnchorMax = 3072,
		// Token: 0x040003F5 RID: 1013
		Anchors = 3840,
		// Token: 0x040003F6 RID: 1014
		SizeDelta = 12288,
		// Token: 0x040003F7 RID: 1015
		Pivot = 49152
	}
}
