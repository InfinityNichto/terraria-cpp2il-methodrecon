using System;
using Cpp2IlInjected;

namespace Terraria.Net.Sockets
{
	// Token: 0x020006AD RID: 1709
	public sealed class SocketSendCallback : MulticastDelegate
	{
		// Token: 0x060038B9 RID: 14521 RVA: 0x00226558 File Offset: 0x00224758
		public SocketSendCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x002265B8 File Offset: 0x002247B8
		public void Invoke(object state)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(object state, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x002265DC File Offset: 0x002247DC
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
