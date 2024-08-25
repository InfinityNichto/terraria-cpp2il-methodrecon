using System;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public sealed class AndroidJavaRunnable : MulticastDelegate
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00003420 File Offset: 0x00001620
		public AndroidJavaRunnable(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003474 File Offset: 0x00001674
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
