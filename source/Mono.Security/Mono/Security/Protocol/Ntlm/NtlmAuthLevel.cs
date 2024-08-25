using System;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x0200003C RID: 60
	public enum NtlmAuthLevel
	{
		// Token: 0x040000D9 RID: 217
		LM_and_NTLM,
		// Token: 0x040000DA RID: 218
		LM_and_NTLM_and_try_NTLMv2_Session,
		// Token: 0x040000DB RID: 219
		NTLM_only,
		// Token: 0x040000DC RID: 220
		NTLMv2_only
	}
}
