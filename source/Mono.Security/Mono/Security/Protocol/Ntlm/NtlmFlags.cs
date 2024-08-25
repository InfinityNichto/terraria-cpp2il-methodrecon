using System;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x0200003D RID: 61
	[Flags]
	public enum NtlmFlags
	{
		// Token: 0x040000DE RID: 222
		NegotiateUnicode = 1,
		// Token: 0x040000DF RID: 223
		NegotiateOem = 2,
		// Token: 0x040000E0 RID: 224
		RequestTarget = 4,
		// Token: 0x040000E1 RID: 225
		NegotiateNtlm = 512,
		// Token: 0x040000E2 RID: 226
		NegotiateDomainSupplied = 4096,
		// Token: 0x040000E3 RID: 227
		NegotiateWorkstationSupplied = 8192,
		// Token: 0x040000E4 RID: 228
		NegotiateAlwaysSign = 32768,
		// Token: 0x040000E5 RID: 229
		NegotiateNtlm2Key = 524288,
		// Token: 0x040000E6 RID: 230
		Negotiate128 = 536870912,
		// Token: 0x040000E7 RID: 231
		Negotiate56 = -2147483648
	}
}
