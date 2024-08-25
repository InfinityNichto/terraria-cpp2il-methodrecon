using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001C5 RID: 453
	public abstract class TransportContext
	{
		// Token: 0x06000AE2 RID: 2786
		public abstract global::System.Security.Authentication.ExtendedProtection.ChannelBinding GetChannelBinding(global::System.Security.Authentication.ExtendedProtection.ChannelBindingKind kind);

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
		public virtual IEnumerable<global::System.Security.Authentication.ExtendedProtection.TokenBinding> GetTlsTokenBindings()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00023FA8 File Offset: 0x000221A8
		protected TransportContext()
		{
		}
	}
}
