using System;
using System.IO;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x02000004 RID: 4
	public sealed class WriteDelegate : MulticastDelegate
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000020AC File Offset: 0x000002AC
		public WriteDelegate(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002100 File Offset: 0x00000300
		public void Invoke(string entryName, Stream stream)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002122 File Offset: 0x00000322
		public IAsyncResult BeginInvoke(string entryName, Stream stream, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002130 File Offset: 0x00000330
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
