using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002CD RID: 717
	[ComVisible(true)]
	[Serializable]
	public enum PaddingMode
	{
		// Token: 0x04000C86 RID: 3206
		None = 1,
		// Token: 0x04000C87 RID: 3207
		PKCS7,
		// Token: 0x04000C88 RID: 3208
		Zeros,
		// Token: 0x04000C89 RID: 3209
		ANSIX923,
		// Token: 0x04000C8A RID: 3210
		ISO10126
	}
}
