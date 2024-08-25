using System;

namespace Mono.Net.Security
{
	// Token: 0x02000051 RID: 81
	internal class AsyncHandshakeRequest : AsyncProtocolRequest
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000402C File Offset: 0x0000222C
		public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync)
			: base(parent, sync)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004044 File Offset: 0x00002244
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			MobileAuthenticatedStream <Parent>k__BackingField = this.<Parent>k__BackingField;
			long num = 0L;
			return <Parent>k__BackingField.ProcessHandshake(status, num != 0L);
		}
	}
}
