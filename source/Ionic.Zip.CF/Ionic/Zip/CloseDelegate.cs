using System;
using System.IO;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x02000006 RID: 6
	public sealed class CloseDelegate : MulticastDelegate
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000021B8 File Offset: 0x000003B8
		public CloseDelegate(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000220C File Offset: 0x0000040C
		public void Invoke(string entryName, Stream stream)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002122 File Offset: 0x00000322
		public IAsyncResult BeginInvoke(string entryName, Stream stream, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002230 File Offset: 0x00000430
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
