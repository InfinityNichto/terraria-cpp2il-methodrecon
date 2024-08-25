using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002CC RID: 716
	[ComVisible(true)]
	[Serializable]
	public enum CipherMode
	{
		// Token: 0x04000C80 RID: 3200
		CBC = 1,
		// Token: 0x04000C81 RID: 3201
		ECB,
		// Token: 0x04000C82 RID: 3202
		OFB,
		// Token: 0x04000C83 RID: 3203
		CFB,
		// Token: 0x04000C84 RID: 3204
		CTS
	}
}
