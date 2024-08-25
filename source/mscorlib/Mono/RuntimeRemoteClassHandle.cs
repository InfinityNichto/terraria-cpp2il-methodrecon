using System;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000014 RID: 20
	internal struct RuntimeRemoteClassHandle
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000207A File Offset: 0x0000027A
		internal RuntimeClassHandle ProxyClass
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0400008C RID: 140
		private unsafe RuntimeStructs.RemoteClass* value;
	}
}
