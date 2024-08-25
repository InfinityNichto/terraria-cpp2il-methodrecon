using System;
using System.Security.Authentication;

namespace Mono.Security.Interface
{
	// Token: 0x0200004C RID: 76
	public abstract class MonoTlsProvider
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00008C88 File Offset: 0x00006E88
		internal MonoTlsProvider()
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001FB RID: 507
		public abstract Guid ID { get; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001FC RID: 508
		public abstract string Name { get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001FD RID: 509
		public abstract bool SupportsSslStream { get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001FE RID: 510
		public abstract bool SupportsConnectionInfo { get; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001FF RID: 511
		public abstract bool SupportsMonoExtensions { get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000200 RID: 512
		public abstract SslProtocols SupportedProtocols { get; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000201 RID: 513
		internal abstract bool SupportsCleanShutdown { get; }
	}
}
