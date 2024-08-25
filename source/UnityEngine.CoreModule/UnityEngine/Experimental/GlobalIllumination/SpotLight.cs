using System;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000131 RID: 305
	public struct SpotLight
	{
		// Token: 0x04000526 RID: 1318
		public int instanceID;

		// Token: 0x04000527 RID: 1319
		public bool shadow;

		// Token: 0x04000528 RID: 1320
		public LightMode mode;

		// Token: 0x04000529 RID: 1321
		public Vector3 position;

		// Token: 0x0400052A RID: 1322
		public Quaternion orientation;

		// Token: 0x0400052B RID: 1323
		public LinearColor color;

		// Token: 0x0400052C RID: 1324
		public LinearColor indirectColor;

		// Token: 0x0400052D RID: 1325
		public float range;

		// Token: 0x0400052E RID: 1326
		public float sphereRadius;

		// Token: 0x0400052F RID: 1327
		public float coneAngle;

		// Token: 0x04000530 RID: 1328
		public float innerConeAngle;

		// Token: 0x04000531 RID: 1329
		public FalloffType falloff;

		// Token: 0x04000532 RID: 1330
		public AngularFalloffType angularFalloff;
	}
}
