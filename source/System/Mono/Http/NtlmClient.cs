using System;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mono.Http
{
	// Token: 0x0200006D RID: 109
	internal class NtlmClient : global::System.Net.IAuthenticationModule
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		public global::System.Net.Authorization Authenticate(string challenge, global::System.Net.WebRequest webRequest, global::System.Net.ICredentials credentials)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005C28 File Offset: 0x00003E28
		public global::System.Net.Authorization PreAuthenticate(global::System.Net.WebRequest webRequest, global::System.Net.ICredentials credentials)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00005C38 File Offset: 0x00003E38
		public string AuthenticationType
		{
			get
			{
				return "NTLM";
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00005C4C File Offset: 0x00003E4C
		public bool CanPreAuthenticate
		{
			get
			{
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00005C5C File Offset: 0x00003E5C
		public NtlmClient()
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00005C70 File Offset: 0x00003E70
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmClient()
		{
		}

		// Token: 0x04000132 RID: 306
		private static readonly ConditionalWeakTable<global::System.Net.HttpWebRequest, NtlmSession> cache;

		// Token: 0x0200006E RID: 110
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600019D RID: 413 RVA: 0x00005C80 File Offset: 0x00003E80
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00005C90 File Offset: 0x00003E90
			public <>c()
			{
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
			internal NtlmSession <Authenticate>b__1_0(global::System.Net.HttpWebRequest x)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000133 RID: 307
			public static readonly Mono.Http.NtlmClient.<>c <>9;

			// Token: 0x04000134 RID: 308
			public static ConditionalWeakTable<global::System.Net.HttpWebRequest, NtlmSession>.CreateValueCallback <>9__1_0;
		}
	}
}
