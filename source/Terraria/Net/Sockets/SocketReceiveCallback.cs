using System;
using Cpp2IlInjected;

namespace Terraria.Net.Sockets
{
	// Token: 0x020006AC RID: 1708
	public sealed class SocketReceiveCallback : MulticastDelegate
	{
		// Token: 0x060038B5 RID: 14517 RVA: 0x002264C4 File Offset: 0x002246C4
		public SocketReceiveCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00226524 File Offset: 0x00224724
		public void Invoke(object state, int size)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(object state, int size, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00226548 File Offset: 0x00224748
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
