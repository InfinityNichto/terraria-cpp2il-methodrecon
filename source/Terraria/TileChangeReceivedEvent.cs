using System;
using Cpp2IlInjected;
using Terraria.ID;

namespace Terraria
{
	// Token: 0x0200043E RID: 1086
	public sealed class TileChangeReceivedEvent : MulticastDelegate
	{
		// Token: 0x060028E1 RID: 10465 RVA: 0x00197240 File Offset: 0x00195440
		public TileChangeReceivedEvent(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x00197294 File Offset: 0x00195494
		public void Invoke(int x, int y, int count, TileChangeType type)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(int x, int y, int count, TileChangeType type, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x001972B8 File Offset: 0x001954B8
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
