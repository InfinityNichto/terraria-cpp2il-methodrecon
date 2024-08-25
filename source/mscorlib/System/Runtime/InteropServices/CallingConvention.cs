using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200044C RID: 1100
	[ComVisible(true)]
	[Serializable]
	public enum CallingConvention
	{
		// Token: 0x04001276 RID: 4726
		Winapi = 1,
		// Token: 0x04001277 RID: 4727
		Cdecl,
		// Token: 0x04001278 RID: 4728
		StdCall,
		// Token: 0x04001279 RID: 4729
		ThisCall,
		// Token: 0x0400127A RID: 4730
		FastCall
	}
}
