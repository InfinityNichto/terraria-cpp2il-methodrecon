using System;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200012F RID: 303
	public struct DirectionalLight
	{
		// Token: 0x04000513 RID: 1299
		public int instanceID;

		// Token: 0x04000514 RID: 1300
		public bool shadow;

		// Token: 0x04000515 RID: 1301
		public LightMode mode;

		// Token: 0x04000516 RID: 1302
		public Vector3 position;

		// Token: 0x04000517 RID: 1303
		public Quaternion orientation;

		// Token: 0x04000518 RID: 1304
		public LinearColor color;

		// Token: 0x04000519 RID: 1305
		public LinearColor indirectColor;

		// Token: 0x0400051A RID: 1306
		public float penumbraWidthRadian;

		// Token: 0x0400051B RID: 1307
		[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", true)]
		public Vector3 direction;
	}
}
