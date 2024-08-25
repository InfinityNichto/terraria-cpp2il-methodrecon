using System;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x0200003E RID: 62
	public static class NtlmSettings
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00008388 File Offset: 0x00006588
		public static NtlmAuthLevel DefaultAuthLevel
		{
			get
			{
				if (!true)
				{
				}
				return NtlmAuthLevel.LM_and_NTLM_and_try_NTLMv2_Session;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000839C File Offset: 0x0000659C
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmSettings()
		{
		}

		// Token: 0x040000E8 RID: 232
		private static NtlmAuthLevel defaultAuthLevel;
	}
}
