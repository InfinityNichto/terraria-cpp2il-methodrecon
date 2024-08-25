using System;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000132 RID: 306
	public struct RectangleLight
	{
		// Token: 0x04000533 RID: 1331
		public int instanceID;

		// Token: 0x04000534 RID: 1332
		public bool shadow;

		// Token: 0x04000535 RID: 1333
		public LightMode mode;

		// Token: 0x04000536 RID: 1334
		public Vector3 position;

		// Token: 0x04000537 RID: 1335
		public Quaternion orientation;

		// Token: 0x04000538 RID: 1336
		public LinearColor color;

		// Token: 0x04000539 RID: 1337
		public LinearColor indirectColor;

		// Token: 0x0400053A RID: 1338
		public float range;

		// Token: 0x0400053B RID: 1339
		public float width;

		// Token: 0x0400053C RID: 1340
		public float height;

		// Token: 0x0400053D RID: 1341
		public FalloffType falloff;
	}
}
