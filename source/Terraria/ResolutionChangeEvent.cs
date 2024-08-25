using System;
using Cpp2IlInjected;

namespace Terraria
{
	// Token: 0x0200043D RID: 1085
	public sealed class ResolutionChangeEvent : MulticastDelegate
	{
		// Token: 0x060028DD RID: 10461 RVA: 0x001971B8 File Offset: 0x001953B8
		public ResolutionChangeEvent(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0019720C File Offset: 0x0019540C
		public void Invoke(int width, int height)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(int width, int height, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x00197230 File Offset: 0x00195430
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
