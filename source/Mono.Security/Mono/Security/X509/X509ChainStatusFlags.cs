using System;

namespace Mono.Security.X509
{
	// Token: 0x0200001A RID: 26
	[Flags]
	[Serializable]
	public enum X509ChainStatusFlags
	{
		// Token: 0x04000094 RID: 148
		InvalidBasicConstraints = 1024,
		// Token: 0x04000095 RID: 149
		NoError = 0,
		// Token: 0x04000096 RID: 150
		NotSignatureValid = 8,
		// Token: 0x04000097 RID: 151
		NotTimeNested = 2,
		// Token: 0x04000098 RID: 152
		NotTimeValid = 1,
		// Token: 0x04000099 RID: 153
		PartialChain = 65536,
		// Token: 0x0400009A RID: 154
		UntrustedRoot = 32
	}
}
