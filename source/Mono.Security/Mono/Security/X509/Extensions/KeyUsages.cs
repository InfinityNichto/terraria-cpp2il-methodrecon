using System;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x02000036 RID: 54
	[Flags]
	public enum KeyUsages
	{
		// Token: 0x040000C1 RID: 193
		digitalSignature = 128,
		// Token: 0x040000C2 RID: 194
		nonRepudiation = 64,
		// Token: 0x040000C3 RID: 195
		keyEncipherment = 32,
		// Token: 0x040000C4 RID: 196
		dataEncipherment = 16,
		// Token: 0x040000C5 RID: 197
		keyAgreement = 8,
		// Token: 0x040000C6 RID: 198
		keyCertSign = 4,
		// Token: 0x040000C7 RID: 199
		cRLSign = 2,
		// Token: 0x040000C8 RID: 200
		encipherOnly = 1,
		// Token: 0x040000C9 RID: 201
		decipherOnly = 2048,
		// Token: 0x040000CA RID: 202
		none = 0
	}
}
