using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200020A RID: 522
	[Serializable]
	internal sealed class EmptyWebProxy : IAutoWebProxy, IWebProxy
	{
		// Token: 0x06000CBD RID: 3261 RVA: 0x000289CC File Offset: 0x00026BCC
		public EmptyWebProxy()
		{
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000289E0 File Offset: 0x00026BE0
		public global::System.Uri GetProxy(global::System.Uri uri)
		{
			return uri;
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x000289F0 File Offset: 0x00026BF0
		public bool IsBypassed(global::System.Uri uri)
		{
			return true;
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00028A00 File Offset: 0x00026C00
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00028A14 File Offset: 0x00026C14
		public ICredentials Credentials
		{
			get
			{
				return this.m_credentials;
			}
			set
			{
				this.m_credentials = value;
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
		ProxyChain IAutoWebProxy.GetProxies(global::System.Uri destination)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000ADF RID: 2783
		[NonSerialized]
		private ICredentials m_credentials;
	}
}
