using System;
using System.Configuration;

namespace System.Net.Configuration
{
	// Token: 0x02000471 RID: 1137
	public sealed class HttpListenerElement : ConfigurationElement
	{
		// Token: 0x06001ED2 RID: 7890 RVA: 0x000512A4 File Offset: 0x0004F4A4
		public HttpListenerElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x000512B8 File Offset: 0x0004F4B8
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x000512CC File Offset: 0x0004F4CC
		public HttpListenerTimeoutsElement Timeouts
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000512E0 File Offset: 0x0004F4E0
		public bool UnescapeRequestUrl
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
