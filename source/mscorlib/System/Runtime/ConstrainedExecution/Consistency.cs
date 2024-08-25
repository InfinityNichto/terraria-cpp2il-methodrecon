using System;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x0200045E RID: 1118
	public enum Consistency
	{
		// Token: 0x0400129C RID: 4764
		MayCorruptProcess,
		// Token: 0x0400129D RID: 4765
		MayCorruptAppDomain,
		// Token: 0x0400129E RID: 4766
		MayCorruptInstance,
		// Token: 0x0400129F RID: 4767
		WillNotCorruptState
	}
}
