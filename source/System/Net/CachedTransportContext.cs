using System;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net
{
	// Token: 0x020001C6 RID: 454
	internal class CachedTransportContext : TransportContext
	{
		// Token: 0x06000AE5 RID: 2789 RVA: 0x00023FBC File Offset: 0x000221BC
		internal CachedTransportContext(global::System.Security.Authentication.ExtendedProtection.ChannelBinding binding)
		{
			this.binding = binding;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00023FD8 File Offset: 0x000221D8
		public override global::System.Security.Authentication.ExtendedProtection.ChannelBinding GetChannelBinding(global::System.Security.Authentication.ExtendedProtection.ChannelBindingKind kind)
		{
			return this.binding;
		}

		// Token: 0x0400098E RID: 2446
		private global::System.Security.Authentication.ExtendedProtection.ChannelBinding binding;
	}
}
