using System;
using UnityEngine.Scripting;

namespace Unity.Collections
{
	// Token: 0x02000017 RID: 23
	[UsedByNativeCode]
	public enum Allocator
	{
		// Token: 0x04000042 RID: 66
		Invalid,
		// Token: 0x04000043 RID: 67
		None,
		// Token: 0x04000044 RID: 68
		Temp,
		// Token: 0x04000045 RID: 69
		TempJob,
		// Token: 0x04000046 RID: 70
		Persistent,
		// Token: 0x04000047 RID: 71
		AudioKernel
	}
}
