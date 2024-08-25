using System;
using Cpp2IlInjected;

namespace Terraria.Net.Sockets
{
	// Token: 0x020006AE RID: 1710
	public sealed class SocketConnectionAccepted : MulticastDelegate
	{
		// Token: 0x060038BD RID: 14525 RVA: 0x002265EC File Offset: 0x002247EC
		public SocketConnectionAccepted(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x0022664C File Offset: 0x0022484C
		public void Invoke(ISocket client)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(ISocket client, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00226670 File Offset: 0x00224870
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
