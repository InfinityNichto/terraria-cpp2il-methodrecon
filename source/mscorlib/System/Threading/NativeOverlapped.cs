using System;

namespace System.Threading
{
	// Token: 0x020001CC RID: 460
	public struct NativeOverlapped
	{
		// Token: 0x0400091F RID: 2335
		public IntPtr InternalLow;

		// Token: 0x04000920 RID: 2336
		public IntPtr InternalHigh;

		// Token: 0x04000921 RID: 2337
		public int OffsetLow;

		// Token: 0x04000922 RID: 2338
		public int OffsetHigh;

		// Token: 0x04000923 RID: 2339
		public IntPtr EventHandle;
	}
}
