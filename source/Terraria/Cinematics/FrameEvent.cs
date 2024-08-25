using System;
using Cpp2IlInjected;

namespace Terraria.Cinematics
{
	// Token: 0x02000791 RID: 1937
	public sealed class FrameEvent : MulticastDelegate
	{
		// Token: 0x06003F63 RID: 16227 RVA: 0x002408C8 File Offset: 0x0023EAC8
		public FrameEvent(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x0024091C File Offset: 0x0023EB1C
		public void Invoke(FrameEventData evt)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(FrameEventData evt, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x00240940 File Offset: 0x0023EB40
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
