using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002D1 RID: 721
	[Flags]
	[ComVisible(true)]
	[Serializable]
	public enum CspProviderFlags
	{
		// Token: 0x04000C92 RID: 3218
		NoFlags = 0,
		// Token: 0x04000C93 RID: 3219
		UseMachineKeyStore = 1,
		// Token: 0x04000C94 RID: 3220
		UseDefaultKeyContainer = 2,
		// Token: 0x04000C95 RID: 3221
		UseNonExportableKey = 4,
		// Token: 0x04000C96 RID: 3222
		UseExistingKey = 8,
		// Token: 0x04000C97 RID: 3223
		UseArchivableKey = 16,
		// Token: 0x04000C98 RID: 3224
		UseUserProtectedKey = 32,
		// Token: 0x04000C99 RID: 3225
		NoPrompt = 64,
		// Token: 0x04000C9A RID: 3226
		CreateEphemeralKey = 128
	}
}
