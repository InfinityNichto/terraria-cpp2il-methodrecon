using System;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x020001FA RID: 506
	internal class StaticProxy : ProxyChain
	{
		// Token: 0x06000C72 RID: 3186 RVA: 0x00027B94 File Offset: 0x00025D94
		internal StaticProxy(global::System.Uri destination, global::System.Uri proxy)
			: base(destination)
		{
			if (!true)
			{
			}
			this.m_Proxy = proxy;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00027BB4 File Offset: 0x00025DB4
		protected override bool GetNextProxy([Out] global::System.Uri proxy)
		{
			global::System.Uri proxy2 = this.m_Proxy;
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x04000AAF RID: 2735
		private global::System.Uri m_Proxy;
	}
}
