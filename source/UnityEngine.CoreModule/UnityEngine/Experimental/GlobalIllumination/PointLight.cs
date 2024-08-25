using System;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000130 RID: 304
	public struct PointLight
	{
		// Token: 0x0400051C RID: 1308
		public int instanceID;

		// Token: 0x0400051D RID: 1309
		public bool shadow;

		// Token: 0x0400051E RID: 1310
		public LightMode mode;

		// Token: 0x0400051F RID: 1311
		public Vector3 position;

		// Token: 0x04000520 RID: 1312
		public Quaternion orientation;

		// Token: 0x04000521 RID: 1313
		public LinearColor color;

		// Token: 0x04000522 RID: 1314
		public LinearColor indirectColor;

		// Token: 0x04000523 RID: 1315
		public float range;

		// Token: 0x04000524 RID: 1316
		public float sphereRadius;

		// Token: 0x04000525 RID: 1317
		public FalloffType falloff;
	}
}
