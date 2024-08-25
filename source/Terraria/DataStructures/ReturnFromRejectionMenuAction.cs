using System;
using Cpp2IlInjected;

namespace Terraria.DataStructures
{
	// Token: 0x0200066B RID: 1643
	public sealed class ReturnFromRejectionMenuAction : MulticastDelegate
	{
		// Token: 0x06003709 RID: 14089 RVA: 0x00220FB0 File Offset: 0x0021F1B0
		public ReturnFromRejectionMenuAction(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00221004 File Offset: 0x0021F204
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00221028 File Offset: 0x0021F228
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
