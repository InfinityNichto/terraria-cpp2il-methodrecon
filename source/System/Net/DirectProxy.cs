using System;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x020001F9 RID: 505
	internal class DirectProxy : ProxyChain
	{
		// Token: 0x06000C70 RID: 3184 RVA: 0x00027B68 File Offset: 0x00025D68
		internal DirectProxy(global::System.Uri destination)
			: base(destination)
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00027B7C File Offset: 0x00025D7C
		protected override bool GetNextProxy([Out] global::System.Uri proxy)
		{
			if (this.m_ProxyRetrieved)
			{
			}
			return true;
		}

		// Token: 0x04000AAE RID: 2734
		private bool m_ProxyRetrieved;
	}
}
