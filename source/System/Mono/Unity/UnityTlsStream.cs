using System;
using System.IO;
using System.Net.Security;
using Cpp2IlInjected;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono.Unity
{
	// Token: 0x02000047 RID: 71
	internal class UnityTlsStream : Mono.Net.Security.MobileAuthenticatedStream
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x000039B8 File Offset: 0x00001BB8
		public UnityTlsStream(Stream innerStream, bool leaveInnerStreamOpen, global::System.Net.Security.SslStream owner, MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider)
		{
			if (!true)
			{
			}
			base..ctor(innerStream, leaveInnerStreamOpen, owner, settings, provider);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		protected override Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
