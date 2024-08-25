using System;
using Cpp2IlInjected;

namespace Terraria.Social.Base
{
	// Token: 0x02000530 RID: 1328
	public sealed class ServerJoinRequestEvent : MulticastDelegate
	{
		// Token: 0x060031F1 RID: 12785 RVA: 0x001F8E64 File Offset: 0x001F7064
		public ServerJoinRequestEvent(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x001F8EC4 File Offset: 0x001F70C4
		public void Invoke(UserJoinToServerRequest request)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(UserJoinToServerRequest request, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x001F8EE8 File Offset: 0x001F70E8
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
