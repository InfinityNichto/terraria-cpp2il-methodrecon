using System;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000133 RID: 307
	public struct DiscLight
	{
		// Token: 0x0400053E RID: 1342
		public int instanceID;

		// Token: 0x0400053F RID: 1343
		public bool shadow;

		// Token: 0x04000540 RID: 1344
		public LightMode mode;

		// Token: 0x04000541 RID: 1345
		public Vector3 position;

		// Token: 0x04000542 RID: 1346
		public Quaternion orientation;

		// Token: 0x04000543 RID: 1347
		public LinearColor color;

		// Token: 0x04000544 RID: 1348
		public LinearColor indirectColor;

		// Token: 0x04000545 RID: 1349
		public float range;

		// Token: 0x04000546 RID: 1350
		public float radius;

		// Token: 0x04000547 RID: 1351
		public FalloffType falloff;
	}
}
